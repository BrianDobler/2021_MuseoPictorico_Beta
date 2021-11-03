using MuseoPictoricoG11.Modelos;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace CapaPersistencia
{
    class ExposicionMap : ClassMapping<Exposicion>
    {
        public ExposicionMap()
        {
            Id(x => x.Id, map => map.Generator(Generators.Identity));
            Property(x => x.FechaFinReplanificada);
            Property(x => x.FechaHoraFin);
            Property(x => x.FechaInicioReplanificada);
            Property(x => x.HoraApertura);
            Property(x => x.HoraCierre);
            Property(x => x.Nombre);
            Bag<DetalleExposicion>(x => x.m_DetalleExposicion, m =>
            {
                m.Key(k => k.Column("IdExposicion"));
                m.Cascade(Cascade.All);
            }
                , k => k.OneToMany(x => x.Class(typeof(DetalleExposicion))));

        }
    }
}
