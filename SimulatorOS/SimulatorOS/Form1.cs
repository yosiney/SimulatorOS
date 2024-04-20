using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
        private bool banderaGuardarSeg = false;


        private Memory Ram = new Memory(); // Memoria Ram
        private Memory Virtual= new Memory(); // Memoria Virtual

        //diccionario que almacena los segundos de los procesos
        Dictionary<int, int> segundosPorProceso = new Dictionary<int, int>();
        Dictionary<int, int> tiempoRetorno = new Dictionary<int, int>();
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


            // Configurar el temporizador de 1s
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick1s;
        }

        private void Timer_Tick1s(object sender, EventArgs e)
        {
            // Incrementar el contador de segundos
            secondsPassed++;

            int restanteVar = Convert.ToInt32(gridProcesos.Rows[indexFila].Cells["RestanteCiclo"].Value);
            DataGridViewRow filaSeleccionada = gridProcesos.CurrentRow;

           // int tiempo = int.Parse(filaSeleccionada.Cells["RestanteCiclo"].Value.ToString());

            //si el indice tiene ciclos restantes entrara al if
            if (restanteVar != 0)
            {
                gridProcesos.Rows[indexFila].Cells["EstadoProceso"].Value = "Ejecutando";

                // Registrar el tiempo en el momento en que el proceso comienza a ejecutarse
                if (banderaGuardarSeg == false)
                {
                    int indiceActual = indexFila;
                    //si el indice no tiene registro se ingresa al diccionario
                    if (!segundosPorProceso.ContainsKey(indiceActual))
                    {
                        segundosPorProceso.Add(indiceActual, secondsPassed);
                        banderaGuardarSeg = true;
                    }
                    else
                    //si ya tiene registro solo se le suma los segundos
                    {
                        banderaGuardarSeg = true;
                        segundosPorProceso[indiceActual] += secondsPassed;
                    }
                }

            }
            else
            //si el indice no tiene ciclos pendientes se meuestra el estado terminado
            {
                gridProcesos.Rows[indexFila].Cells["EstadoProceso"].Value = "Terminado";
            }

            // Realizar la acción cada 3 segundos
            if (secondsPassed % 3 == 0)
            {
                // ejecutar la función del procesamiento de procesos
                Timer_Tick3s();
                //restablece la bandera para que sepa que se cambiara de indice
                banderaGuardarSeg = false;
            }
        }




        private void Timer_Tick3s()
        {
            bool hayMasFilasParaProcesar = false;

            // Avanzar al siguiente índice de fila hasta encontrar una fila con RestanteCiclo diferente de cero
            while (true)
            {
                int restanteVar = Convert.ToInt32(gridProcesos.Rows[indexFila].Cells["RestanteCiclo"].Value);

                if (restanteVar != 0)
                {
                    // Si RestanteCiclo no es cero, hay más filas para procesar
                    hayMasFilasParaProcesar = true;
                    ProcesarFila();
                    break;
                }
                else
                {
                    // Si RestanteCiclo es cero, pasar a la siguiente fila
                    indexFila++;

                    // Si hemos llegado al final de la cuadrícula, volver al inicio
                    int filasTotal = (gridProcesos.Rows.Count);
                    if (indexFila == filasTotal)
                    {
                        indexFila = 0;
                    }

                }
            }

        }

        private int ObtenerSiguienteIndiceFila(int indiceActual)
        {
            int totalFilas = gridProcesos.Rows.Count;

            // Iteramos a través de las filas hasta encontrar una con RestanteCiclo > 0
            for (int i = 0; i < totalFilas; i++)
            {
                int siguienteIndice = (indiceActual + i + 1) % totalFilas;
                int restanteVar = Convert.ToInt32(gridProcesos.Rows[siguienteIndice].Cells["RestanteCiclo"].Value);
                if (restanteVar > 0)
                {
                    // Se encontró una fila con RestanteCiclo > 0, retornamos su índice
                    return siguienteIndice;
                }
            }

            // Si llegamos aquí, significa que todas las filas tienen RestanteCiclo == 0
            // En ese caso, devolvemos el índice actual para indicar que solo queda una fila
            return indiceActual;
        }





        private void ProcesarFila()
        {
            // Verificar si hay más filas para procesar
            int totalFilas = (gridProcesos.Rows.Count);
            
            // Obtener el valor actual de la columna "ciclo"
            int restante = Convert.ToInt32(gridProcesos.Rows[indexFila].Cells["RestanteCiclo"].Value);

            // Restar 3 segundos al ciclo actual
            restante -= 3;

            // Asegurarse de que el ciclo no sea negativo
            if (restante <= 0)
            {
                restante = 0;
                gridProcesos.Rows[indexFila].Cells["EstadoProceso"].Value = "Terminado";

                //almaceno el tiempo de retorno (su ultima ejecucion)
                //si el indice no tiene registro se ingresa al diccionario
                if (!tiempoRetorno.ContainsKey(indexFila))
                {
                    tiempoRetorno.Add(indexFila, secondsPassed);
                }

            }
            else
            {
                gridProcesos.Rows[indexFila].Cells["EstadoProceso"].Value = "Espera";
            }
                    

            // Actualizar el valor de la columna "ciclo"
            gridProcesos.Rows[indexFila].Cells["RestanteCiclo"].Value = restante;

            //para verificar si faltan procesos
            VerificarRestante0();

            // Avanzar al siguiente índice de fila
            int siguienteIndice;

            // Obtenemos el siguiente índice de fila que cumple con los criterios
            siguienteIndice = ObtenerSiguienteIndiceFila(indexFila);

            if (siguienteIndice != -1)
            {
                // Se encontró un índice válido, lo asignamos a indexFila
                indexFila = siguienteIndice;
            }
            else
            {
                // No se encontró ningún índice válido, reiniciamos a 0
                indexFila = 0;
                VerificarRestante0();
            }
            


        }

        private void VerificarRestante0() 
        {
            // Verificar si todas las filas tienen el ciclo en 0
            bool allZero = true;
            foreach (DataGridViewRow row in gridProcesos.Rows)
            {
                int restante = Convert.ToInt32(row.Cells["RestanteCiclo"].Value);
                if (restante > 0)
                {
                    allZero = false;
                    break;
                }
            }

            // Detener el temporizador si todas las filas tienen el ciclo en 0
            if (allZero)
            {
                timer.Stop();
                MessageBox.Show("Timer terminado");
                indexFila = 0;

                int largoTabla = gridProcesos.Rows.Count;

                int sumaTotales = 0, sumaRetornos = 0;

                for (int i = 0; i < largoTabla; i++)
                {
                    //muestro el tiempo de espera
                    int sumaSegundos = ((segundosPorProceso[i]) - 3);
                    sumaTotales += sumaSegundos;
                    gridProcesos.Rows[i].Cells["TiempoFinal"].Value = sumaSegundos;

                    //muestro el tiempo de retorno
                    int retornoTime = tiempoRetorno[i];
                    sumaRetornos += retornoTime;
                    gridProcesos.Rows[i].Cells["TiempoRetorno"].Value = retornoTime;
                }

                //calculo los promedios
                float promedioEspera = (sumaTotales / largoTabla);
                float promedioRetorno = (sumaRetornos / largoTabla);
                //muestro en pantalla
                txtPromedioEspera.Text = promedioEspera.ToString();
                txtPromedioRetorno.Text = promedioRetorno.ToString();


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

        private void agregar(Process proceso) // agrega los procesos
        {
            if (Ram.hayEspacio(proceso)) // Comprueba que haya espacio disponible en la memoria Ram
            {
                Ram.push(proceso); // Agrega el proceso a la memoria Ram
                agregarDataGrid(proceso); // Agrega el proceso al dataGrid

            } else if (Virtual.hayEspacio(proceso)) // Comprueba que haya espacio disponible en la memoria Virtual
            {
                Virtual.push(proceso); // Agrega el proceso a la memoria Virtual
                agregarDataGrid(proceso); // Agrega el proceso al dataGrid
            }

        }

        private void agregarDataGrid(Process proceso) // Carga el dataGrid con los datos del proceso
        {
            int index = gridProcesos.Rows.Add();

            gridProcesos.Rows[index].Cells["NumProceso"].Value = proceso.nombre;
            gridProcesos.Rows[index].Cells["TiempoProcesos"].Value = proceso.tiempo;
            gridProcesos.Rows[index].Cells["EstadoProceso"].Value = proceso.estado;
            gridProcesos.Rows[index].Cells["Ciclos"].Value = proceso.ciclos;
            gridProcesos.Rows[index].Cells["RestanteCiclo"].Value = proceso.ciclos;
        }

        private void buttonAdd_Click(object sender, EventArgs e) // boton agregar
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

            segundosPorProceso.Clear();
            tiempoRetorno.Clear();
            indexFila = 0;
            secondsPassed = 0;

            txtPromedioEspera.Text = "";
            txtPromedioRetorno.Text = "";
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
