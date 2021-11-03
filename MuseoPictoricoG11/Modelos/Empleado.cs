///////////////////////////////////////////////////////////
//  Empleado.cs
//  Implementation of the Class Empleado
//  Generated by Enterprise Architect
//  Created on:      25-jun.-2021 19:58:46
//  Original author: u149459
///////////////////////////////////////////////////////////


using System;

namespace MuseoPictoricoG11.Modelos
{
    public class Empleado : Entidad
    {

        private string apellido;
        private int codigoValidacion;
        private double cuit;
        private double dni;
        private string domicilio;
        private DateTime fechaIngreso;
        private DateTime fechaNacimiento;
        private string mail;
        private string nombre;
        private bool sexo;
        private string telefono;
        //public Cargo m_Cargo;
        public virtual Sede m_Sede { get; set; }

        public virtual string Apellido { get => apellido; set => apellido = value; }
        public virtual int CodigoValidacion { get => codigoValidacion; set => codigoValidacion = value; }
        public virtual double Cuit { get => cuit; set => cuit = value; }
        public virtual double Dni { get => dni; set => dni = value; }
        public virtual string Domicilio { get => domicilio; set => domicilio = value; }
        public virtual DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public virtual DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public virtual string Mail { get => mail; set => mail = value; }
        public virtual string NombreEmpleado { get => nombre; set => nombre = value; }
        public virtual bool Sexo { get => sexo; set => sexo = value; }
        public virtual string Telefono { get => telefono; set => telefono = value; }

        protected Empleado()
        {

        }
        public Empleado(string apellido, int codigoValidacion, double cuit, double dni, string domicilio, DateTime fechaIngreso,
            DateTime fechaNacimiento, string mail, string nombre, bool sexo, string telefono)
        {
            this.apellido = apellido;
            this.codigoValidacion = codigoValidacion;
            this.cuit = cuit;
            this.dni = dni;
            this.domicilio = domicilio;
            this.fechaIngreso = fechaIngreso;
            this.fechaNacimiento = fechaNacimiento;
            this.mail = mail;
            this.nombre = nombre;
            this.sexo = sexo;
            this.telefono = telefono;
        }

        public virtual Sede conocerSede()
        {
            return m_Sede;
        }
    }
}//end Empleado