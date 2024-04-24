using System;
using System.Collections.Generic;
using System.Linq;
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


        private int RamDisponible = 0;
        public int ramDisponivle => RamDisponible; // geter

        private int VirutalDisponible = 0;
        public int virtualDisponible => VirutalDisponible; // geter 

        public int AgregarAmemoria(Process proceso)
        {
            actualizarMemorias();
            if (RamDisponible != 0 && proceso.peso <= RamDisponible)
            {
                Ram.push(proceso);
                return 1; // El proceso entro en la memoria RAM
            }
            else if (VirutalDisponible != 0 && proceso.peso <= VirutalDisponible)
            {
                Virtual.push(proceso);
                return 2; // El proceso entro en la memoria Virutal
            }
            return 0; // Memorias Llenas
        }

        private void buscarProceso(String proceso)
        {
           if (Ram.seEncontroElProceso(proceso))
            {

            }
        }

        private void actualizarMemorias() // actualiza valor de ramDisponible y virtualDisponible
        {
            RamDisponible = Ram.total;
            VirutalDisponible = Virtual.total;
        }

    }
}
