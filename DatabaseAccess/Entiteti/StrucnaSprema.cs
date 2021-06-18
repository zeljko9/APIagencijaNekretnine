using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencijaNekretnine.Entiteti
{
    public class StrucnaSprema
    {
        public virtual int IDSpreme { get; set; }

        public virtual Zaposleni pripadaProdavcu { get; set; }

        public virtual String NazivSpreme { get; set; }

        public StrucnaSprema()
        {

        }
    }
}
