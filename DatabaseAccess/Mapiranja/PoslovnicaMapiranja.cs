using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using AgencijaNekretnine.Entiteti;

namespace AgencijaNekretnine.Mapiranja
{
    public class PoslovnicaMapiranja: ClassMap<Poslovnica>
    {   
        public PoslovnicaMapiranja()
        {
            Table("POSLOVNICA");

            Id(x => x.IDPoslovnice).Column("IDPOSLOVNICA").GeneratedBy.SequenceIdentity("S17254.SEQ_POSLOVNICA");

            Map(x => x.Adresa).Column("ADRESA");
            Map(x => x.RadnoVreme).Column("RADNO_VREME");

            References(x => x.SefPoslovnice).Column("IDSEF").LazyLoad();
            HasMany(x => x.NagledaKvartove).KeyColumn("IDPOSLOVNICA").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.ZaposljavaZaposlene).KeyColumn("IDPOSLOVNICA").LazyLoad().Cascade.All().Inverse();

        }
    }
}
