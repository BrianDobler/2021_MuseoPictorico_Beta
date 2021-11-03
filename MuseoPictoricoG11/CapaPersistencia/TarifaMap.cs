using MuseoPictoricoG11.Modelos;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace CapaPersistencia
{
    class TarifaMap : ClassMapping<Tarifa>
    {
        public TarifaMap()
        {
            Id(x => x.Id, map => map.Generator(Generators.Identity));
            Property(x => x.FechaFinVigencia);
            Property(x => x.FechaInicioVigencia);
            Property(x => x.Monto);
            Property(x => x.MontoAdicionalGuia);
            ManyToOne(x => x.m_TipoDeEntrada, m =>
            {
                m.Column("IdTipoDeEntrada");
                m.ForeignKey("FK_TipoDeEntrada");
                m.Cascade(Cascade.All);
            });
            ManyToOne(x => x.m_TipoVisita, m =>
            {
                m.Column("IdTipoVisita");
                m.ForeignKey("FK_TipoVisita");
                m.Cascade(Cascade.All);
            });

        }
    }
}
