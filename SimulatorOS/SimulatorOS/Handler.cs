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
         *  y los procesos
         *  Se encarga de los procesos de asignacion de memoria, busqueda de espacio,
         *   monitorear el espacio disponible, Monitorear el consumo de recursos
         *   Terminar procesos, 
        */

        Memory Ram = new Memory(); // Memoria Ram
        Memory Virtual = new Memory(); // Memoria Virtual

        public Process temp1; // Procesos temporales para switch
        public Process temp2; // Procesos temporales para switch

        private int RamDisponible = 500; // Memoria Ram disponible
        public int ramDisponivle => RamDisponible; // geter

        private int VirutalDisponible = 500; // Memoria Virtual Disponilbe
        public int virtualDisponible => VirutalDisponible; // geter 

        private int ProcesosEjecutandose = 0; // Cantidad de procesos en Ram

        private int ConsumoCPU = 0; // Consumo de CPU
        public int consumoCPU => ConsumoCPU; // geter

        public int procesosEjecutandose => ProcesosEjecutandose; // geter

        public int AgregarAmemoria(Process proceso) // Busca espacio disponible y agrega el proceso
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

        public bool? EliminarProceso(String proceso) // Busca el proceso, lo elimina y retorna el donde se encontraba
        {
            if (Ram.existeProcesoPorNombre(proceso))
            {
                Process temp = Ram.pullPorNombre(proceso);
                Ram.delete(temp);
                actualizarMemorias();
                return true;
            }
            else if (Virtual.existeProcesoPorNombre(proceso))
            {
                Process temp = Virtual.pullPorNombre(proceso);
                Virtual.delete(temp);
                actualizarMemorias();
                return false;
            }
            return null;
        }

        public bool Switch(String proceso) // Realisa el intercambio de procesos
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
            return false;
        }

        public void EndProcess(String proceso) // Fin de ejecucion
        {
            Process temp = Ram.pullPorNombre(proceso);
            Ram.delete(temp);
            actualizarMemorias();
        }

        public ArrayList Swap() // Cambia los procesos de memoria Virtual a Ram, si Existe espacio disponible
        {
            ArrayList procesosMovidos = new ArrayList();
            for (int i = 0; i < Virtual.length(); i++)
            {
                Process a = Virtual.pullPorIndex(i);
                if (a.peso < Ram.total)
                {
                    Virtual.delete(a);
                    Ram.push(a);
                    procesosMovidos.Add(a);
                }
            }
            actualizarMemorias();
            return procesosMovidos;
        }

        public void ResetAll() // Resetea las memorias 
        {
            Ram.clearAll();
            Virtual.clearAll();
            actualizarMemorias();
        }


        private void actualizarMemorias() // actualiza valor de ramDisponible y virtualDisponible
        {
            RamDisponible = Ram.total;
            VirutalDisponible = Virtual.total;
            if (Virtual.length() != -1 && Ram.length() != -1)
            {
                ConsumoCPU = 0;

                ProcesosEjecutandose = Ram.length();
                for(int i = 0; i < Ram.length(); i++)
                {
                    ConsumoCPU += Ram.pullPorIndex(i).usoCpu;
                }
            } else
            {
                ConsumoCPU = 0;
                ProcesosEjecutandose = 0;
            }
        }

    }
}
