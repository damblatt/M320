using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    internal class Zimmer
    {
        public Hotel Hotel { get; set; }
        public List<Bett> Betten { get; set; } = new List<Bett>();

        public Zimmer(Hotel hotel)
        {
            if (hotel.Zimmer.Count < 10)
            {
                hotel.Zimmer.Add(this);
                Hotel = hotel;
            }
            else
            {
                Console.WriteLine("Das Hotel hat bereits die maximale Anzahl an Zimmern erreicht.");
            }
        }
    }
}
