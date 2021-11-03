using MuseoPictoricoG11.Modelos;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace CapaPersistencia
{
    class SedeMap : ClassMapping<Sede>
    {
        public SedeMap()
        {
            Id(x => x.Id, map => map.Generator(Generators.Identity));
            Property(x => x.CantMaximaVisitantes);
            Property(x => x.Domicilio);
            Property(x => x.Horario);
            Property(x => x.Nombre);
            Bag<Exposicion>(x => x.m_Exposicion, m =>
            {
                m.Key(k => k.Column("IdSede"));
                m.Cascade(Cascade.All);
            }
                , k => k.OneToMany(x => x.Class(typeof(Exposicion))));
            Bag<Tarifa>(x => x.m_Tarifa, m =>
            {
                m.Key(k => k.Column("IdSede"));
                m.Cascade(Cascade.All);
            }
                , k => k.OneToMany(x => x.Class(typeof(Tarifa))));

        }
    }
}
