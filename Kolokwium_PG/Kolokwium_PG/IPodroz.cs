using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium_PG
{
    interface IPodroz
    {
        void DodajStacje(string nazwaStacji, bool oplataKlimatyczna);
        void Powrot();
        void UsunStacje();
        void ZapiszPodroz();
    }
}
