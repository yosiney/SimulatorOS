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

        public void AgregarAmemoria(Process proceso)
        {
            comprobarMemorias();
            if (RamDisponible != 0 &&  proceso.peso < RamDisponible )
            {
                Ram.push( proceso );
            } else if (VirutalDisponible != 0 && proceso.peso < VirutalDisponible)
            {
                Virtual.push( proceso );
            }
        }

        private void comprobarMemorias() // actualiza valor de ramDisponible y virtualDisponible
        {
            RamDisponible = Ram.total;
            VirutalDisponible = Virtual.total;
        }

    }
}
