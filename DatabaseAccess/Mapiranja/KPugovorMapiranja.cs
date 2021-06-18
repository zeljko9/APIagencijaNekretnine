using AgencijaNekretnine.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencijaNekretnine.Mapiranja
{
    public class KPugovorMapiranja:ClassMap<KupoprodajniUgovor>
    {
        public KPugovorMapiranja() {

            Table("UGOVOR_PRODAJA");

            Id(x => x.IDugkp).Column("IDUGPR").GeneratedBy.SequenceIdentity("S17254.SEQ_KUPOPROD_UGOVOR");

            Map(x => x.Datum_transakcije).Column("DATUM_TRANSAKCIJE");
            References(x => x.Nekretnina).Column("IDNEKRENINA").LazyLoad();
            References(x => x.Kupac).Column("IDKUPAC").LazyLoad();
            //References(x => x.Vlasnik).Column("IDVLASNIK").LazyLoad();
            References(x => x.Prodavac).Column("JMBGZAPOSLENOG").LazyLoad();
        }
    }
}
