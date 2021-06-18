using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using AgencijaNekretnine.Entiteti;

namespace AgencijaNekretnine.Mapiranja
{

        public class AgentMapiranja : ClassMap<Agent>
        {
            public AgentMapiranja()
            {
                Table("AGENT");

            Id(x => x.IDagent).Column("IDAGENT").GeneratedBy.SequenceIdentity("S17254.SEQ_AGENT"); ;

            //Id(x => x.JMBG).Column("IDPRODAVAC").GeneratedBy.Assigned();

             Map(x => x.Ime).Column("IME");
             Map(x => x.Prezime).Column("PREZIME");
             Map(x => x.Procenat).Column("PROCENAT");
             Map(x => x.Telefon).Column("TELEFON");
             Map(x => x.DatRada).Column("DATUM_RADA");

             References(x => x.AngazovanOd).Column("IDPRODAVAC").LazyLoad();

            }

        }
    
}
