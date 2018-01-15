using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium_PG
{
    class Stacja : ICloneable
    {
        private string nazwaStacji;
        private bool oplataKlimatyczna;
        public string opklim;

        public Object Clone()
        {
            return MemberwiseClone();
        }
        public Stacja()
        {

        }
        public Stacja(string nazwasStacji, bool oplataKlimatyczna, string opklim)
        {
            this.nazwaStacji = nazwasStacji;
            this.oplataKlimatyczna = oplataKlimatyczna;
            if (oplataKlimatyczna == true)
                this.opklim = "tak";
            if (oplataKlimatyczna == false)
                this.opklim = "nie";
        }
        bool JakaOplata()
        {
            return oplataKlimatyczna;
        }

        public override string ToString()
        {
            return base.ToString() + "Stacja: " + nazwaStacji + ", opłata klimatyczna: " + opklim;
        }
    }
}
