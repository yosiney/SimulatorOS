using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulatorOS
{
    internal class hardwareReserve
    {

        private static List<Double> reserva1;
        private static List<Double> reserva2;
        private static List<Double> reserva3;

        public static void activar()
        {
            reserva1 = new List<Double>();
            reserva2 = new List<Double>();
            reserva3 = new List<Double>();

            for (int i = 0; i < 100000000; i++)
            {
                reserva1.Add(i);
            }

            for (int i = 0; i < 10000000; i++)
            {
                Double a = (i * 2) * 2;
                reserva2.Add(a);
            }

            for (int i = 0; i < 10000000; i++)
            {
                Double a = (i * 2) * 2;
                reserva3.Add(a);
            }
        }

        public static void desactivar() 
        {
            reserva1.Clear();
            reserva2.Clear();
            reserva3.Clear();
            reserva1 = null;
            reserva2 = null;
            reserva3 = null;
            GC.Collect();
        }
    }
}
