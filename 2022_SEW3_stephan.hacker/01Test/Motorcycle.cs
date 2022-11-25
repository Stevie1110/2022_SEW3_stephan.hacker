using System;
using System.Collections.Generic;
using System.Text;

namespace _01Test
{
    class Motorcycle
    {
        private string type;
        private string driver;
        private string codriver;

        public Motorcycle(string type)
        {
            this.type = type;
        }

        public string Type
        {
            get
            {
                return this.type;
            }
        }

        public string Driver
        {
            get
            {
                return this.driver;
            }
            set
            {
                this.driver = value;
            }
        }

        public string CoDriver
        {
            get
            {
                return this.codriver;
            }
            set
            {
                this.codriver = value;
            }

        }

        public override string ToString()
        {
            if (this.type != null)
            {
                return "Type: " + this.type + "; Fahrer: " + this.driver + "Beifahrer: " + this.codriver;
            }
            else
            {
                return "Etwas ist schiefgelaufen";
            }
        }
    }
}
