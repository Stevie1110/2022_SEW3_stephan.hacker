using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hue01
{
    internal class Messwerte
    {
        private DateTime zeit;
        private double messwerte;
            
        public DateTime Zeit
        {
            get
            {
                return zeit;
            }
            set
            {
                this.zeit = value;
            }
        }

        public double Messwert
        {
            get
            {
                return messwerte;
            }
            set
            {
                this.messwerte = value;
            }
        }

        public Messwerte(DateTime zeit, double Messwert)
        {
            this.zeit = zeit;
            this.Messwert= Messwert;
        }
    }
}
