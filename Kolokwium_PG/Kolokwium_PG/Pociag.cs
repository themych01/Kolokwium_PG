using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium_PG
{
    class Pociag: IPodroz
    {
        protected double koszt;
        private Queue<Stacja> trasaPociagu = new Queue<Stacja>();
        public Pociag()
        {
            koszt = 100;
        }
        virtual public double KosztPoRabacie(double koszt)
        {
            return koszt * 0.9;
        }
        public void DodajStacje(string nazwaStacji, bool oplataKlimatyczna)
        {
            trasaPociagu.Enqueue(new Stacja());
            if (oplataKlimatyczna == true)
                koszt = koszt + 15;

        }
        public void UsunStacje()
        {
            trasaPociagu.Dequeue();

        }
        public void Powrot()
        {
            Stacja Kopia = trasaPociagu.Peek();
            trasaPociagu.Enqueue(Kopia);
        }
        string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        public void ZapiszPodroz()
        {

            File.WriteAllText(mydocpath + @"\PlanPodrozy.txt", ToString());
        }
 

    }

}
