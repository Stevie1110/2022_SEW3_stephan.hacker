using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07Events
{
    internal class Person
    {
        public string Name { get; set; }

        public void enter(Bar b)
        {
            b.SpendRoundEvent += ReceiveDrink;
        }

        public void leave(Bar b)
        {
            b.SpendRoundEvent -= ReceiveDrink;
        }

        private void ReceiveDrink(object? sender, EventArgs e)
        {
            Console.WriteLine(this.Name + " ist happy about the drink");
        }
    }
}
