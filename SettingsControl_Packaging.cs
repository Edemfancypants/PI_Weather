using Projektmunka_WeatherStation.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projektmunka_WeatherStation
{
    public partial class SettingsControl_Packaging : UserControl
    {
        public event EventHandler ReloadRequested;

        public SettingsControl_Packaging()
        {
            InitializeComponent();
        }

        private void SettingsControl_Packaging_Load(object sender, EventArgs e)
        {
            SettingsGrid.SelectedObject = Settings.Default;
        }

        private void BTN_Save_Click(object sender, EventArgs e)
        {
            Settings.Default.Save();

            ReloadRequested?.Invoke(this, EventArgs.Empty);
        }

        private void BTN_Reset_Click(object sender, EventArgs e)
        {
            SettingsGrid.SelectedObject = Settings.Default;
        }
    }
}
