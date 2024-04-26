using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulatorOS
{
    internal class hardwareReserve
    {

        private static List<long> reserva1;
        private static List<long> reserva2;

        public static void activar()
        {
            reserva1 = new List<long>();
            reserva2 = new List<long>();

            for (int i = 0; i < 100000000; i++)
            {
                reserva1.Add(i);
            }

            for (int i = 0; i < 100000000; i++)
            {
                reserva2.Add(i);
            }
        }

        public static void desactivar() 
        {
            reserva1.Clear();
            reserva2.Clear();
            reserva1 = null;
            reserva2 = null;
            GC.Collect();
        }
    }
}
