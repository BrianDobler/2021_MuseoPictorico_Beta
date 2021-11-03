using MuseoPictoricoG11.Controladores;
using MuseoPictoricoG11.Modelos;
using System;
using System.Collections;
using System.Windows.Forms;

namespace MuseoPictoricoG11.Pantallas
{
    public partial class PantallaConsultaEntradas : Form
    {
        private ControlConsultaEntradas controlador;

        public PantallaConsultaEntradas(MenuV2 menuV2)
        {
            InitializeComponent();
            controlador = new ControlConsultaEntradas(this);
            consultarEntradas();
        }

        public void consultarEntradas()
        {
            controlador.consultarEntradas();
        }

        public void setDatosEntradas(ArrayList entradas)
        {
            foreach (Entrada entrada in entradas)
            {
                entrada.FechaVenta = new DateTime(entrada.FechaVenta.Year, entrada.FechaVenta.Month, entrada.FechaVenta.Day);
            }
            dtgConsultaEntradas.DataSource = entradas;
        }

        public void setCantidadDeEntradasVendidas(int cantidadDeEntradasVendidas)
        {
            lblCantidadEntradasVendidas.Text = cantidadDeEntradasVendidas.ToString();
        }

        public void setReservasVisitasConfirmadas(int cantidadDeReservasVisitasConfirmadas)
        {
            lblCountReservasVisitasConfirmadas.Text = cantidadDeReservasVisitasConfirmadas.ToString();
        }

        public void setCantidadMaximaVisitantes(int cantidadMaximaVisitantes)
        {
            lblCountMaximaVisitantes.Text = cantidadMaximaVisitantes.ToString();
        }

        public void setSedeActual(string nombreSedeActual)
        {
            lblSede.Text = lblSede.Text + nombreSedeActual;
        }
    }
}
