using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using AgencijaNekretnine.Entiteti;

namespace AgencijaNekretnine.Mapiranja
{
    public class ZaposleniMapiranja:ClassMap<Zaposleni>
    {
        public ZaposleniMapiranja()
        {
            Table("ZAPOSLENI");

            Id(x => x.JMBG).Column("JMBG").GeneratedBy.Assigned();

            //DiscriminateSubClassesOnColumn("SEFFLAG");

            Map(x => x.Ime).Column("IME");
            Map(x => x.Prezime).Column("PREZIME");
            Map(x => x.DatZaposlenja).Column("DAT_ZAPOSLENJA");
            Map(x => x.DatPostavljanja).Column("DATUMPOSTAVLJANJA");
            Map(x => x.SefFlag).Column("SEFFLAG");
            Map(x => x.StrucnaSprema).Column("STRUCNASPREMA");

            References(x => x.RadiUPoslovnici).Column("IDPOSLOVNICA").LazyLoad();
            HasMany(x => x.unajmioAgente).KeyColumn("IDPRODAVAC").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.KPugovori).KeyColumn("JMBGZAPOSLENOG").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.IZNugovori).KeyColumn("JMBGPRODAVCA").LazyLoad().Cascade.All().Inverse();
            // HasMany(x=>x.strucnaSprema).KeyColumn("")
        }
    }

    /*public class ProdavacMapiranja:SubclassMap<Prodavac>
    {
        public ProdavacMapiranja()
        {
            DiscriminatorValue(0);
        }
    }

    public class SefMapiranja : SubclassMap<Sef>
    {
        public SefMapiranja()
        {
            DiscriminatorValue(1);
        }
    }*/
}
