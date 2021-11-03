using MuseoPictoricoG11.Modelos;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace CapaPersistencia
{
    class DetalleExposicionMap : ClassMapping<DetalleExposicion>
    {
        public DetalleExposicionMap()
        {
            Id(x => x.Id, map => map.Generator(Generators.Identity));
            Property(x => x.LugarAsignado);
            ManyToOne(x => x.m_Obra, m =>
            {
                m.Column("IdObra");
                m.ForeignKey("FK_Obra");
                m.Cascade(Cascade.All);
            });

        }
    }
}
