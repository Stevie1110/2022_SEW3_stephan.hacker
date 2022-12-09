using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1Test_LastNameChanged
{
    internal class Person
    {
        public event EventHandler LastNameChanged;

        public Person(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }

        private string lastName;
        public string FirstName { get; set; }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
                if (LastNameChanged != null)
                {
                    this.LastNameChanged(this, EventArgs.Empty);
                }
            }
        }
    }
}
