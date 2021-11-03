///////////////////////////////////////////////////////////
//  Sesion.cs
//  Implementation of the Class Sesion
//  Generated by Enterprise Architect
//  Created on:      25-jun.-2021 19:35:32
///////////////////////////////////////////////////////////




using System;

namespace MuseoPictoricoG11.Modelos
{
    public class Sesion : Entidad
    {

        protected Sesion()
        {
            fechaHoraInicio = DateTime.Now;
        }
        public Sesion(Usuario usuario) : this()
        {
            this.m_Usuario = usuario;
            estaSesion = this;
        }
        private static Sesion estaSesion;
        private DateTime fechaHoraFin;
        private DateTime fechaHoraInicio;
        public virtual Usuario m_Usuario { get; set; }

        public virtual DateTime FechaHoraFin { get => fechaHoraFin; set => fechaHoraFin = value; }
        public virtual DateTime FechaHoraInicio { get => fechaHoraInicio; set => fechaHoraInicio = value; }

        public static Sesion GetSesion()
        {
            if (estaSesion == null)
            {
                //Para el caso que no haya una sesi�n activa, se crea una nueva sesion.
                estaSesion = new Sesion();
            }
            return estaSesion;
        }
        public virtual void conocerUsuario()
        {

        }

        public virtual Sede getSedeDelUsuario()
        {
            return m_Usuario.getSedeDelEmpleado();
        }
    }

}//end Sesion