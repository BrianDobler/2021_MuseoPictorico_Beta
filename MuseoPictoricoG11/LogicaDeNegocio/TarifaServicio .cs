using MuseoPictoricoG11.Modelos;
using MuseoPictoricoG11.Repositorio;
using System.Collections.Generic;

namespace MuseoPictoricoG11.LogicaDeNegocio
{
    class TarifaServicio
    {
        private TarifaRepositorio _tarifaRepositorio;

        public TarifaServicio()
        {
            _tarifaRepositorio = new TarifaRepositorio();
        }

        // pruebas 
        public Tarifa getTarifa(int idTarifa)
        {
            return _tarifaRepositorio.GetTarifa(idTarifa);
        }

        public IList<Tarifa> getAllTarifas()
        {
            return _tarifaRepositorio.ConsultarTodos();
        }

        public void Guardar(Tarifa tarifa)
        {
            _tarifaRepositorio.Guardar(tarifa);
        }
    }
}
