using MuseoPictoricoG11.Modelos;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace CapaPersistencia
{
    class SesionMap : ClassMapping<Sesion>
    {
        public SesionMap()
        {
            Id(x => x.Id, map => map.Generator(Generators.Identity));
            Property(x => x.FechaHoraInicio);
            Property(x => x.FechaHoraFin);
            ManyToOne(x => x.m_Usuario, m =>
            {
                m.Column("IdUsuario");
                m.ForeignKey("FK_Usuario");
                m.Cascade(Cascade.All);
            });
        }
    }
}
