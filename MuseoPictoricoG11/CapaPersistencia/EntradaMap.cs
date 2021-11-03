using MuseoPictoricoG11.Modelos;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace CapaPersistencia
{
    class EntradaMap : ClassMapping<Entrada>
    {
        public EntradaMap()
        {
            Id(x => x.Id, map => map.Generator(Generators.Identity));
            Property(x => x.FechaVenta);
            Property(x => x.HoraVenta);
            Property(x => x.Monto);
            Property(x => x.Numero);
            ManyToOne(x => x.m_Tarifa, m =>
            {
                m.Column("IdEntradaTarifa");
                m.ForeignKey("FK_EntradaTarifa");
                m.Cascade(Cascade.All);
            });
            ManyToOne(x => x.m_Sede, m =>
            {
                m.Column("IdSedeEntradaTarifa");
                m.ForeignKey("FK_SedeEntradaTarifa");
                m.Cascade(Cascade.All);
            });

        }
    }
}
