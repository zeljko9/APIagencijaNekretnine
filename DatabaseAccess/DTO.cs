using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgencijaNekretnine.Entiteti;

namespace AgencijaNekretnine
{

    #region LiceBasic
    public class LiceBasic
    {
        public string JMBG_PIB { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Adresa { get; set; }
        public string TipLica { get; set; }
        public IList<KupoprodajniUgovorBasic> KPugovori { get; set; }
        public IList<IznajmUgovorBasic> IZNugovori { get; set; }
        public IList<TelefonBasic> listaTelefona { get; set; }

        public IList<NekretninaBasic> listaNekretninaUPosedu { get; set; }

        public LiceBasic(string jmbg, string ime, string prez, string adresa)
        {
            this.JMBG_PIB = jmbg;
            this.Ime = ime;
            this.Prezime = prez;
            this.Adresa = adresa;
            if (Convert.ToString(JMBG_PIB).Length >= 13)
            {
                TipLica = "Fizicko";
            }
            else {
                TipLica = "Pravno";
            }

            this.listaNekretninaUPosedu = new List<NekretninaBasic>();
            this.KPugovori = new List<KupoprodajniUgovorBasic>();
            this.IZNugovori = new List<IznajmUgovorBasic>();
            this.listaTelefona = new List<TelefonBasic>();

        }
        public LiceBasic(Lice l) { 
            
        }

        public LiceBasic() {
            this.listaNekretninaUPosedu = new List<NekretninaBasic>();
            this.KPugovori = new List<KupoprodajniUgovorBasic>();
            this.IZNugovori = new List<IznajmUgovorBasic>();
            this.listaTelefona = new List<TelefonBasic>();
        }

    }

    public class FizickoLiceBasic : LiceBasic
    {
        public FizickoLiceBasic() :base()
        {

        }

        public FizickoLiceBasic(string jmbg, string ime, string prez, string adresa):base( jmbg,  ime,  prez,  adresa)
        {

        }
    }

    public class PravnoLiceBasic : LiceBasic
    {
        public PravnoLiceBasic() : base()
        {

        }

        public PravnoLiceBasic(string jmbg, string ime, string prez, string adresa) : base(jmbg, ime, prez, adresa)
        {

        }
    }

    #endregion

    #region NekretninaBasic
    public class NekretninaBasic
    {
        public int IDNekretnina { get; set; }
        public string Ulica { get; set; }
        public int Broj { get; set; }
        public int Sprat { get; set; }
        public int Cena { get; set; }
        public int Starost { get; set; }
        public DateTime DatumIzgradnje { get; set; }
        public LiceBasic Vlasnik { get; set; }
        public string TipNekretnine { get; set; }
        public int BrKupatila { get; set; }

        public IList<OpremaBasic> oprema { get; set; }
        public KvartBasic pripadaKvartu { get; set; }

        public NekretninaBasic() { this.oprema = new List<OpremaBasic>(); }

        public NekretninaBasic(int id, string ulica, int br, int sprat, int cena, int star, DateTime dat, string tip, int brkup)
        {
            this.IDNekretnina = id;
            this.Ulica = ulica;
            this.Broj = br;
            this.Sprat = sprat;
            this.Cena = cena;
            this.Starost = star;
            this.DatumIzgradnje = dat;
            this.TipNekretnine = tip;
            this.BrKupatila = brkup;
            this.oprema = new List<OpremaBasic>();
        }
    }

    public class StambenaNekretninaBasic : NekretninaBasic
    {
       public StambenaNekretninaBasic() : base()
        {

        }

        public StambenaNekretninaBasic(int id, string ulica, int br, int sprat, int cena, int star, DateTime dat, string tip, int brkup):base(id, ulica, br, sprat, cena, star, dat, tip, brkup)
        {

        }
    }

    public class PoslovnaNekretninaBasic : NekretninaBasic
    {
        public PoslovnaNekretninaBasic() : base()
        {

        }

        public PoslovnaNekretninaBasic(int id, string ulica, int br, int sprat, int cena, int star, DateTime dat, string tip, int brkup) : base(id, ulica, br, sprat, cena, star, dat, tip, brkup)
        {

        }
    }

    #endregion

    #region ZaposleniBasic
    public class ZaposleniBasic
    {
        public string JMBG { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatZaposlenja { get; set; }

        public virtual IList<IznajmUgovorBasic> IZNugovori { get; set; }
        public virtual IList<KupoprodajniUgovorBasic> KPugovori { get; set; }

        public string StrucnaSprema { get; set; }

        public int SefFlag { get; set; }

        public DateTime DatPostavljanja { get; set; }
        public PoslovnicaBasic radiUPoslovnici { get; set; }

        public IList<AgentBasic> unajmioAgente { get; set; }


        public ZaposleniBasic() { 
            this.unajmioAgente = new List<AgentBasic>();
            this.KPugovori = new List<KupoprodajniUgovorBasic>();
            this.IZNugovori = new List<IznajmUgovorBasic>();
        }
        public ZaposleniBasic(string jmbg,string ime, string prez,DateTime dat,string sprema,int flag,DateTime datPostav)
        {
            this.JMBG = jmbg;
            this.Ime = ime;
            this.Prezime = prez;
            this.DatZaposlenja = dat;
            this.StrucnaSprema = sprema;
            this.SefFlag = flag;
            this.DatPostavljanja = datPostav;
            this.unajmioAgente = new List<AgentBasic>();
            this.KPugovori = new List<KupoprodajniUgovorBasic>();
            this.IZNugovori = new List<IznajmUgovorBasic>();
        }
    }


