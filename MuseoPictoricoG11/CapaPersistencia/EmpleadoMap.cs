using MuseoPictoricoG11.Modelos;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace CapaPersistencia
{
    public class EmpleadoMap : ClassMapping<Empleado>
    {
        public EmpleadoMap()
        {
            Id(x => x.Id, map => map.Generator(Generators.Identity));
            Property(x => x.Apellido);
            Property(x => x.CodigoValidacion);
            Property(x => x.Cuit);
            Property(x => x.Dni);
            Property(x => x.Domicilio);
            Property(x => x.FechaIngreso);
            Property(x => x.FechaNacimiento);
            Property(x => x.Mail);
            Property(x => x.NombreEmpleado);
            Property(x => x.Sexo);
            Property(x => x.Telefono);

            ManyToOne(x => x.m_Sede, m =>
            {
                m.Column("IdSede");
                m.ForeignKey("FK_Sede");
                m.Cascade(Cascade.All);
            });

        }
    }
}
