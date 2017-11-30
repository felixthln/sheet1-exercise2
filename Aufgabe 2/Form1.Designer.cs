namespace Aufgabe_2
{
    partial class Thermostat
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtTemperaturBox = new System.Windows.Forms.TextBox();
            this.lblTempEinheitEingabe = new System.Windows.Forms.Label();
            this.lblTempEinheitAusgabe = new System.Windows.Forms.Label();
            this.lblTempAusgabe = new System.Windows.Forms.Label();
            this.gbUmrechnung = new System.Windows.Forms.GroupBox();
            this.btnEingabeButton = new System.Windows.Forms.Button();
            this.rbnCelsiusFahrenheit = new System.Windows.Forms.RadioButton();
            this.rbnFahrenheitCelsius = new System.Windows.Forms.RadioButton();
            this.rbnCelsiusKelvin = new System.Windows.Forms.RadioButton();
            this.rbnKelvinCelsius = new System.Windows.Forms.RadioButton();
            this.gbUmrechnung.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temperatur:";
            // 
            // txtTemperaturBox
            // 
            this.txtTemperaturBox.Location = new System.Drawing.Point(177, 44);
            this.txtTemperaturBox.Name = "txtTemperaturBox";
            this.txtTemperaturBox.Size = new System.Drawing.Size(100, 31);
            this.txtTemperaturBox.TabIndex = 1;
            this.txtTemperaturBox.TextChanged += new System.EventHandler(this.txtTemperaturBox_TextChanged);
            // 
            // lblTempEinheitEingabe
            // 
            this.lblTempEinheitEingabe.AutoSize = true;
            this.lblTempEinheitEingabe.Location = new System.Drawing.Point(283, 47);
            this.lblTempEinheitEingabe.Name = "lblTempEinheitEingabe";
            this.lblTempEinheitEingabe.Size = new System.Drawing.Size(35, 25);
            this.lblTempEinheitEingabe.TabIndex = 2;
            this.lblTempEinheitEingabe.Text = "°C";
            // 
            // lblTempEinheitAusgabe
            // 
            this.lblTempEinheitAusgabe.AutoSize = true;
            this.lblTempEinheitAusgabe.Location = new System.Drawing.Point(283, 82);
            this.lblTempEinheitAusgabe.Name = "lblTempEinheitAusgabe";
            this.lblTempEinheitAusgabe.Size = new System.Drawing.Size(33, 25);
            this.lblTempEinheitAusgabe.TabIndex = 3;
            this.lblTempEinheitAusgabe.Text = "°F";
            // 
            // lblTempAusgabe
            // 
            this.lblTempAusgabe.AutoSize = true;
            this.lblTempAusgabe.Location = new System.Drawing.Point(172, 82);
            this.lblTempAusgabe.Name = "lblTempAusgabe";
            this.lblTempAusgabe.Size = new System.Drawing.Size(0, 25);
            this.lblTempAusgabe.TabIndex = 4;
            // 
            // gbUmrechnung
            // 
            this.gbUmrechnung.Controls.Add(this.rbnKelvinCelsius);
            this.gbUmrechnung.Controls.Add(this.rbnCelsiusKelvin);
            this.gbUmrechnung.Controls.Add(this.rbnFahrenheitCelsius);
            this.gbUmrechnung.Controls.Add(this.rbnCelsiusFahrenheit);
            this.gbUmrechnung.Location = new System.Drawing.Point(17, 132);
            this.gbUmrechnung.Name = "gbUmrechnung";
            this.gbUmrechnung.Size = new System.Drawing.Size(411, 282);
            this.gbUmrechnung.TabIndex = 5;
            this.gbUmrechnung.TabStop = false;
            this.gbUmrechnung.Text = "Umrechnung";
            // 
            // btnEingabeButton
            // 
            this.btnEingabeButton.Location = new System.Drawing.Point(17, 420);
            this.btnEingabeButton.Name = "btnEingabeButton";
            this.btnEingabeButton.Size = new System.Drawing.Size(411, 55);
            this.btnEingabeButton.TabIndex = 6;
            this.btnEingabeButton.Text = "Umrechnen";
            this.btnEingabeButton.UseVisualStyleBackColor = true;
            this.btnEingabeButton.Click += new System.EventHandler(this.btnEingabeButton_Click);
            // 
            // rbnCelsiusFahrenheit
            // 
            this.rbnCelsiusFahrenheit.AutoSize = true;
            this.rbnCelsiusFahrenheit.Checked = true;
            this.rbnCelsiusFahrenheit.Location = new System.Drawing.Point(7, 48);
            this.rbnCelsiusFahrenheit.Name = "rbnCelsiusFahrenheit";
            this.rbnCelsiusFahrenheit.Size = new System.Drawing.Size(292, 29);
            this.rbnCelsiusFahrenheit.TabIndex = 0;
            this.rbnCelsiusFahrenheit.TabStop = true;
            this.rbnCelsiusFahrenheit.Text = "°Celsius nach °Fahrenheit";
            this.rbnCelsiusFahrenheit.UseVisualStyleBackColor = true;
            this.rbnCelsiusFahrenheit.CheckedChanged += new System.EventHandler(this.rbnCelsiusFahrenheit_CheckedChanged);
            // 
            // rbnFahrenheitCelsius
            // 
            this.rbnFahrenheitCelsius.AutoSize = true;
            this.rbnFahrenheitCelsius.Location = new System.Drawing.Point(7, 84);
            this.rbnFahrenheitCelsius.Name = "rbnFahrenheitCelsius";
            this.rbnFahrenheitCelsius.Size = new System.Drawing.Size(292, 29);
            this.rbnFahrenheitCelsius.TabIndex = 1;
            this.rbnFahrenheitCelsius.Text = "°Fahrenheit nach °Celsius";
            this.rbnFahrenheitCelsius.UseVisualStyleBackColor = true;
            this.rbnFahrenheitCelsius.CheckedChanged += new System.EventHandler(this.rbnFahrenheitCelsius_CheckedChanged);
            // 
            // rbnCelsiusKelvin
            // 
            this.rbnCelsiusKelvin.AutoSize = true;
            this.rbnCelsiusKelvin.Location = new System.Drawing.Point(7, 120);
            this.rbnCelsiusKelvin.Name = "rbnCelsiusKelvin";
            this.rbnCelsiusKelvin.Size = new System.Drawing.Size(240, 29);
            this.rbnCelsiusKelvin.TabIndex = 2;
            this.rbnCelsiusKelvin.Text = "°Celsius nach Kelvin";
            this.rbnCelsiusKelvin.UseVisualStyleBackColor = true;
            this.rbnCelsiusKelvin.CheckedChanged += new System.EventHandler(this.rbnCelsiusKelvin_CheckedChanged);
            // 
            // rbnKelvinCelsius
            // 
            this.rbnKelvinCelsius.AutoSize = true;
            this.rbnKelvinCelsius.Location = new System.Drawing.Point(7, 156);
            this.rbnKelvinCelsius.Name = "rbnKelvinCelsius";
            this.rbnKelvinCelsius.Size = new System.Drawing.Size(240, 29);
            this.rbnKelvinCelsius.TabIndex = 3;
            this.rbnKelvinCelsius.Text = "Kelvin nach °Celsius";
            this.rbnKelvinCelsius.UseVisualStyleBackColor = true;
            this.rbnKelvinCelsius.CheckedChanged += new System.EventHandler(this.rbnKelvinCelsius_CheckedChanged);
            // 
            // Thermostat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 505);
            this.Controls.Add(this.btnEingabeButton);
            this.Controls.Add(this.gbUmrechnung);
            this.Controls.Add(this.lblTempAusgabe);
            this.Controls.Add(this.lblTempEinheitAusgabe);
            this.Controls.Add(this.lblTempEinheitEingabe);
            this.Controls.Add(this.txtTemperaturBox);
            this.Controls.Add(this.label1);
            this.Name = "Thermostat";
            this.Text = "Thermostat";
            this.Load += new System.EventHandler(this.Thermostat_Load);
            this.gbUmrechnung.ResumeLayout(false);
            this.gbUmrechnung.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTemperaturBox;
        private System.Windows.Forms.Label lblTempEinheitEingabe;
        private System.Windows.Forms.Label lblTempEinheitAusgabe;
        private System.Windows.Forms.Label lblTempAusgabe;
        private System.Windows.Forms.GroupBox gbUmrechnung;
        private System.Windows.Forms.Button btnEingabeButton;
        private System.Windows.Forms.RadioButton rbnCelsiusFahrenheit;
        private System.Windows.Forms.RadioButton rbnFahrenheitCelsius;
        private System.Windows.Forms.RadioButton rbnCelsiusKelvin;
        private System.Windows.Forms.RadioButton rbnKelvinCelsius;
    }
}

