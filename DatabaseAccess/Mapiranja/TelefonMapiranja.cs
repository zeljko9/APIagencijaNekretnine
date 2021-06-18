using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using AgencijaNekretnine.Entiteti;

namespace AgencijaNekretnine.Mapiranja
{
    public class TelefonMapiranja:ClassMap<Telefon>
    {
        public TelefonMapiranja()
        {
            Table("TELEFON");

            Id(x => x.IDTelefon).Column("IDTELEFON").GeneratedBy.SequenceIdentity("S17254.SEQ_TELEFON");

            Map(x => x.brTel).Column("TELEFON");

            References(x => x.PripadaLicu).Column("JMBGPIB").LazyLoad(); //JMBG_PIB je bilo
        }
    }
}
