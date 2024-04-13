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

        private Timer timer;
        private int indexFila = 0;

        private int secondsPassed = 0;
        public Form1()
        {
            InitializeComponent();
            comboBoxApps.DropDownStyle = ComboBoxStyle.DropDownList;
            gridProcesos.AllowUserToAddRows = false;

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new System.Drawing.Point(
                (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2
                );



            // Configurar el temporizador de 3s
            //timer = new Timer();
            //timer.Interval = 3000; 
            //timer.Tick += Timer_Tick3s;


            // Configurar el temporizador de 1s
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick1s;
        }

        private void Timer_Tick1s(object sender, EventArgs e)
        {
            // Incrementar el contador de segundos
            secondsPassed++;

            // Realizar la acción cada 3 segundos
            if (secondsPassed % 3 == 0)
            {
                Timer_Tick3s();
            }

        }

        private void Timer_Tick3s()
        {
            int restanteVar = Convert.ToInt32(gridProcesos.Rows[indexFila].Cells["RestanteCiclo"].Value);

            if (restanteVar == 0)
            {
                indexFila++;

                Verificar_si_hay_más_filas_para_procesar();
            }
            else
            {
                Verificar_si_hay_más_filas_para_procesar();
            }
        }

        private void Verificar_si_hay_más_filas_para_procesar()
        {
            // Verificar si hay más filas para procesar
            int totalFilas = (gridProcesos.Rows.Count);
            if (indexFila < totalFilas)
            {
                // Obtener el valor actual de la columna "ciclo"
                int restante = Convert.ToInt32(gridProcesos.Rows[indexFila].Cells["RestanteCiclo"].Value);

                // Restar 3 segundos al ciclo actual
                restante -= 3;

                // Asegurarse de que el ciclo no sea negativo
                if (restante < 0)
                    restante = 0;

                // Actualizar el valor de la columna "ciclo"
                gridProcesos.Rows[indexFila].Cells["RestanteCiclo"].Value = restante;

                // Avanzar al siguiente índice de fila
                int varIndex = indexFila + 1;

                if (varIndex < totalFilas)
                {
                    indexFila++;
                }
                else
                {
                    Verificar_si_todas_las_filas_tienen_el_ciclo_en_0();

                    indexFila = 0;
                }
            }
            else
            {
                Verificar_si_todas_las_filas_tienen_el_ciclo_en_0();
            }
        }

        private void Verificar_si_todas_las_filas_tienen_el_ciclo_en_0() 
        {
            // Verificar si todas las filas tienen el ciclo en 0
            bool allZero = true;
            foreach (DataGridViewRow row in gridProcesos.Rows)
            {
                int restante = Convert.ToInt32(row.Cells["RestanteCiclo"].Value);
                if (restante > 0)
                {
                    allZero = false;
                    indexFila = 0;
                    break;
                }
            }

            // Detener el temporizador si todas las filas tienen el ciclo en 0
            if (allZero)
            {
                timer.Stop();
                MessageBox.Show("Timer terminado");
            }
            else
            {
                // Reiniciar el índice de fila para recorrer nuevamente
                indexFila = 0;
            }
        }

        private void comboBoxApps_SelectedIndexChanged(object sender, EventArgs e)
        {
            tiempoProcesoValue = (gridProcesos.Rows.Count);
            if (comboBoxApps.SelectedIndex == 0)
            {
                Chrome = new Process("Google Chrome", 50, 2, 10, tiempoProcesoValue, "Cargado");
                txtCiclos.Text = Chrome.ciclos.ToString();
            }
            else if (comboBoxApps.SelectedIndex == 1)
            {
                Spotify = new Process("Spotify", 100, 3, 8, tiempoProcesoValue, "Cargado");
                txtCiclos.Text = Spotify.ciclos.ToString();
            }
            else if (comboBoxApps.SelectedIndex == 2)
            {
                Word = new Process("Word", 115, 4, 12, tiempoProcesoValue, "Cargado");
                txtCiclos.Text = Word.ciclos.ToString();
            }
            else if (comboBoxApps.SelectedIndex == 3)
            {
                Photoshop = new Process("Photoshop", 120, 5, 15, tiempoProcesoValue, "Cargado");
                txtCiclos.Text = Photoshop.ciclos.ToString();

            }
            else if (comboBoxApps.SelectedIndex == 4)
            {
                VSCode = new Process("VSCode", 125, 6, 18, tiempoProcesoValue,  "Cargado");
                txtCiclos.Text = VSCode.ciclos.ToString();
            }
            else if (comboBoxApps.SelectedIndex == 5)
            {
                Outlook = new Process("Outlook", 130, 7, 11, tiempoProcesoValue, "Cargado");
                txtCiclos.Text = Outlook.ciclos.ToString();
            }
            else if (comboBoxApps.SelectedIndex == 6)
            {
                Ilustrator = new Process("Ilustrator", 140, 8, 12, tiempoProcesoValue,  "Cargado");
                txtCiclos.Text = Ilustrator.ciclos.ToString();
            }
            else if (comboBoxApps.SelectedIndex == 7)
            {
                MySQL = new Process("MySQL", 150, 9, 14, tiempoProcesoValue, "Cargado");
                txtCiclos.Text = MySQL.ciclos.ToString();
            }

            else if (comboBoxApps.SelectedIndex == 8)
            {
                Paint = new Process("Paint", 155, 10, 20, tiempoProcesoValue, "Cargado");
                txtCiclos.Text = Paint.ciclos.ToString();
            }
            else if (comboBoxApps.SelectedIndex == 9)
            {
                Teams = new Process("Teams", 160, 11, 16, tiempoProcesoValue, "Cargado");
                txtCiclos.Text = Teams.ciclos.ToString();
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
            gridProcesos.Rows[index].Cells["RestanteCiclo"].Value = proceso.ciclos;
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

        private void buttonIniciarSimulacion_Click(object sender, EventArgs e)
        {
            if (gridProcesos.Rows.Count > 0)
            {
                MessageBox.Show("Iniciando Procesos!!!.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                timer.Start();
            }
            else
            {
                MessageBox.Show("No hay ningún proceso para simular. Agregue procesos antes de iniciar la simulación.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verifica si hay una fila seleccionada
            if (gridProcesos.SelectedRows.Count > 0)
            {
                // Elimina la fila seleccionada
                gridProcesos.Rows.RemoveAt(gridProcesos.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para eliminar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

}
