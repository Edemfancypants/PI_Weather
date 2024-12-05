namespace Projektmunka_WeatherStation
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Stats_tabPage = new System.Windows.Forms.TabPage();
            this.Time_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.City_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTN_Refresh = new System.Windows.Forms.Button();
            this.SelectStats_tabPage = new System.Windows.Forms.TabPage();
            this.ForecastLen_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Temperature_checkBox = new System.Windows.Forms.CheckBox();
            this.City_textBox = new System.Windows.Forms.TextBox();
            this.Humidity_checkBox = new System.Windows.Forms.CheckBox();
            this.Pressure_checkBox = new System.Windows.Forms.CheckBox();
            this.Description_checkBox = new System.Windows.Forms.CheckBox();
            this.DetailedDescription_checkBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.settingsControl_Packaging1 = new Projektmunka_WeatherStation.SettingsControl_Packaging();
            this.tabControl1.SuspendLayout();
            this.Stats_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SelectStats_tabPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Stats_tabPage);
            this.tabControl1.Controls.Add(this.SelectStats_tabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(975, 712);
            this.tabControl1.TabIndex = 0;
            // 
            // Stats_tabPage
            // 
            this.Stats_tabPage.Controls.Add(this.Time_label);
            this.Stats_tabPage.Controls.Add(this.label3);
            this.Stats_tabPage.Controls.Add(this.City_label);
            this.Stats_tabPage.Controls.Add(this.label1);
            this.Stats_tabPage.Controls.Add(this.dataGridView1);
            this.Stats_tabPage.Controls.Add(this.panel1);
            this.Stats_tabPage.Location = new System.Drawing.Point(4, 25);
            this.Stats_tabPage.Name = "Stats_tabPage";
            this.Stats_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.Stats_tabPage.Size = new System.Drawing.Size(967, 683);
            this.Stats_tabPage.TabIndex = 0;
            this.Stats_tabPage.Text = "Statisztikák";
            this.Stats_tabPage.UseVisualStyleBackColor = true;
            // 
            // Time_label
            // 
            this.Time_label.AutoSize = true;
            this.Time_label.Font = new System.Drawing.Font("Rajdhani", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Time_label.Location = new System.Drawing.Point(800, 19);
            this.Time_label.Name = "Time_label";
            this.Time_label.Size = new System.Drawing.Size(122, 32);
            this.Time_label.TabIndex = 5;
            this.Time_label.Text = "Nincs Adat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rajdhani", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(398, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(380, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Előrejelzett adatbejegyzések száma:";
            // 
            // City_label
            // 
            this.City_label.AutoSize = true;
            this.City_label.Font = new System.Drawing.Font("Rajdhani", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.City_label.Location = new System.Drawing.Point(213, 19);
            this.City_label.Name = "City_label";
            this.City_label.Size = new System.Drawing.Size(122, 32);
            this.City_label.TabIndex = 3;
            this.City_label.Text = "Nincs Adat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rajdhani", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kiválasztott város:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(3, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(961, 542);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BTN_Refresh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 612);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(961, 68);
            this.panel1.TabIndex = 1;
            // 
            // BTN_Refresh
            // 
            this.BTN_Refresh.Font = new System.Drawing.Font("Rajdhani", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BTN_Refresh.Location = new System.Drawing.Point(782, 6);
            this.BTN_Refresh.Name = "BTN_Refresh";
            this.BTN_Refresh.Size = new System.Drawing.Size(174, 59);
            this.BTN_Refresh.TabIndex = 6;
            this.BTN_Refresh.Text = "Frissít";
            this.BTN_Refresh.UseVisualStyleBackColor = true;
            this.BTN_Refresh.Click += new System.EventHandler(this.BTN_Refresh_Click);
            // 
            // SelectStats_tabPage
            // 
            this.SelectStats_tabPage.Controls.Add(this.groupBox2);
            this.SelectStats_tabPage.Controls.Add(this.groupBox1);
            this.SelectStats_tabPage.Location = new System.Drawing.Point(4, 25);
            this.SelectStats_tabPage.Name = "SelectStats_tabPage";
            this.SelectStats_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SelectStats_tabPage.Size = new System.Drawing.Size(967, 683);
            this.SelectStats_tabPage.TabIndex = 1;
            this.SelectStats_tabPage.Text = "Város választás";
            this.SelectStats_tabPage.UseVisualStyleBackColor = true;
            // 
            // ForecastLen_textBox
            // 
            this.ForecastLen_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForecastLen_textBox.Location = new System.Drawing.Point(280, 67);
            this.ForecastLen_textBox.Name = "ForecastLen_textBox";
            this.ForecastLen_textBox.Size = new System.Drawing.Size(36, 26);
            this.ForecastLen_textBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rajdhani", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(274, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mérési adatok száma:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rajdhani", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(6, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Szűrők:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rajdhani", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kiválasztott város:";
            // 
            // Temperature_checkBox
            // 
            this.Temperature_checkBox.AutoSize = true;
            this.Temperature_checkBox.Location = new System.Drawing.Point(12, 146);
            this.Temperature_checkBox.Name = "Temperature_checkBox";
            this.Temperature_checkBox.Size = new System.Drawing.Size(143, 29);
            this.Temperature_checkBox.TabIndex = 1;
            this.Temperature_checkBox.Text = "Hőmérséklet";
            this.Temperature_checkBox.UseVisualStyleBackColor = true;
            // 
            // City_textBox
            // 
            this.City_textBox.Location = new System.Drawing.Point(12, 67);
            this.City_textBox.Name = "City_textBox";
            this.City_textBox.Size = new System.Drawing.Size(242, 30);
            this.City_textBox.TabIndex = 11;
            // 
            // Humidity_checkBox
            // 
            this.Humidity_checkBox.AutoSize = true;
            this.Humidity_checkBox.Location = new System.Drawing.Point(12, 172);
            this.Humidity_checkBox.Name = "Humidity_checkBox";
            this.Humidity_checkBox.Size = new System.Drawing.Size(144, 29);
            this.Humidity_checkBox.TabIndex = 12;
            this.Humidity_checkBox.Text = "Páratartalom";
            this.Humidity_checkBox.UseVisualStyleBackColor = true;
            // 
            // Pressure_checkBox
            // 
            this.Pressure_checkBox.AutoSize = true;
            this.Pressure_checkBox.Location = new System.Drawing.Point(12, 198);
            this.Pressure_checkBox.Name = "Pressure_checkBox";
            this.Pressure_checkBox.Size = new System.Drawing.Size(136, 29);
            this.Pressure_checkBox.TabIndex = 13;
            this.Pressure_checkBox.Text = "Légnyomás";
            this.Pressure_checkBox.UseVisualStyleBackColor = true;
            // 
            // Description_checkBox
            // 
            this.Description_checkBox.AutoSize = true;
            this.Description_checkBox.Location = new System.Drawing.Point(12, 224);
            this.Description_checkBox.Name = "Description_checkBox";
            this.Description_checkBox.Size = new System.Drawing.Size(166, 29);
            this.Description_checkBox.TabIndex = 14;
            this.Description_checkBox.Text = "Általános leírás";
            this.Description_checkBox.UseVisualStyleBackColor = true;
            // 
            // DetailedDescription_checkBox
            // 
            this.DetailedDescription_checkBox.AutoSize = true;
            this.DetailedDescription_checkBox.Location = new System.Drawing.Point(12, 250);
            this.DetailedDescription_checkBox.Name = "DetailedDescription_checkBox";
            this.DetailedDescription_checkBox.Size = new System.Drawing.Size(177, 29);
            this.DetailedDescription_checkBox.TabIndex = 15;
            this.DetailedDescription_checkBox.Text = "Részletes Leírás";
            this.DetailedDescription_checkBox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.settingsControl_Packaging1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(543, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 491);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Program Változók";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.Temperature_checkBox);
            this.groupBox2.Controls.Add(this.DetailedDescription_checkBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Description_checkBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.Pressure_checkBox);
            this.groupBox2.Controls.Add(this.ForecastLen_textBox);
            this.groupBox2.Controls.Add(this.Humidity_checkBox);
            this.groupBox2.Controls.Add(this.City_textBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox2.Location = new System.Drawing.Point(8, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(515, 296);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adat változók";
            // 
            // settingsControl_Packaging1
            // 
            this.settingsControl_Packaging1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsControl_Packaging1.Location = new System.Drawing.Point(3, 26);
            this.settingsControl_Packaging1.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.settingsControl_Packaging1.Name = "settingsControl_Packaging1";
            this.settingsControl_Packaging1.Size = new System.Drawing.Size(409, 462);
            this.settingsControl_Packaging1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 712);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PI Weather";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Stats_tabPage.ResumeLayout(false);
            this.Stats_tabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.SelectStats_tabPage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Stats_tabPage;
        private System.Windows.Forms.TabPage SelectStats_tabPage;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Time_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label City_label;
        private System.Windows.Forms.Button BTN_Refresh;
        private System.Windows.Forms.CheckBox Temperature_checkBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ForecastLen_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox City_textBox;
        private System.Windows.Forms.CheckBox Humidity_checkBox;
        private System.Windows.Forms.CheckBox Pressure_checkBox;
        private System.Windows.Forms.CheckBox DetailedDescription_checkBox;
        private System.Windows.Forms.CheckBox Description_checkBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private SettingsControl_Packaging settingsControl_Packaging1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

