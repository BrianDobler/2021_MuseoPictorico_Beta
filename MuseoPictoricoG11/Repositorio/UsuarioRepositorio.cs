using MuseoPictoricoG11.Modelos;

namespace MuseoPictoricoG11.Repositorio
{
    public class UsuarioRepositorio : NhRepositorio<Usuario>
    {
        public UsuarioRepositorio() : base()
        {
        }

        public Usuario Login(string nombreUsuario, string password)
        {
            return Session.QueryOver<Usuario>()
                .Where(x => x.NombreUsuario == nombreUsuario && x.Contraseña == password)
                .SingleOrDefault<Usuario>();
        }
    }
}
