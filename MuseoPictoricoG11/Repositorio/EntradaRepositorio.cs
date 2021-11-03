using MuseoPictoricoG11.Modelos;

namespace MuseoPictoricoG11.Repositorio
{
    public class EntradaRepositorio : NhRepositorio<Entrada>
    {
        public EntradaRepositorio() : base()
        {
        }

        public Entrada GetEntrada(int numero)
        {
            return Session.QueryOver<Entrada>()
                .Where(x => x.Numero == numero)
                .SingleOrDefault<Entrada>();
        }

        /*
        public Entrada getAllEntradas() {
            return Session.QueryOver<Entrada>();
        }*/

    }
}