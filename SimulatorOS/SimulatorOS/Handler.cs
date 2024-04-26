using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SimulatorOS
{
    internal class Handler
    {
        /* El handler se encarga de administrar las memorias
         *  y los procesos */

        Memory Ram = new Memory();
        Memory Virtual = new Memory();

        public Process temp1;
        public Process temp2;

        private int RamDisponible = 500;
        public int ramDisponivle => RamDisponible; // geter

        private int VirutalDisponible = 500;
        public int virtualDisponible => VirutalDisponible; // geter 

        private int ProcesosEnRam = 0; // Cantidad de procesos en Ram

        private int ConsumoCPU = 0;
        public int consumoCPU => ConsumoCPU;

        public int procesosEnRam => ProcesosEnRam; // geter

        public int AgregarAmemoria(Process proceso)
        {
            if (RamDisponible != 0 && proceso.peso <= RamDisponible)
            {
                Ram.push(proceso);
                actualizarMemorias();
                return 1; // El proceso entro en la memoria RAM
            }
            else if (VirutalDisponible != 0 && proceso.peso <= VirutalDisponible)
            {
                Virtual.push(proceso);
                actualizarMemorias();
                return 2; // El proceso entro en la memoria Virutal
            }
            return 0; // Memorias Llenas
        }

        public bool? EliminarProceso(String proceso)
        {
            if(Ram.existeProcesoPorNombre(proceso))
            {
                Process temp = Ram.pullPorNombre(proceso);
                Ram.delete(temp);
                actualizarMemorias();
                return true;
            } else if (Virtual.existeProcesoPorNombre(proceso))
            {
                Process temp = Virtual.pullPorNombre(proceso);
                Virtual.delete(temp);
                actualizarMemorias();
                return false;
            }
            return null;
        }

        public bool Switch(String proceso)
        {
            if (Virtual.existeProcesoPorNombre(proceso))
            {
                // Pop proceso de la memoria Virtual
                temp1 = Virtual.pullPorNombre(proceso);
                Virtual.delete(temp1);

                // Pop ultimo proceso de la memoria virtual
                temp2 = Ram.last();
                Ram.delete(temp2);

                // switch de procesos
                Ram.push(temp1);
                Virtual.push(temp2);
                actualizarMemorias();
                return true;
            }
            else
            {
                return false;
            }
        }

        public ArrayList EndProcess(String proceso)
        {
            Process temp = Ram.pullPorNombre(proceso);
            Ram.delete(temp);

            for(int i = 0; i < Virtual.length(); i++)
            {
                Process a = Virtual.pullPorIndex(i);
                ArrayList procesosMovidos = new ArrayList();
                if (a.peso <= Ram.total)
                {
                    Virtual.delete(a);
                    Ram.push(a);
                    procesosMovidos.Add(a);
                }
                actualizarMemorias();
                return procesosMovidos;
            }
            return null;
        }



        private void actualizarMemorias() // actualiza valor de ramDisponible y virtualDisponible
        {
            RamDisponible = Ram.total;
            VirutalDisponible = Virtual.total;
            ProcesosEnRam = Ram.length();

        }

    }
}
