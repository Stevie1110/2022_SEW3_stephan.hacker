using System;
using System.Collections.Generic;
using System.Text;

namespace _03TractorAndImplement
{
    class Tractor
    {
        private string type;
        private int weight;
        private int maxWeight;
        private Implement myImplement;

        public Tractor(string type, int weight, int maxWeight)      //Konstruktor
        {
            this.type = type;
            this.weight = weight;
            this.maxWeight = maxWeight;
        }

        public string Type
        {
            get
            {
                return this.type;
            }
        }

        public int Weight
        {
            get
            {
                return this.weight;
            }set
            {
                this.weight = value;
            }
        }

        public int MaxWeight
        {
            get
            {
                return this.maxWeight;
            }
        }

        public Implement MyImplement  //Property
        {
            get
            {
                return this.myImplement;        //Kann auch null sein
            }set
            {
                Implement i = value;
                if(i != null && this.weight + i.Weight > this.maxWeight)
                {
                    //maximales Gewicht überschritten --> Exception
                    throw new ImplementTooHeavyException();
                }

                this.myImplement = value;
            }  
        }

        public override string ToString()
        {
            if(this.myImplement != null)
            {
                return "Tractor: " + this.type + "; Implement: " + this.myImplement.ToString();
            }
            else
            {
                return "Tractor: " + this.type;
            }
        }
    }
}
