using System;

namespace MuseoPictoricoG11.Modelos
{
    public class Usuario : Entidad
    {
        protected Usuario()
        {
        }
        public Usuario(string nombreUsuario, string password, DateTime caducidad)
        {
            nombre = nombreUsuario;
            contraseña = password;
            this.caducidad = caducidad;
        }
        //public Usuario(string nombreUsuario, string password, DateTime caducidad, int idEmpleado) : this(nombreUsuario, password, caducidad)
        //{
        //    m_Empleado = new Empleado() { Id = idEmpleado };
        //}
        public Usuario(string nombreUsuario, string password, DateTime caducidad, Empleado empleado) : this(nombreUsuario, password, caducidad)
        {
            m_Empleado = empleado;
        }

        private DateTime caducidad;
        private string contraseña;
        private string nombre;
        public virtual Empleado m_Empleado { get; set; }


        public virtual DateTime Caducidad { get => caducidad; set => caducidad = value; }
        public virtual string Contraseña { get => contraseña; set => contraseña = value; }
        public virtual string NombreUsuario { get => nombre; set => nombre = value; }
        public virtual Empleado conocerEmpleado()
        {

            return null;
        }

        public virtual Sede getSedeDelEmpleado()
        {
            return m_Empleado.conocerSede();
        }
    }
}
