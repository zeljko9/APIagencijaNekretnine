using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencijaNekretnine.Entiteti
{
    public class Oprema
    {
        public virtual int IDoprema { get; set; }
        public virtual string NazivOpreme { get; set; }
        public virtual Nekretnina PripadaNekretnini { get; set; }

        public Oprema() { }

        public Oprema(int iDoprema, string nazivOpreme, Nekretnina pripadaNekretnini)
        {
            IDoprema = iDoprema;
            NazivOpreme = nazivOpreme;
            PripadaNekretnini = pripadaNekretnini;
        }
    }
}
