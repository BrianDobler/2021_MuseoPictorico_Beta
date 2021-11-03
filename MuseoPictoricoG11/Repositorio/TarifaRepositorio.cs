using MuseoPictoricoG11.Modelos;

namespace MuseoPictoricoG11.Repositorio
{
    public class TarifaRepositorio : NhRepositorio<Tarifa>
    {
        public TarifaRepositorio() : base()
        {
        }

        public Tarifa GetTarifa(int idTarifa)
        {
            return Session.QueryOver<Tarifa>()
                .Where(x => x.Id == idTarifa)
                .SingleOrDefault<Tarifa>();
        }

        /*
        public Entrada getAllEntradas() {
            return Session.QueryOver<Entrada>();
        }*/

    }
}