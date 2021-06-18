using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencijaNekretnine.Entiteti
{
    public class Agent
    {

        public virtual int IDagent { get; set; }
        public virtual Zaposleni AngazovanOd { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }
        public virtual int Procenat { get; set; }
        public virtual string Telefon { get; set; }

        //public virtual string JMBG { get; set; }

        public virtual DateTime DatRada { get; set; }

        public Agent() { }

        public Agent(int id, string ime, string prez, int proc, string tel)
        {
            IDagent = id;
            this.Ime = ime;
            this.Prezime = prez;
            this.Procenat = proc;
            this.Telefon = tel;
        }
    }
}
