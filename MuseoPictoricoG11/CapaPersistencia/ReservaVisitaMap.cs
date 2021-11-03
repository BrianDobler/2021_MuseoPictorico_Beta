using MuseoPictoricoG11.Modelos;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace CapaPersistencia
{

    class ReservaVisitaMap : ClassMapping<ReservaVisita>
    {
        public ReservaVisitaMap()
        {
            Id(x => x.Id, map => map.Generator(Generators.Identity));
            Property(x => x.CantidadAlumnos);
            Property(x => x.CantidadAlumnosConfirmada);
            Property(x => x.DuracionEstimada);
            Property(x => x.FechaHoraCreacion);
            Property(x => x.FechaHoraReserva);
            Property(x => x.HoraFinReal);
            Property(x => x.HoraInicioReal);
            Property(x => x.NumeroReserva);
            ManyToOne(x => x.m_Empleado, m =>
            {
                m.Column("IdEmpleadoReservaVisita");
                m.ForeignKey("FK_EmpleadoReservaVisita");
                m.Cascade(Cascade.All);
            });
            ManyToOne(x => x.m_Sede, m =>
            {
                m.Column("IdSedeReservaVisita");
                m.ForeignKey("FK_SedeReservaVisita");
                m.Cascade(Cascade.All);
            });

        }
    }
}
