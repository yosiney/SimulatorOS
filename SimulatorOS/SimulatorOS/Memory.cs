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

        public int length()
        {
            int i = memory.Count;
            return i;
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

        public Process last() // retorna el ultimo proceso de la memoria
        {
            Process last = memory.Last();
            return last;
        }

        public void delete(Process proceso) // Elimina proceso de la memoria
        {
            Total += proceso.peso;
            memory.Remove(proceso);
        }

        public bool existeProcesoPorNombre(String proceso) // Comprueba si el proceso esta en la memoria
        {
            try
            {
                for (int i = 0; i < proceso.Length; i++)
                {
                    if (memory[i].nombre == proceso)
                    {
                        return true;
                    }
                }
                return false;
            } catch(Exception ex)
            {
                return false;
            }
        }

        public Process buscarProcesoPorNombre(String proceso) // Busca el proceso y lo retorna
        {
            for (int i = 0; i < proceso.Length; i++)
            {
                if (memory[i].nombre == proceso)
                {
                    return memory[i];
                }
            }
            return null;
        }

        

    }
}
