using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine_Harjutus
{
    internal class Kutsekooliopilane: Isik
    {
        public Kutsekooliopilane(string nimi, int synniAasta, sugu Sugu, string oppeasutus, string eriala, int kursus) : base(nimi, synniAasta, Sugu, oppeasutus, eriala, kursus) { }

        public Kutsekooliopilane(Kutsekooliopilane kutsekooliopilane) {
            this.nimi = kutsekooliopilane.nimi;
            this.synniAasta = kutsekooliopilane.synniAasta;
            this.Sugu = kutsekooliopilane.Sugu;
            this.oppeasutus = kutsekooliopilane.oppeasutus;
            this.eriala = kutsekooliopilane.eriala;
            this.kursus = kutsekooliopilane.kursus;
        }
        public override double arvutaSissetulek(double maksuvaba, double tulumaks)
        {
            throw new NotImplementedException();
        }

        public override void print_Haal()
        {
            throw new NotImplementedException();
        }

        public void muudaPlace(string newPlace)
        {
            this.oppeasutus = newPlace;
        }

        public void muudaProf(string newProf)
        {
            this.eriala = newProf;
        }

        public void muudaKurs(int newKurs)
        {
            this.kursus = newKurs;
        }

        public override void print_Info()
        {           
            Console.WriteLine($"\nSee on {nimi}, ta on {arvutaVanus()} aastat vana, tema sugu on{Sugu}, ta oppinud {oppeasutus},{eriala}, {kursus}");
        }
    }
}
