using System;

namespace _04StaticExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Example ex = new Example();
            ex.doSomething();

            Example.doSomethingElse();              //Statische Methode
        }
    }
}
