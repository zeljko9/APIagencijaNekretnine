using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencijaNekretnine.Entiteti
{
    public class Kvart
    {
        public virtual int IDKvart { get; set; }
        public virtual int Zona { get; set; }
        public virtual Poslovnica PripadaPoslovnici { get; set; }

        public virtual IList<Nekretnina> NekretnineKvarta { get; set; }

        public Kvart()
        { 
            this.NekretnineKvarta = new List<Nekretnina>();
        }

        public Kvart(int id, int zona)
        {
            this.IDKvart = id;
            this.Zona = zona;
        }

    }
}
