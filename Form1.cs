using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Projektmunka_WeatherStation
{
    public partial class Form1 : Form
    {
        private readonly string RaspberryPiUrl;

        public Form1()
        {
            InitializeComponent();
            RaspberryPiUrl = $"http://{Properties.Settings.Default.RemoteIP}:{Properties.Settings.Default.RemotePort}/weather";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void BTN_Refresh_Click(object sender, EventArgs e)
        {
            string cityName = City_textBox.Text;
            int forecastLength = 0;

            if (!int.TryParse(ForecastLen_textBox.Text, out forecastLength) || forecastLength <= 0)
            {
                MessageBox.Show("Kérlek, adj meg egy érvényes előrejelzési hosszt (pozitív egész számot).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(cityName))
            {
                MessageBox.Show("Kérlek, adj meg egy érvényes városnevet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string weatherData = await GetWeatherFromRaspberryPiAsync(cityName);

                City_label.Text = cityName;
                Time_label.Text = forecastLength.ToString();
                PopulateDataGridView(weatherData, forecastLength);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching weather data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<string> GetWeatherFromRaspberryPiAsync(string cityName)
        {
            using (HttpClient client = new HttpClient())
            {
                string requestUrl = $"{RaspberryPiUrl}?city={Uri.EscapeDataString(cityName)}";

                HttpResponseMessage response = await client.GetAsync(requestUrl);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    throw new Exception($"Server returned status code {response.StatusCode}");
                }
            }
        }

        private void PopulateDataGridView(string weatherData, int forecastLength)
        {
            try
            {
                JObject weatherJson = JObject.Parse(weatherData);
                DataTable dt = new DataTable();

                dt.Columns.Add("Date");
                dt.Columns.Add("Time");
                dt.Columns.Add("Temperature");
                dt.Columns.Add("Humidity");
                dt.Columns.Add("Pressure");
                dt.Columns.Add("Main");
                dt.Columns.Add("Description");

                var forecasts = weatherJson["forecast"];
                int count = 0;

                foreach (var forecast in forecasts)
                {
                    if (count >= forecastLength)
                        break;

                    string date = forecast["date"]?.ToString();
                    string time = forecast["time"]?.ToString();
                    string temperature = forecast["temperature"]?.ToString() + " °C";
                    string humidity = forecast["humidity"]?.ToString() + " %";
                    string pressure = forecast["pressure"]?.ToString() + " hPa";
                    string main = forecast["main"]?.ToString();
                    string description = forecast["description"]?.ToString();

                    dt.Rows.Add(date, time, temperature, humidity, pressure, main, description);

                    count++;
                }

                dataGridView1.DataSource = dt;

                dataGridView1.RowHeadersVisible = false;
                dataGridView1.ReadOnly = true;

                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AllowUserToDeleteRows = false;
                dataGridView1.AllowUserToResizeRows = false;
                dataGridView1.AllowUserToResizeColumns = false;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;

                dataGridView1.Columns[0].HeaderText = "Dátum";
                dataGridView1.Columns[1].HeaderText = "Idő";
                dataGridView1.Columns[2].HeaderText = "Hőmérséklet";
                dataGridView1.Columns[3].HeaderText = "Páratartalom";
                dataGridView1.Columns[4].HeaderText = "Légnyomás";
                dataGridView1.Columns[5].HeaderText = "Általános leírás";
                dataGridView1.Columns[6].HeaderText = "Részletes leírás";

                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }

                RemoveUncheckedColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error parsing weather data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RemoveUncheckedColumns()
        {
            var columnMappings = new Dictionary<CheckBox, string>
            {
                { Temperature_checkBox, "Temperature" },
                { Humidity_checkBox, "Humidity" },
                { Pressure_checkBox, "Pressure" },
                { Description_checkBox, "Main" },
                { DetailedDescription_checkBox, "Description" }
            };

            foreach (var mapping in columnMappings)
            {
                if (!mapping.Key.Checked)
                {
                    if (dataGridView1.Columns.Contains(mapping.Value))
                    {
                        dataGridView1.Columns.Remove(mapping.Value);
                    }
                }
            }
        }

        public class FileItem
        {
            public string FileName { get; set; }
            public string FullPath { get; set; }
        }
    }
}
