using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace SimulatorOS
{
    internal class Process
    {
        // variables
        private string Nombre;
        private int Peso;
        private int UsoCPU;

        private int Ciclos;
        private int Tiempo;
        private int Restante;
        private string Estado;

        private int TiempoEspera;
        private ArrayList TiempoAbreProceso; // cuando el proceso se abre
        private int TiempoRetorno;

        // Constructor
        public Process(string nombre, int peso, int usoCpu, int ciclos, int tiempo, string estado)
        {
            Nombre = nombre;
            Peso = peso;
            UsoCPU = usoCpu;
            Ciclos = ciclos;
            Tiempo = tiempo;
            Estado = estado;
            TiempoEspera = 0;
            TiempoAbreProceso = new ArrayList();
            TiempoRetorno = 0;
        }

        // getters y setters
        public string nombre
        {
            get { return Nombre; }
        }
        public int peso
        {
            get { return Peso; }
        }
        public int usoCpu
        {
            get { return UsoCPU; }
        }
        public int ciclos
        {
            get { return Ciclos; }
        }
        public int tiempo
        {
            get { return Tiempo; }
        }
        public int restante
        {
            get { return Restante; }
        }
        public string estado 
        { 
            get { return Estado; }
            set { Estado = value; } 
        }
        public int tiempoEspera 
        { 
            get { return TiempoEspera; }
        }
        public int tiempoRetorno 
        { 
            get { return TiempoRetorno; } 
        }

        public void calcRestante() // Actualiza el restante
        {
            if (Restante != 0)
            {
                Restante = Ciclos - 3;
            }
        }

        public void agregarTiempoEjecucion(int posicion) // guarda la posicion en la que se ejcuto el proceso
        {
            TiempoAbreProceso.Add(posicion);
        }

        public void calcTiemoEspera() // calcula el tiempo de espera , se usa al final 
        {
            int total = 0;
            foreach (int ejecucion in TiempoAbreProceso)
            {
                total += ejecucion;
            }

            TiempoEspera = total - 3;
        }

        public void calcTiempoRetorno(int posicion)
        {
            TiempoRetorno = posicion;
        }

    }
}
