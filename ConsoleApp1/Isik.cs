using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine_Harjutus
{
    abstract class Isik
    {
        public string nimi;
        public int synniAasta;
        public enum sugu { isane, emane };
        public sugu Sugu;
        // Opilane
        public string kooliNimi;
        public string klass;
        public string specialization;
        // Tootaja
        public string asutus;
        public string amet;
        public double tootasu;
        //Kutsekooliopilane
        public string oppeasutus;
        public string eriala;
        public int kursus;

        public Isik(string nimi, int synniAasta, sugu Sugu, string kooliNimi, string klass, string specialization)
        {
            this.nimi = nimi;
            this.synniAasta = synniAasta;
            this.Sugu = Sugu;
            this.kooliNimi = kooliNimi;
            this.klass = klass;
            this.specialization = specialization;
        }

        public Isik(string nimi, int synniAasta, sugu Sugu, string asutus, string amet, double tootasu)
        {
            this.nimi = nimi;
            this.synniAasta = synniAasta;
            this.Sugu = Sugu;
            this.asutus = asutus;
            this.amet = amet;
            this.tootasu = tootasu;
        }

        public Isik(string nimi, int synniAasta, sugu Sugu, string oppeasutus, string eriala, int kursus )
        {
            this.nimi = nimi;
            this.synniAasta = synniAasta;
            this.Sugu = Sugu;
            this.oppeasutus = oppeasutus;
            this.eriala = eriala;
            this.kursus = kursus;
        }

        public Isik(Isik ob)
        {
            this.nimi = ob.nimi; this.synniAasta = ob.synniAasta; this.Sugu = ob.Sugu;
        }

        public virtual void print()
        {
            Console.Write("{0, -10} {1} {2,4}", nimi, Sugu, synniAasta);
        }
        public int arvutaVanus()
        {
            int vanus = DateTime.Now.Year - synniAasta;
            return vanus;
        }

        public void muudaNimi(string newName)
        {
            this.nimi = newName;
        }      

        public Isik() { }
        public abstract double arvutaSissetulek(double maksuvaba, double tulumaks);
        public abstract void print_Info();
        public abstract void print_Haal();
    }
}
