using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        Process Chrome;
        Process Spotify;
        Process Word;
        Process Photoshop;
        Process VSCode;
        Process Outlook;
        Process Ilustrator;
        Process MySQL;
        Process Paint;
        Process Teams;

        int tiempoProcesoValue;
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBoxApps_SelectedIndexChanged(object sender, EventArgs e)
        {
            tiempoProcesoValue = gridProcesos.Rows.Count;
            if (comboBoxApps.SelectedIndex == 0)
            {
                Chrome = new Process("Google Chrome", 50, 2, 10, tiempoProcesoValue, "En espera");
            }
            else if (comboBoxApps.SelectedIndex == 1)
            {
                Spotify = new Process("Spotify", 100, 3, 8, tiempoProcesoValue, "En espera");
            }
            else if (comboBoxApps.SelectedIndex == 2)
            {
                Word = new Process("Word", 115, 4, 12, tiempoProcesoValue, "En espera");
            }
            else if (comboBoxApps.SelectedIndex == 3)
            {
                Photoshop = new Process("Photoshop", 120, 5, 15, tiempoProcesoValue, "En espera");
            }
            else if (comboBoxApps.SelectedIndex == 4)
            {
                VSCode = new Process("VSCode", 125, 6, 18, tiempoProcesoValue, "En espera");
            }
            else if (comboBoxApps.SelectedIndex == 5)
            {
                Outlook = new Process("Outlook", 130, 7, 11, tiempoProcesoValue, "En espera");
            }
            else if (comboBoxApps.SelectedIndex == 6)
            {
                Ilustrator = new Process("Ilustrator", 140, 8, 12, tiempoProcesoValue, "En espera");
            }
            else if (comboBoxApps.SelectedIndex == 7)
            {
                MySQL = new Process("MySQL", 150, 9, 14, tiempoProcesoValue, "En espera");
            }

            else if (comboBoxApps.SelectedIndex == 8)
            {
                Paint = new Process("Paint", 155, 10, 20, tiempoProcesoValue, "En espera");
            }
            else if (comboBoxApps.SelectedIndex == 9)
            {
                Teams = new Process("Teams", 160, 11, 16, tiempoProcesoValue, "En espera");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void agregar(Process proceso) // agrega a la tabla
        {
            int index = gridProcesos.Rows.Add();
            gridProcesos.Rows[index].Cells["NumProceso"].Value = proceso.nombre;
            gridProcesos.Rows[index].Cells["TiempoProcesos"].Value = proceso.tiempo;
            gridProcesos.Rows[index].Cells["EstadoProceso"].Value = proceso.estado;
            gridProcesos.Rows[index].Cells["Ciclos"].Value = proceso.ciclos;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int index = comboBoxApps.SelectedIndex;
            switch (index)
            {
                case 0:
                    agregar(Chrome);
                    break;
                case 1:
                    agregar(Spotify);
                    break;
                case 2:
                    agregar(Word);
                    break;
                case 3:
                    agregar(Photoshop);
                    break;
                case 4:
                    agregar(VSCode);
                    break;
                case 5:
                    agregar(Outlook);
                    break;
                case 6:
                    agregar(Ilustrator);
                    break;
                case 7:
                    agregar(MySQL);
                    break;
                case 8:
                    agregar(Paint);
                    break;
                case 9:
                    agregar(Teams);
                    break;
                default:
                    break;
            }
        }
    }

}
