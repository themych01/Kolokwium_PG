using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium_PG
{
    class Ekspres:Pociag
    {
        public override double KosztPoRabacie(double koszt)
        {
            return koszt * 0.75;
        }

    }
}
