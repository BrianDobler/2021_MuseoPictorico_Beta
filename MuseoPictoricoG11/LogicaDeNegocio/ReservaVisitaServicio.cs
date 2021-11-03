using MuseoPictoricoG11.Modelos;
using MuseoPictoricoG11.Repositorio;
using System.Collections.Generic;

namespace MuseoPictoricoG11.LogicaDeNegocio
{
    class ReservaVisitaServicio
    {
        private ReservaVisitaRepositorio _reservaVisitaRepositorio;

        public ReservaVisitaServicio()
        {
            _reservaVisitaRepositorio = new ReservaVisitaRepositorio();
        }

        public IList<ReservaVisita> getAllReservaVisita()
        {
            return _reservaVisitaRepositorio.ConsultarTodos();
        }
    }
}
