using MuseoPictoricoG11.Modelos;
using MuseoPictoricoG11.Repositorio;
using System;

namespace MuseoPictoricoG11.LogicaDeNegocio
{
    public class SesionServicio
    {
        private SesionRepositorio _sesionRepositorio;

        public SesionServicio()
        {
            _sesionRepositorio = new SesionRepositorio();
        }

        public Sesion IniciarSesion(Usuario usuario)
        {
            Sesion sesion = new Sesion(usuario);
            return _sesionRepositorio.Guardar(sesion);
        }
        public Sesion CerrarSesion()
        {
            Sesion sesionActual = Sesion.GetSesion();
            sesionActual.FechaHoraFin = DateTime.Now;
            return _sesionRepositorio.Guardar(sesionActual);
        }
    }
}
