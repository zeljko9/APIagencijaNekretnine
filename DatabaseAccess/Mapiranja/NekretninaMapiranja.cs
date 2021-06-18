using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using AgencijaNekretnine.Entiteti;

namespace AgencijaNekretnine.Mapiranja
{
    public class NekretninaMapiranja : ClassMap<Nekretnina>
    {
        public NekretninaMapiranja()
        {
            Table("NEKRETNINA");

            //DiscriminateSubClassesOnColumn("TIPNEKRETNINE");

            Id(x => x.IDNekretnina).Column("IDNEKRETNINA").GeneratedBy.SequenceIdentity("S17254.SEQ_NEKRETNINA");

            Map(x => x.Ulica).Column("ULICA");
            Map(x => x.Sprat).Column("SPRAT");
            Map(x => x.Broj).Column("BROJ");
            Map(x => x.Cena).Column("CENA");
           // Map(x => x.IDvlasnik).Column("IDVLASNIK");
            Map(x => x.DatumIzgradnje).Column("DATUMIZGRADNJE");
            Map(x => x.Starost).Column("STAROST");
            Map(x => x.TipNekretnine).Column("TIPNEKRETNINE");
            Map(x => x.BrKupatila).Column("BR_KUPATILA");
            HasMany(x => x.oprema).KeyColumn("IDNEKRETNINA").LazyLoad().Cascade.All().Inverse();
            References(x => x.PripadaKvartu).Column("IDKVART").LazyLoad();
            References(x => x.Vlasnik).Column("IDVLASNIKA").LazyLoad();
            //HasOne(x => x.IDvlasnik).ForeignKey("IDVLASNIK").LazyLoad();
        }
    }

  /* class StambenaNekretninaMapiranja : SubclassMap<NekretninaMapiranja>
    {
        public StambenaNekretninaMapiranja()
        {
            DiscriminatorValue("Stambena");
        }
    }

    class PoslovnaNekretninaMapiranja : SubclassMap<NekretninaMapiranja>
    {
        public PoslovnaNekretninaMapiranja()
        {
            DiscriminatorValue("Poslovna");
        }
    }*/
}
