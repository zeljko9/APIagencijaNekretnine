using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencijaNekretnine.Entiteti
{
    public class KupoprodajniUgovor
    {
        public virtual int IDugkp { get; set; }
        public virtual Nekretnina Nekretnina { get; set; }
        public virtual Lice Kupac { get; set; }
        //public virtual Lice Vlasnik { get; set; }
        public virtual Zaposleni Prodavac { get; set; }
        public virtual DateTime Datum_transakcije { get; set; }


        public KupoprodajniUgovor() { }
        public KupoprodajniUgovor(int id, DateTime trans)
        {
            this.IDugkp = id;
            this.Datum_transakcije = trans;
        }
    }
}
