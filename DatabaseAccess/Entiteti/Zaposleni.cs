using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencijaNekretnine.Entiteti
{
   public class Zaposleni
    {
        public virtual string JMBG { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }
        public virtual DateTime DatZaposlenja { get; set; }

        public virtual IList<IznajmUgovor> IZNugovori { get; set; }
        public virtual IList<KupoprodajniUgovor> KPugovori { get; set; }

        public virtual string StrucnaSprema { get; set; }

        public virtual int SefFlag { get; set; }

        public virtual DateTime DatPostavljanja { get; set; }
        public virtual Poslovnica RadiUPoslovnici { get; set; }

        public virtual IList<Agent> unajmioAgente { get; set; }

        public Zaposleni()
        {
            this.unajmioAgente = new List<Agent>();
            this.KPugovori = new List<KupoprodajniUgovor>();
            this.IZNugovori = new List<IznajmUgovor>();
        }

        public Zaposleni(string jmbg, string ime, string prez, DateTime zapos, string sprema, int flag, DateTime postav)
        {
            this.JMBG = jmbg;
            this.Ime = ime;
            this.Prezime = prez;
            this.DatZaposlenja = zapos;
            this.DatPostavljanja = postav;
            this.StrucnaSprema = sprema;
            this.SefFlag = flag;

        }
    }

   /* public class Prodavac : Zaposleni
    {
        public Prodavac() : base() { }
        public Prodavac(string jmbg, string ime, string prez, DateTime zapos, string sprema, int flag, DateTime postav):base(jmbg,  ime, prez, zapos, sprema, flag, postav) { }
    }

   public class Sef : Zaposleni
    {
        public Sef() : base() { }

        public Sef(string jmbg, string ime, string prez, DateTime zapos, string sprema, int flag, DateTime postav) : base(jmbg, ime, prez, zapos, sprema, flag, postav) { }
    }*/
}
