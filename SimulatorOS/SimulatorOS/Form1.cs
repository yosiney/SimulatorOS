using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SimulatorOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void comboBoxApps_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxApps.SelectedIndex == 0)
            {
                textBox1.Text = "20";
                textBox2.Text = "10";
            }
            else if(comboBoxApps.SelectedIndex == 1)
            {
                textBox1.Text = "15";
                textBox2.Text = "8";
            }
            else if (comboBoxApps.SelectedIndex == 2)
            {
                textBox1.Text = "25";
                textBox2.Text = "12";
            }
            else if (comboBoxApps.SelectedIndex == 3)
            {
                textBox1.Text = "30";
                textBox2.Text = "15";
            }
            else if (comboBoxApps.SelectedIndex == 4)
            {
                textBox1.Text = "35";
                textBox2.Text = "18";
            }
            else if (comboBoxApps.SelectedIndex == 5)
            {
                textBox1.Text = "22";
                textBox2.Text = "11";
            }
            else if (comboBoxApps.SelectedIndex == 6)
            {
                textBox1.Text = "25";
                textBox2.Text = "12";
            }
            else if (comboBoxApps.SelectedIndex == 7)
            {
                textBox1.Text = "28";
                textBox2.Text = "14";
            }

            else if (comboBoxApps.SelectedIndex == 8)
            {
                textBox1.Text = "40";
                textBox2.Text = "20";
            }
            else if (comboBoxApps.SelectedIndex == 9)
            {
                textBox1.Text = "32";
                textBox2.Text = "16";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxApps.SelectedIndex = 0;

            comboBoxApps.DropDownStyle = ComboBoxStyle.DropDownList;

        }
    }
}
