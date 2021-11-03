using MuseoPictoricoG11.LogicaDeNegocio;
using MuseoPictoricoG11.Modelos;
using MuseoPictoricoG11.Pantallas;
using System;
using System.Collections;
using System.Collections.Generic;

namespace MuseoPictoricoG11.Controladores
{

    public class ControlConsultaEntradas
    {

        private PantallaConsultaEntradas pantalla;
        private Sede sedeActual;
        private IList<Entrada> entradas;
        private IList<ReservaVisita> reservas;
        private EntradaServicio _entradaServicio;
        private ReservaVisitaServicio _reservaVisitaServicio;
        public ControlConsultaEntradas(PantallaConsultaEntradas pantalla)
        {
            this.pantalla = pantalla;
        }

        public void consultarEntradas()
        {
            DateTime fechaActual = DateTime.Now;
            sedeActual = buscarSedeActual();
            _entradaServicio = new EntradaServicio();
            entradas = _entradaServicio.getAllEntradas();

            _reservaVisitaServicio = new ReservaVisitaServicio();
            reservas = _reservaVisitaServicio.getAllReservaVisita();

            ArrayList listEntradas = new ArrayList();
            if (entradas.Count > 0)
            {
                foreach (var entrada in entradas)
                {
                    if (entrada.sosDeFecha(fechaActual)) listEntradas.Add(entrada);
                }
            }

            int cantidadReservasVisitasConfirmadas = 0;
            if (reservas.Count > 0)
            {
                foreach (var reserva in reservas)
                {
                    if (reserva.sosDeFecha(fechaActual)) cantidadReservasVisitasConfirmadas += reserva.getCantidadAlumnosConfirmados();
                }
            }

            pantalla.setDatosEntradas(listEntradas);
            pantalla.setCantidadDeEntradasVendidas(listEntradas.Count);
            pantalla.setReservasVisitasConfirmadas(cantidadReservasVisitasConfirmadas);
            pantalla.setCantidadMaximaVisitantes(sedeActual.CantMaximaVisitantes);
            pantalla.setSedeActual(sedeActual.Nombre);

        }

        private Sede buscarSedeActual()
        {
            return Sesion.GetSesion().getSedeDelUsuario();
        }

    }



}