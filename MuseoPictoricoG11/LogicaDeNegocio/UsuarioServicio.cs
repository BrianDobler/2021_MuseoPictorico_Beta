using MuseoPictoricoG11.Modelos;
using MuseoPictoricoG11.Repositorio;
using System;

namespace MuseoPictoricoG11.LogicaDeNegocio
{
    public class UsuarioServicio
    {
        private UsuarioRepositorio _usuariosRepositorio;

        public static Usuario UsuarioLogueado { get; set; }

        public UsuarioServicio()
        {
            _usuariosRepositorio = new UsuarioRepositorio();
        }
        public Usuario Login(string nombreUsuario, string password)
        {

            UsuarioServicio.UsuarioLogueado = _usuariosRepositorio.Login(nombreUsuario, password);
            return UsuarioServicio.UsuarioLogueado;
        }

        public Usuario crearUsuario(string nombreUsuario, string password, DateTime caducidad)
        {
            Usuario usr = new Usuario(nombreUsuario, password, caducidad);
            return _usuariosRepositorio.Guardar(usr);
        }
        public Usuario crearUsuario(string nombreUsuario, string password, DateTime caducidad, Empleado empleado)
        {
            Usuario usr = new Usuario(nombreUsuario, password, caducidad, empleado);
            return _usuariosRepositorio.Guardar(usr);
        }

        public Usuario Guardar(Usuario usuario)
        {
            return _usuariosRepositorio.Guardar(usuario);
        }
    }
}
