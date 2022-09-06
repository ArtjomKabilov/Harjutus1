using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Kordamine_Harjutus.Isik;

namespace Kordamine_Harjutus
{
    internal class Tootaja: Isik
    {
        
        public Tootaja(string nimi, int synniAasta, sugu Sugu, string asutus, string amet, double tootasu) : base(nimi, synniAasta, Sugu, asutus, amet, tootasu) { }

        public Tootaja(Tootaja tootaja)
        {
            this.nimi = tootaja.nimi;
            this.synniAasta = tootaja.synniAasta;
            this.Sugu = tootaja.Sugu;
            this.asutus = tootaja.asutus;
            this.amet = tootaja.amet;
            this.tootasu = tootaja.tootasu;
        }
        public override void print_Haal()
        {
            throw new NotImplementedException();
        }

        public double arvutaSissetulek()
        {
            double result = tootasu;
            result = tootasu - 500 + (tootasu * 0.2);

            return result;
        }

        public override void print_Info()
        {
            Console.WriteLine($"\nSee on {nimi}, ta on {arvutaVanus()} aastat vana, ta on {Sugu}, ta on tootas {asutus}, Amet: {amet}, tema palk {randomSalary()} euro");
            Console.WriteLine($"Tulumaks: {Tulumaks()} euro");
        }

        public override double arvutaSissetulek(double maksuvaba, double tulumaks)
        {
            throw new NotImplementedException();
        }
        public double randomSalary() {
            Random rand = new Random();
            tootasu = rand.Next(1000, 2000);
            
            return tootasu;
        }
        public double Tulumaks()
        {
            double tulumaks = Math.Round(tootasu - arvutaSissetulek(), 2);
            return tulumaks;
        }

        public void muudaAasta(int uusAasta) { synniAasta = uusAasta; }
        public void muudaSugu(sugu uusSugu) { Sugu = uusSugu; }
        public void muudaAmet(string uusAmet) { this.amet = uusAmet; }
        public void muudaAsutus(string uusAsutus) { this.asutus = uusAsutus; }


    }
}
