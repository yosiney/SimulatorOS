using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulatorOS
{
    internal class Memory
    {
        private int Total = 500;
        //private int Libre = 0;

        /*public int libre
        {
            get { return Libre; }
        }*/

        public int total
        {
            get { return Total; }
        }

        private List<Process> memory = new List<Process>();


        private void actualizarEspacio(Process proceso) // reduce espacio
        {
            Total -= proceso.peso;
        }
        
        public bool hayEspacio(Process process)
        {
            if(process.peso < Total)
            {
                return true;
            }
            return false;
        }

        public int push(Process proceso) // Mete un proceso a la memoria
        {
            if (Total > 0)
            {
                memory.Add(proceso);
                return 1; // El proceso entro en la memoria
            }
            return 0; // El proceso no pudo entrar en la memoria 
        }

        public Process pull(Process proceso) // saca un proceso a la memoria
        {
            int i = memory.FindIndex(a => a.Equals(proceso));
            return memory.ElementAt(i);
        }

    }
}
