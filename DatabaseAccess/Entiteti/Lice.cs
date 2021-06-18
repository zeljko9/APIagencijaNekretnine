using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencijaNekretnine.Entiteti
{
    public class Lice
    {

        public virtual string JMBG_PIB { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }
        public virtual string Adresa { get; set; }
        public virtual string TipLica { get; set; }

        public virtual IList<Nekretnina> listaNekretninaUPosedu { get; set; }
        public virtual IList<IznajmUgovor> IZNugovori { get; set; }
        public virtual IList<KupoprodajniUgovor> KPugovori { get; set; }

        //1:N veza sa TELEFON, LICE ima VISE TELEFONA
        public virtual IList<Telefon> TelefoniLica { get; set; }


        public Lice()
        {
            this.TelefoniLica = new List<Telefon>();
            this.KPugovori = new List<KupoprodajniUgovor>();
            this.IZNugovori = new List<IznajmUgovor>();
            this.listaNekretninaUPosedu = new List<Nekretnina>();
        }

        public Lice(string jMBG_PIB, string ime, string prezime, string adresa, string tipLica)
        {
            JMBG_PIB = jMBG_PIB;
            Ime = ime;
            Prezime = prezime;
            Adresa = adresa;
            TipLica = tipLica;
            this.TelefoniLica = new List<Telefon>();
            this.KPugovori = new List<KupoprodajniUgovor>();
            this.IZNugovori = new List<IznajmUgovor>();
            this.listaNekretninaUPosedu = new List<Nekretnina>();
        }

        public Lice(Lice kupac)
        {
            JMBG_PIB = kupac.JMBG_PIB;
            Ime = kupac.Ime;
            Prezime = kupac.Prezime;
            Adresa = kupac.Adresa;
            TipLica = kupac.TipLica;
            IZNugovori = kupac.IZNugovori;
            KPugovori = kupac.KPugovori;
            TelefoniLica = kupac.TelefoniLica;
            KPugovori = kupac.KPugovori;
        }
    }

   /* public class FizickoLice : Lice
    {
        public FizickoLice() : base() { }

        public FizickoLice(string jMBG_PIB, string ime, string prezime, string adresa, string tipLica ):base(jMBG_PIB, ime, prezime, adresa, tipLica ) { }
    }

    public class PravnoLice : Lice
    {
        public PravnoLice() : base() { }

        public PravnoLice(string jMBG_PIB, string ime, string prezime, string adresa, string tipLica) : base(jMBG_PIB, ime, prezime, adresa, tipLica) { }
    }
   
    */
    
}
