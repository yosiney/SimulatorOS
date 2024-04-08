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
                txtCiclos.Text = "10";
            }
            else if(comboBoxApps.SelectedIndex == 1)
            {
                txtCiclos.Text = "8";
            }
            else if (comboBoxApps.SelectedIndex == 2)
            {
                txtCiclos.Text = "12";
            }
            else if (comboBoxApps.SelectedIndex == 3)
            {
                txtCiclos.Text = "15";
            }
            else if (comboBoxApps.SelectedIndex == 4)
            {
                txtCiclos.Text = "18";
            }
            else if (comboBoxApps.SelectedIndex == 5)
            {
                txtCiclos.Text = "11";
            }
            else if (comboBoxApps.SelectedIndex == 6)
            {
                txtCiclos.Text = "12";
            }
            else if (comboBoxApps.SelectedIndex == 7)
            {
                txtCiclos.Text = "14";
            }

            else if (comboBoxApps.SelectedIndex == 8)
            {
                txtCiclos.Text = "20";
            }
            else if (comboBoxApps.SelectedIndex == 9)
            {
                txtCiclos.Text = "16";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxApps.SelectedIndex = 0;

            comboBoxApps.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int tiempoProcesoValue = gridProcesos.Rows.Count;

            if (comboBoxApps.SelectedIndex == 0)
            {
                int index = gridProcesos.Rows.Add();
                gridProcesos.Rows[index].Cells["NumProceso"].Value = "Google Chrome";
                gridProcesos.Rows[index].Cells["TiempoProcesos"].Value = tiempoProcesoValue.ToString();
                gridProcesos.Rows[index].Cells["EstadoProceso"].Value = "En Espera";
                gridProcesos.Rows[index].Cells["Ciclos"].Value = txtCiclos.Text;
            }
            else if (comboBoxApps.SelectedIndex == 1)
            {
                int index = gridProcesos.Rows.Add();
                gridProcesos.Rows[index].Cells["NumProceso"].Value = "Spotify";
                gridProcesos.Rows[index].Cells["TiempoProcesos"].Value = tiempoProcesoValue.ToString();
                gridProcesos.Rows[index].Cells["EstadoProceso"].Value = "En Espera";
                gridProcesos.Rows[index].Cells["Ciclos"].Value = txtCiclos.Text;
            }

            else if (comboBoxApps.SelectedIndex == 2)
            {
                int index = gridProcesos.Rows.Add();
                gridProcesos.Rows[index].Cells["NumProceso"].Value = "Microsoft Word";
                gridProcesos.Rows[index].Cells["TiempoProcesos"].Value = tiempoProcesoValue.ToString();
                gridProcesos.Rows[index].Cells["EstadoProceso"].Value = "En Espera";
                gridProcesos.Rows[index].Cells["Ciclos"].Value = txtCiclos.Text;
            }
            else if (comboBoxApps.SelectedIndex == 3)
            {
                int index = gridProcesos.Rows.Add();
                gridProcesos.Rows[index].Cells["NumProceso"].Value = "Adobe Photoshop";
                gridProcesos.Rows[index].Cells["TiempoProcesos"].Value = tiempoProcesoValue.ToString();
                gridProcesos.Rows[index].Cells["EstadoProceso"].Value = "En Espera";
                gridProcesos.Rows[index].Cells["Ciclos"].Value = txtCiclos.Text;
            }
            else if (comboBoxApps.SelectedIndex == 4)
            {
                int index = gridProcesos.Rows.Add();
                gridProcesos.Rows[index].Cells["NumProceso"].Value = "Visual Studio Code";
                gridProcesos.Rows[index].Cells["TiempoProcesos"].Value = tiempoProcesoValue.ToString();
                gridProcesos.Rows[index].Cells["EstadoProceso"].Value = "En Espera";
                gridProcesos.Rows[index].Cells["Ciclos"].Value = txtCiclos.Text;
            }
            else if (comboBoxApps.SelectedIndex == 5)
            {
                int index = gridProcesos.Rows.Add();
                gridProcesos.Rows[index].Cells["NumProceso"].Value = "Outlook";
                gridProcesos.Rows[index].Cells["TiempoProcesos"].Value = tiempoProcesoValue.ToString(); ;
                gridProcesos.Rows[index].Cells["EstadoProceso"].Value = "En Espera";
                gridProcesos.Rows[index].Cells["Ciclos"].Value = txtCiclos.Text;
            }
            else if (comboBoxApps.SelectedIndex == 6)
            {
                int index = gridProcesos.Rows.Add();
                gridProcesos.Rows[index].Cells["NumProceso"].Value = "Adobe Ilustrator";
                gridProcesos.Rows[index].Cells["TiempoProcesos"].Value = tiempoProcesoValue.ToString();
                gridProcesos.Rows[index].Cells["EstadoProceso"].Value = "En Espera";
                gridProcesos.Rows[index].Cells["Ciclos"].Value = txtCiclos.Text;
            }
            else if (comboBoxApps.SelectedIndex == 7)
            {
                int index = gridProcesos.Rows.Add();
                gridProcesos.Rows[index].Cells["NumProceso"].Value = "MySQL";
                gridProcesos.Rows[index].Cells["TiempoProcesos"].Value = tiempoProcesoValue.ToString();
                gridProcesos.Rows[index].Cells["EstadoProceso"].Value = "En Espera";
                gridProcesos.Rows[index].Cells["Ciclos"].Value = txtCiclos.Text;
            }

            else if (comboBoxApps.SelectedIndex == 8)
            {
                int index = gridProcesos.Rows.Add();
                gridProcesos.Rows[index].Cells["NumProceso"].Value = "Paint";
                gridProcesos.Rows[index].Cells["TiempoProcesos"].Value = tiempoProcesoValue.ToString();
                gridProcesos.Rows[index].Cells["EstadoProceso"].Value = "En Espera";
                gridProcesos.Rows[index].Cells["Ciclos"].Value = txtCiclos.Text;
            }
            else if (comboBoxApps.SelectedIndex == 9)
            {
                int index = gridProcesos.Rows.Add();
                gridProcesos.Rows[index].Cells["NumProceso"].Value = "Teams";
                gridProcesos.Rows[index].Cells["TiempoProcesos"].Value = tiempoProcesoValue.ToString(); ;
                gridProcesos.Rows[index].Cells["EstadoProceso"].Value = "En Espera";
                gridProcesos.Rows[index].Cells["Ciclos"].Value = txtCiclos.Text;
            }

        }
    }
    
}
