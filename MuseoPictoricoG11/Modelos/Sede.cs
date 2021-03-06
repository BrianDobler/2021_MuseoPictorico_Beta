///////////////////////////////////////////////////////////
//  Sede.cs
//  Implementation of the Class Sede
//  Generated by Enterprise Architect
//  Created on:      25-jun.-2021 20:02:39
///////////////////////////////////////////////////////////



using System;
using System.Collections.Generic;

namespace MuseoPictoricoG11.Modelos
{
    class _Tarifa
    {
        public _Tarifa(int idTarifa, string tipoEntrada, string tipoVisita, double monto, double montoAdicional)
        {
            IdTarifa = idTarifa;
            Entrada = tipoEntrada;
            Visita = tipoVisita;
            Monto = monto;
            AdicionalPorGuia = montoAdicional;
        }
        public virtual int IdTarifa { get; set; }
        public virtual string Entrada { get; set; }
        public virtual string Visita { get; set; }
        public virtual double Monto { get; set; }
        public virtual double AdicionalPorGuia { get; set; }
    }
    public class Sede : Entidad
    {
        private int id;
        private int cantMaximaVisitantes;
        private string domicilio;
        private DateTime horario;
        private string nombre;
        //public Deposito m_Deposito;
        //public Coleccion m_Coleccion;
        //public Horario m_Horario;
        //public Planta m_Planta;
        public virtual IList<Exposicion> m_Exposicion { get; set; }
        public virtual IList<Tarifa> m_Tarifa { get; set; }

        public virtual int Id { get => id; set => id = value; }
        public virtual int CantMaximaVisitantes { get => cantMaximaVisitantes; set => cantMaximaVisitantes = value; }
        public virtual string Domicilio { get => domicilio; set => domicilio = value; }
        public virtual DateTime Horario { get => horario; set => horario = value; }
        public virtual string Nombre { get => nombre; set => nombre = value; }

        protected Sede()
        {

        }

        public Sede(int cantMaximaVisitantes, string domicilio, DateTime horario, string nombre)
        {
            this.cantMaximaVisitantes = cantMaximaVisitantes;
            this.domicilio = domicilio;
            this.horario = horario;
            this.nombre = nombre;
        }

        ~Sede()
        {

        }


        public virtual int getCantMaximaVisitantes()
        {
            return this.cantMaximaVisitantes;
        }

        public virtual int calcularDuracionVisitaCompleta(DateTime fecha)
        {
            int duracionVisitaCompleta = 0;
            foreach (var exposicion in m_Exposicion)
            {
                if (exposicion.esVigente(fecha))
                {
                    duracionVisitaCompleta += exposicion.calcularDuracionResumida();
                }
            }

            return duracionVisitaCompleta;
        }

        public virtual List<Tarifa> conocerTarifas(DateTime fecha)
        {
            List<Tarifa> listaTarifas = new List<Tarifa>();
            foreach (var tarifa in m_Tarifa)
            {
                if (tarifa.esVigente(fecha))
                {
                    listaTarifas.Add(tarifa);
                }
            }
            return listaTarifas;
        }

        public virtual string getNombre()
        {
            return this.nombre;
        }

        public virtual bool validarCapacidadMaxima(int cantidad)
        {
            if (cantidad <= cantMaximaVisitantes)
                return true;
            else
                return false;
        }

        public virtual int getId()
        {
            return this.id;
        }



    }

}//end Sede
