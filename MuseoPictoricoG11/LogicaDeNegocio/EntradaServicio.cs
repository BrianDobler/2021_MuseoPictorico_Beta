using MuseoPictoricoG11.Modelos;
using MuseoPictoricoG11.Repositorio;
using System.Collections.Generic;

namespace MuseoPictoricoG11.LogicaDeNegocio
{
    class EntradaServicio
    {
        private EntradaRepositorio _entradaRepositorio;

        public EntradaServicio()
        {
            _entradaRepositorio = new EntradaRepositorio();
        }

        // pruebas 
        public Entrada getEntradas(int numero)
        {
            return _entradaRepositorio.GetEntrada(numero);
        }

        public IList<Entrada> getAllEntradas()
        {
            return _entradaRepositorio.ConsultarTodos();
        }

        public void Guardar(Entrada entrada)
        {
            _entradaRepositorio.Guardar(entrada);
        }
    }
}