    public class ProdavacBasic : ZaposleniBasic
    { 
        
        public ProdavacBasic():base()
        {
            
        }

        public ProdavacBasic(string jmbg, string ime, string prez, DateTime dat, string sprema, int flag, DateTime datPostav) :base(jmbg, ime, prez, dat,sprema,flag,datPostav) { }

    }

    public class SefBasic:ZaposleniBasic
    {
        

        public SefBasic():base() { }
        public SefBasic(string jmbg, string ime, string prez, DateTime dat, string sprema, int flag, DateTime datPostav) : base(jmbg, ime, prez, dat, sprema, flag, datPostav) { }
    }

    #endregion

    #region OpremaBasic
    public class OpremaBasic 
    {
        private Nekretnina pripadaNekretnini1;

        public int IDOprema { get; set; }
        public string NazivOpreme { get; set; }
        public NekretninaBasic pripadaNekretnini { get; set; }
        public OpremaBasic() { }
        public OpremaBasic(int id, string naziv)
        {
            this.IDOprema = id;
            this.NazivOpreme = naziv;
        }

        public OpremaBasic(int id, string naziv, Nekretnina pripadaNekretnini1) : this(id, naziv)
        {
            this.pripadaNekretnini1 = pripadaNekretnini1;
        }
    }

    #endregion

    #region TelefonBasic
    public class TelefonBasic
    {
        public int IDTelefon { get; set; }
        public string brTel { get; set; }
        public LiceBasic pripadaLicu { get; set; }

        public TelefonBasic() { }

        public TelefonBasic(int id, string br)
        {
            this.IDTelefon = id;
            this.brTel = br;
        }

        public TelefonBasic(int id, string br, LiceBasic l) : this(id, br)
        {
            this.pripadaLicu = l;
        }
    }

    #endregion

    #region AgentBasic
    public class AgentBasic
    {
        public int IDagetn { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int Procenat { get; set; }
        public string brTel { get; set; }

        public DateTime DatRada { get; set; }
        public ZaposleniBasic angazovanOd { get; set; }

        public AgentBasic() { }
        public AgentBasic(int id, string ime, string prez, int proc, string br)
        {
            this.IDagetn = id;
            this.Ime = ime;
            this.Prezime = prez;
            this.Procenat = proc;
            this.brTel = br;
        }

        public AgentBasic(int id, string ime, string prez, int proc, string br,ProdavacBasic p):this(id, ime,prez,proc,br)
        {
            this.angazovanOd = p;
        }


    }

    #endregion

    #region PoslovnicaBasic
    public class PoslovnicaBasic 
    {
        public int IDPoslovnice { get; set; }
        public string Adresa { get; set; }
        public string RadnoVreme { get; set; }
        public ZaposleniBasic Sef { get; set; }
        public IList<ZaposleniBasic> listaZaposlenih { get; set; }
        public IList<KvartBasic> nagledaKvartove { get; set; }

        public PoslovnicaBasic() 
        {
            this.listaZaposlenih = new List<ZaposleniBasic>();
            this.nagledaKvartove = new List<KvartBasic>();
        }

        public PoslovnicaBasic(int id, string adr, string vrem)
        {
            this.IDPoslovnice = id;
            this.Adresa = adr;
            this.RadnoVreme = vrem;
            this.listaZaposlenih = new List<ZaposleniBasic>();
            this.nagledaKvartove = new List<KvartBasic>();
        }
    }
    #endregion

    #region KvartBasic
    public class KvartBasic 
    {
        public int IDKvart { get; set; }
        public int Zona { get; set; }
        public PoslovnicaBasic pripadaPoslovnici { get; set; }
        public IList<NekretninaBasic> listaNekretnina { get; set; }

        public KvartBasic()
        {
            this.listaNekretnina = new List<NekretninaBasic>();
        }

        public KvartBasic(int id, int zona)
        {
            this.IDKvart = id;
            this.Zona = zona;
            this.listaNekretnina = new List<NekretninaBasic>();
        }
    }

    #endregion

    #region IznajmUgovorBasic
    public class IznajmUgovorBasic
    { 
        public int IDUgovorIznajm { get; set; }
        public NekretninaBasic IznajmNekretnina { get; set; }
        public LiceBasic Vlasnik { get; set; }
        public LiceBasic Kupac { get; set; }
        public ZaposleniBasic Prodavac { get; set; }
        public DateTime DatSklapanja { get; set; }
        public DateTime DatIsteka { get; set; }
        public int MesecnaZakupina { get; set; }

        public IznajmUgovorBasic() { }

        public IznajmUgovorBasic(int id, DateTime od, DateTime doo, int cena)
        {
            this.IDUgovorIznajm = id;
            this.DatSklapanja = od;
            this.DatIsteka = doo;
            this.MesecnaZakupina = cena;
        }
    }

    #endregion

    #region KupoprodajniUgovorBasic
    public class KupoprodajniUgovorBasic
    {
        public int IDUgovorKupoprodaja { get; set; }
        public NekretninaBasic KupoprodNekretnina { get; set; }
        public LiceBasic Kupac { get; set; }
        public LiceBasic Vlasnik { get; set; }
        public ZaposleniBasic Prodavac { get; set; }
        public DateTime DatTransakcije { get; set; }

        public KupoprodajniUgovorBasic() { }

        public KupoprodajniUgovorBasic(int id, DateTime dat)
        {
            this.IDUgovorKupoprodaja = id;
            this.DatTransakcije = dat;
        }

    }
    #endregion
}