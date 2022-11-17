using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07Events
{
    internal class Bar
    {
        public event EventHandler SpendRoundEvent;

        public string Name { get; set; }

        public void SpendRound()
        {
            if(this.SpendRoundEvent != null)            // Wichtig!!!
            {
                this.SpendRoundEvent(this, EventArgs.Empty);
            }
        }
    }
}
