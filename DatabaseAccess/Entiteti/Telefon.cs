using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencijaNekretnine.Entiteti
{
    public class Telefon
    {
        public virtual int IDTelefon { get; set; }
        
        public virtual string brTel { get; set; }

        public virtual Lice PripadaLicu { get; set; }

        public Telefon() { }
        public Telefon(int id, string tel)
        {
            this.IDTelefon = id;
            this.brTel = tel;
        }
    }
}
