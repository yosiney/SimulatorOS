using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public void push(Process proceso) // Mete un proceso a la memoria
        {
            if (Total > 0)
            {
                memory.Add(proceso);
                Total -= proceso.peso;
            }
        }

        public Process pull(Process proceso) // saca un proceso a la memoria y lo retorna
        {
            int i = memory.FindIndex(a => a.Equals(proceso));
            Total += proceso.peso;
            return memory.ElementAt(i);
        }

        public void delete(Process proceso) 
        {
            memory.Remove(proceso);
        }

        public bool buscarProcesoPorNombre(String proceso)
        {
            for (int i = 0; i < proceso.Length; i++)
            {
                if (memory[i].nombre == proceso)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
