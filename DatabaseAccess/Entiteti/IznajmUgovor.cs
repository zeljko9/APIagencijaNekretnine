using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencijaNekretnine.Entiteti
{
    public class IznajmUgovor
    {
        public virtual int IDugizn { get; set; }
        public virtual Nekretnina Nekretnina { get; set; }
        public virtual Lice Kupac { get; set; }
        //public virtual Lice Vlasnik { get; set; }
        public virtual Zaposleni Prodavac { get; set; }
        public virtual DateTime Datum_sklapanja { get; set; }
        public virtual DateTime Datum_isteka { get; set; }
        public virtual int Mesecna_zakupina { get; set; }

        public IznajmUgovor() { }

        public IznajmUgovor(int id, DateTime sklap, DateTime istek, int cena)
        {
            this.IDugizn = id;
            this.Datum_sklapanja = sklap;
            this.Datum_isteka = istek;
            this.Mesecna_zakupina = cena;
        }
    }
}
