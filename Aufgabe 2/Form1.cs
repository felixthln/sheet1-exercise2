using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe_2
{
    public partial class Thermostat : Form
    {

        private string temperatur;

        public Thermostat()
        {
            InitializeComponent();
        }

        private void Thermostat_Load(object sender, EventArgs e)
        {

        }

        private void txtTemperaturBox_TextChanged(object sender, EventArgs e)
        {
            temperatur = txtTemperaturBox.Text;
        }

        private void rbnCelsiusFahrenheit_CheckedChanged(object sender, EventArgs e)
        {

            lblTempEinheitEingabe.Text = "°C";
            lblTempEinheitAusgabe.Text = "°F";
            lblTempAusgabe.Text = null;
        }

        private void rbnFahrenheitCelsius_CheckedChanged(object sender, EventArgs e)
        {
            lblTempEinheitEingabe.Text = "°F";
            lblTempEinheitAusgabe.Text = "°C";
        }

        private void rbnCelsiusKelvin_CheckedChanged(object sender, EventArgs e)
        {
            lblTempEinheitEingabe.Text = "°C";
            lblTempEinheitAusgabe.Text = " K";
        }

        private void rbnKelvinCelsius_CheckedChanged(object sender, EventArgs e)
        {
            lblTempEinheitEingabe.Text = " K";
            lblTempEinheitAusgabe.Text = "°C";
        }

        private void btnEingabeButton_Click(object sender, EventArgs e)
        {
            if (temperatur != null)
            {
                float temperaturFloat = System.Convert.ToSingle(temperatur);
                double temperaturAusgabeDouble;

                if (rbnCelsiusFahrenheit.Checked && temperaturFloat > -273.15)
                {
                    temperaturAusgabeDouble = Math.Round((temperaturFloat * 9 / 5 + 32), 2);
                    lblTempAusgabe.Text = System.Convert.ToString(temperaturAusgabeDouble);
                }
                else if (rbnFahrenheitCelsius.Checked && temperaturFloat > -459.67)
                {
                    temperaturAusgabeDouble = Math.Round(((temperaturFloat - 32) * 5 / 9), 2);
                    lblTempAusgabe.Text = System.Convert.ToString(temperaturAusgabeDouble);
                }
                else if (rbnCelsiusKelvin.Checked && temperaturFloat > -273.15)
                {
                    temperaturAusgabeDouble = Math.Round((temperaturFloat + 273.15), 2);
                    lblTempAusgabe.Text = System.Convert.ToString(temperaturAusgabeDouble);
                }
                else if (rbnKelvinCelsius.Checked && temperaturFloat > 0.0)
                {
                    temperaturAusgabeDouble = Math.Round((temperaturFloat - 273.15), 2);
                    lblTempAusgabe.Text = System.Convert.ToString(temperaturAusgabeDouble);
                }
                
            }
        }
    }
}
