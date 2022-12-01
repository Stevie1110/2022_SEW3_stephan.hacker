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

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void LastNameAway(Person p)
        {
            p.LastName -= LastNameChanged;
            p.LastName -= LastNameChanged;
            p.LastName -= LastNameChanged;
        }

        private void LastNameChanged(object? sender, EventArgs e)
        {
            Console.WriteLine(this.LastName + " Nachname hat sich geändert");
        }
    }
}
