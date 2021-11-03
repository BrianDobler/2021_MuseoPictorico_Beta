using MuseoPictoricoG11.Modelos;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace CapaPersistencia
{
    class TipoVisitaMap : ClassMapping<TipoVisita>
    {
        public TipoVisitaMap()
        {
            Id(x => x.Id, map => map.Generator(Generators.Identity));
            Property(x => x.Nombre);

        }
    }
}
