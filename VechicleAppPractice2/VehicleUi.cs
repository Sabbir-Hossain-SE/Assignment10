using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VechicleAppPractice2
{
    public partial class VehicleUi : Form
    {
        Vechicle vechicle;
        public VehicleUi()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            vechicle = new Vechicle(vehicleNameTextBox.Text, regNoTextBox.Text);
            vehicleNameTextBox.Clear();
            regNoTextBox.Clear();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {

            vechicle.SetSpeed(Convert.ToDouble(speedTextBox.Text));
            speedTextBox.Clear();

        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            minSpeedTextBox.Text = Convert.ToString( vechicle.Min());
            maxSpeedTextBox.Text = Convert.ToString(vechicle.Max());
            averageSpeedTextBox.Text = Convert.ToString(vechicle.Avg());

        }
    }
}
