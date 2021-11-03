using MuseoPictoricoG11.Modelos;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace CapaPersistencia
{
    class UsuarioMap : ClassMapping<Usuario>
    {
        public UsuarioMap()
        {
            Id(x => x.Id, map => map.Generator(Generators.Identity));
            Property(x => x.NombreUsuario);
            Property(x => x.Contraseña, m =>
            {
                m.Column(c =>
                {
                    c.NotNullable(true);
                });
            });
            Property(x => x.Caducidad);
            ManyToOne(x => x.m_Empleado, m =>
            {
                m.Column("IdEmpleado");
                m.ForeignKey("FK_Empleado");
                m.Cascade(Cascade.All);
            });

        }
    }
}
