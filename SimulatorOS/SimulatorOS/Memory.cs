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
        private int Libre = 0;

        public int libre
        {
            get { return Libre; }
        }

        private List<Memory> memory = new List<Memory>();
        
        protected void agregar(string proceso,int peso)
        {

        }
    }
}
