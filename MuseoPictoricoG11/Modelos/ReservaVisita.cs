///////////////////////////////////////////////////////////
//  ReservaVisita.cs
//  Implementation of the Class ReservaVisita
//  Generated by Enterprise Architect
//  Created on:      26-jun.-2021 19:25:37
//  Original author: u149459
///////////////////////////////////////////////////////////


using System;

namespace MuseoPictoricoG11.Modelos
{


    public class ReservaVisita : Entidad
    {

        private int cantidadAlumnos;
        private int cantidadAlumnosConfirmada;
        private int duracionEstimada;
        private DateTime fechaHoraCreacion;
        private DateTime fechaHoraReserva;
        private DateTime horaFinReal;
        private DateTime horaInicioReal;
        private int numeroReserva;
        public virtual Empleado m_Empleado { get; set; }
        //public AsignacionVisita m_AsignacionVisita;
        public virtual Sede m_Sede { get; set; }
        public virtual int CantidadAlumnos { get => cantidadAlumnos; set => cantidadAlumnos = value; }
        public virtual int CantidadAlumnosConfirmada { get => cantidadAlumnosConfirmada; set => cantidadAlumnosConfirmada = value; }
        public virtual int DuracionEstimada { get => duracionEstimada; set => duracionEstimada = value; }
        public virtual DateTime FechaHoraCreacion { get => fechaHoraCreacion; set => fechaHoraCreacion = value; }
        public virtual DateTime FechaHoraReserva { get => fechaHoraReserva; set => fechaHoraReserva = value; }
        public virtual DateTime HoraFinReal { get => horaFinReal; set => horaFinReal = value; }
        public virtual DateTime HoraInicioReal { get => horaInicioReal; set => horaInicioReal = value; }
        public virtual int NumeroReserva { get => numeroReserva; set => numeroReserva = value; }

        public ReservaVisita()
        {

        }

        ~ReservaVisita()
        {

        }

        public virtual int getCantidadAlumnosConfirmados()
        {

            return cantidadAlumnosConfirmada;
        }

        /// 
        /// <param name="fecha"></param>
        public virtual bool sosDeFecha(DateTime fecha)
        {
            DateTime dtFechaHoraReserva = new DateTime(fechaHoraReserva.Year, fechaHoraReserva.Month, fechaHoraReserva.Day);
            DateTime dtFechaActual = new DateTime(fecha.Year, fecha.Month, fecha.Day);
            return (dtFechaHoraReserva == dtFechaActual) ? true : false;
        }

        public virtual bool sosDeSede(Sede sede)
        {
            return (m_Sede.Id == sede.Id) ? true : false;
        }
    }
}//end ReservaVisita