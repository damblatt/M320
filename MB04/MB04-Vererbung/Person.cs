using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB04_Vererbung
{
    public abstract class Person
    {
        private int _key;

        public string Name { get; set; }
        public string Vorname { get; set; }
        protected int identNr { get; }

        public Person(int identNr)
        {
            this.identNr = identNr;
        }

        public virtual void Esse()
        {
            Console.WriteLine("Ich als Person esse mit Messer und Gabel.");
        }

        public abstract void Trage();
    }
}
