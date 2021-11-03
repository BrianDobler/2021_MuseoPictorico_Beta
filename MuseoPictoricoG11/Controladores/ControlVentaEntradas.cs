using MuseoPictoricoG11.LogicaDeNegocio;
using MuseoPictoricoG11.Modelos;
using MuseoPictoricoG11.Pantallas;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MuseoPictoricoG11.Controladores
{

    public class ControlVentaEntradas : ISujetoOcupacionSede
    {
        private int cantidadEntradas;
        private bool conGuia;
        private int duracionResumida;
        private DateTime fechaActual;
        private double montoAdicionalPorguia;
        private double monto;
        private Sede actual;
        private int tipoEntrada;
        private String tiposDeEntrada;
        private String tiposDeVisita;
        private String tipoVisitaSeleccionada;
        private Sesion sesionActual;
        private List<Tarifa> tarifas;
        private ReservaVisita reservaVisita;
        private PantallaVentaEntradas pantalla;
        private EntradaServicio _entradaServicio;
        private ReservaVisitaServicio _reservaVisitaServicio;

        private int cantidadVisitantes;
        private int capacidadSede;
        private List<IObservadorOcupacionSede> observadores = new List<IObservadorOcupacionSede>();

        public ControlVentaEntradas(PantallaVentaEntradas pantalla)
        {
            this.pantalla = pantalla;
            _entradaServicio = new EntradaServicio();
            _reservaVisitaServicio = new ReservaVisitaServicio();

        }

        public void registrarVentaEntradas()
        {

            this.observadores.Add(pantalla.getPantallaEntrada());
            this.observadores.Add(pantalla.getPantallaSala());
            this.observadores.Add(pantalla.getMenuV2());

            fechaActual = getFechaHoraActual();
            actual = buscarSedeActual();
            this.capacidadSede = actual.getCantMaximaVisitantes();
            this.cantidadVisitantes = this.obtenerCantidadVisitantes();
            
            actualizarCantidadDeVisitantes();
            pantalla.setSedeActual(actual);
            tarifas = buscarTarifas(fechaActual);
            pantalla.setTarifas(tarifas);

        }





        private int obtenerCantidadVisitantes()
        {
            return this.getCantidadEntradasVendidas() + this.getCantidadReservas();
        }


        private int getCantidadReservas()
        {
            IList<ReservaVisita> reservasVisitas = _reservaVisitaServicio.getAllReservaVisita();
            int cantidadReservasTotales = 0;
            foreach (ReservaVisita reservaVisita in reservasVisitas)
            {
                if (reservaVisita.sosDeSede(actual) && reservaVisita.sosDeFecha(fechaActual)) cantidadReservasTotales += reservaVisita.getCantidadAlumnosConfirmados();
            }
            return cantidadReservasTotales;
        }

        private int getCantidadEntradasVendidas() 
        {

            IList<Entrada> entradas = _entradaServicio.getAllEntradas();
            int cantidadEntradasTotales = 0;
            foreach (Entrada entrada in entradas)
            {
                if (entrada.sosDeSede(actual) && entrada.sosDeFecha(fechaActual)) cantidadEntradasTotales++;
            }
            return cantidadEntradasTotales;

        }




        private DateTime getFechaHoraActual()
        {
            return DateTime.Now;
        }

        private Sede buscarSedeActual()
        {
            return Sesion.GetSesion().getSedeDelUsuario();
        }

        private List<Tarifa> buscarTarifas(DateTime fechaActual)
        {
            return actual.conocerTarifas(fechaActual);
        }

        public void setDatosTarifas(Tarifa tarifaSeleccionada)
        {
            setMonto(tarifaSeleccionada.getMonto());
            setMontoAdicionalPorGuia(tarifaSeleccionada.getMontoAdicionalPorGuia()); ;
            calcularDuracion(tarifaSeleccionada);
        }

        private void calcularDuracion(Tarifa tarifaSeleccionada)
        {
            if (tarifaSeleccionada.getTipoVisita().getNombre().Equals("Completa"))
                pantalla.setDuracionCompleta(actual.calcularDuracionVisitaCompleta(fechaActual));
        }

        private void calcularYValidarLimite(int cantidadDeEntradas)
        {
            IList<Entrada> entradas = _entradaServicio.getAllEntradas();
            int cantidadEntradasTotales = 0;
            foreach (Entrada entrada in entradas)
            {
                if (entrada.sosDeSede(actual) && entrada.sosDeFecha(fechaActual)) cantidadEntradasTotales++;
            }

            IList<ReservaVisita> reservasVisitas = _reservaVisitaServicio.getAllReservaVisita();
            int cantidadReservasTotales = 0;
            foreach (ReservaVisita reservaVisita in reservasVisitas)
            {
                if (reservaVisita.sosDeSede(actual) && reservaVisita.sosDeFecha(fechaActual)) cantidadReservasTotales += reservaVisita.getCantidadAlumnosConfirmados();
            }

            int cantidadTotal = cantidadEntradasTotales + cantidadReservasTotales + cantidadDeEntradas;

            /// Set cantidad de Visitas
            ////this.cantidadVisitantes = cantidadEntradasTotales + cantidadReservasTotales;

            int entradasDisponibles = actual.CantMaximaVisitantes - (cantidadEntradasTotales + cantidadReservasTotales);
            if (!actual.validarCapacidadMaxima(cantidadTotal))
            {

                MessageBox.Show("La cantidad de entradas ingresadas, supera a la capacidad de entradas disponibles para esta Sede. \n\n Entradas disponibles: " + entradasDisponibles.ToString(), "Alerta!");
            }
            else
            {
                calcularTotal();
            }

        }

        private void calcularTotal()
        {
            double montoTotalEntradasYAdicional = (this.cantidadEntradas * getMonto()) + getMontoAdicionalPorguia();
            pantalla.setTotal(montoTotalEntradasYAdicional);
            pantalla.pedirConfirmacionDeVenta();
        }

        public void registrarVenta(Tarifa tarifaSeleccionada)
        {
            int cantidadDeEntradasACrear = getCantidadEntradas();
            for (int i = 0; i < cantidadDeEntradasACrear; i++)
            {
                int ultimoNumero = calcularUltimoNumero();
                registrarEntrada(ultimoNumero + 1, tarifaSeleccionada);
            }

            imprimirEntrada();
            actualizarCantidadDeVisitantes();

        }

        private int calcularUltimoNumero()
        {
            var entradas = _entradaServicio.getAllEntradas();
            int ultimoNumero = 0;
            foreach (var entrada in entradas)
            {
                if (entrada.sosDeSede(actual) && entrada.getNumero() > ultimoNumero)
                {
                    ultimoNumero = entrada.getNumero();
                }

            }
            return ultimoNumero;
        }

        public void registrarEntrada(int numeroDeEntrada, Tarifa tarifaSeleccionada)
        {
            Entrada nuevaEntrada = new Entrada(actual, tarifaSeleccionada, fechaActual, getMonto(), numeroDeEntrada);
            try
            {
                _entradaServicio.Guardar(nuevaEntrada);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Se ha producido un error al intentar guardar la entrada nro:" + numeroDeEntrada.ToString() + " mensaje de error: " + exception.Message, "Alerta!");
            }
        }

        public void imprimirEntrada()
        {
            new ImpresorEntradas().ShowDialog();
        }

        public void setMonto(double monto)
        {
            this.monto = monto;
        }

        public double getMonto()
        {
            return this.monto;
        }

        public void setMontoAdicionalPorGuia(double montoAdicional)
        {
            montoAdicionalPorguia = montoAdicional;
        }

        public double getMontoAdicionalPorguia()
        {
            return montoAdicionalPorguia;
        }

        public void setCantidadEntradas(int cantEntradas)
        {
            cantidadEntradas = cantEntradas;
            calcularYValidarLimite(cantEntradas);
        }

        public int getCantidadEntradas()
        {
            return cantidadEntradas;
        }





        //////////////////////////////////////////////////////////////////////////////////////          

        public void actualizarCantidadDeVisitantes()
        {
            foreach (IObservadorOcupacionSede observador in this.observadores)
            {
                suscribir(observador);
            }

            notificar();
        }

        // implementacion ISujeto        

        public void desuscribir(IObservadorOcupacionSede observador)
        {
            this.observadores.Remove(observador);
        }

        public void suscribir(IObservadorOcupacionSede observador)
        {
            if (!this.observadores.Exists(e => e == observador))
            {
                this.observadores.Add(observador);
            }
        }

        public void notificar()
        {
            ////this.capacidadSede = actual.getCantMaximaVisitantes();
            this.cantidadVisitantes = obtenerCantidadVisitantes();

            DateTime fechaHoraActual = this.getFechaHoraActual();
            foreach (IObservadorOcupacionSede observador in this.observadores)
            {
                observador.actualizarCantidadVisitantes(fechaHoraActual, this.cantidadVisitantes, this.capacidadSede);
            }
        }
    }

}

