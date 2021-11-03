using MuseoPictoricoG11.Modelos;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace CapaPersistencia
{
    class ObraMap : ClassMapping<Obra>
    {
        public ObraMap()
        {
            Id(x => x.Id, map => map.Generator(Generators.Identity));
            Property(x => x.Alto);
            Property(x => x.Ancho);
            Property(x => x.CodigoSensor);
            Property(x => x.Descripcion);
            Property(x => x.DuracionExtendida);
            Property(x => x.DuracionResumida);
            Property(x => x.FechaCreacion);
            Property(x => x.Nombre);
            Property(x => x.Peso);
            Property(x => x.Valuacion);

        }
    }
}
