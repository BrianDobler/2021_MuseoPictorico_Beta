using MuseoPictoricoG11.Modelos;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace CapaPersistencia
{
    class TipoDeEntradaMap : ClassMapping<TipoDeEntrada>
    {
        public TipoDeEntradaMap()
        {
            Id(x => x.Id, map => map.Generator(Generators.Identity));
            Property(x => x.Nombre);

        }
    }
}
