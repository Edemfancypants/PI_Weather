namespace Projektmunka_WeatherStation
{
    partial class SettingsControl_Packaging
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTN_Save = new System.Windows.Forms.Button();
            this.BTN_Reset = new System.Windows.Forms.Button();
            this.SettingsGrid = new System.Windows.Forms.PropertyGrid();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BTN_Save);
            this.panel1.Controls.Add(this.BTN_Reset);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 413);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 78);
            this.panel1.TabIndex = 5;
            // 
            // BTN_Save
            // 
            this.BTN_Save.BackColor = System.Drawing.Color.YellowGreen;
            this.BTN_Save.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BTN_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Save.Font = new System.Drawing.Font("Rajdhani", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BTN_Save.Location = new System.Drawing.Point(0, 4);
            this.BTN_Save.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Save.Name = "BTN_Save";
            this.BTN_Save.Size = new System.Drawing.Size(415, 37);
            this.BTN_Save.TabIndex = 0;
            this.BTN_Save.Text = "Módosítások mentése";
            this.BTN_Save.UseVisualStyleBackColor = false;
            this.BTN_Save.Click += new System.EventHandler(this.BTN_Save_Click);
            // 
            // BTN_Reset
            // 
            this.BTN_Reset.BackColor = System.Drawing.Color.Crimson;
            this.BTN_Reset.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BTN_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Reset.Font = new System.Drawing.Font("Rajdhani", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BTN_Reset.Location = new System.Drawing.Point(0, 41);
            this.BTN_Reset.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Reset.Name = "BTN_Reset";
            this.BTN_Reset.Size = new System.Drawing.Size(415, 37);
            this.BTN_Reset.TabIndex = 1;
            this.BTN_Reset.Text = "Módosítások törlése";
            this.BTN_Reset.UseVisualStyleBackColor = false;
            this.BTN_Reset.Click += new System.EventHandler(this.BTN_Reset_Click);
            // 
            // SettingsGrid
            // 
            this.SettingsGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingsGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SettingsGrid.Location = new System.Drawing.Point(0, 0);
            this.SettingsGrid.Margin = new System.Windows.Forms.Padding(4);
            this.SettingsGrid.Name = "SettingsGrid";
            this.SettingsGrid.Size = new System.Drawing.Size(415, 491);
            this.SettingsGrid.TabIndex = 4;
            // 
            // SettingsControl_Packaging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SettingsGrid);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SettingsControl_Packaging";
            this.Size = new System.Drawing.Size(415, 491);
            this.Load += new System.EventHandler(this.SettingsControl_Packaging_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BTN_Save;
        private System.Windows.Forms.Button BTN_Reset;
        private System.Windows.Forms.PropertyGrid SettingsGrid;
    }
}
