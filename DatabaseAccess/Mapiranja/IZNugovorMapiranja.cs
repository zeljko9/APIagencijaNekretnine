using FluentNHibernate.Mapping;
using AgencijaNekretnine.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencijaNekretnine.Mapiranja
{
    public class IZNugovorMapiranja:ClassMap<IznajmUgovor>
    {
        public IZNugovorMapiranja()
        {
            Table("UGOVOR_IZNAJMLJIVANJE");

            Id(x => x.IDugizn).Column("IDUGIZ").GeneratedBy.SequenceIdentity("S17254.SEQ_IZNAJMLJIVANJE_UGOVOR");

            Map(x => x.Mesecna_zakupina).Column("MESECNA_ZAKUPINA");
            Map(x => x.Datum_sklapanja).Column("DATUM_SKLAPANJA");
            Map(x => x.Datum_isteka).Column("DATUM_ISTEKA");
            References(x => x.Nekretnina).Column("IDNEKRETNINA").LazyLoad();
            References(x => x.Kupac).Column("IDKUPAC").LazyLoad();
            References(x => x.Prodavac).Column("JMBGPRODAVCA").LazyLoad();
            //References(x => x.Vlasnik).Column("IDVLASNIK").LazyLoad();
        }
    }
}
