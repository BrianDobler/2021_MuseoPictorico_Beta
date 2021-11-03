using MuseoPictoricoG11.Controladores;
using MuseoPictoricoG11.Modelos;
using MuseoPictoricoG11.Utils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MuseoPictoricoG11.Pantallas
{
    public partial class PantallaVentaEntradas : Form
    {
        private int cantidadEntradas;
        private ControlVentaEntradas controlador;
        private double montoPorEntrada;
        private double montoPorGuia;
        private double total;
        private Tarifa tarifaSeleccionada;
        private List<Tarifa> tarifas;

        public PantallaVentaEntradas(MenuV2 menuV2, PantallaEntrada pantallaEntrada, PantallaSala pantallaSala)
        {
            this.menuV2 = menuV2;
            this.pantallaEntrada = pantallaEntrada;
            this.pantallaSala = pantallaSala;

            InitializeComponent();  //Metodo     habilitarPantalla()
            controlador = new ControlVentaEntradas(this);
            registrarVentaEntradas();


        }
        private MenuV2 menuV2;
        public MenuV2 getMenuV2()
        {
            return (this.menuV2);
        }

        private PantallaEntrada pantallaEntrada;
        public PantallaEntrada getPantallaEntrada()
        {
            return (this.pantallaEntrada);
        }

        private PantallaSala pantallaSala;
        public PantallaSala getPantallaSala()
        {
            return (this.pantallaSala);
        }

        public void registrarVentaEntradas()
        {
            controlador.registrarVentaEntradas();
        }

        private void confirmarVenta(object sender, EventArgs e)
        {
            dtgTarifas.Enabled = true;
            txtDuracion.Enabled = true;
            txtCantidadDeEntradas.Enabled = true;
            panelDetalleEntrada.Enabled = false;
            panelDetalleEntrada.Visible = false;

            MessageBox.Show("Imprimiendo " + cantidadEntradas.ToString() + " entradas", "Informacion!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            controlador.registrarVenta(getTarifaSeleccionada());
        }

        public void pedirConfirmacionDeVenta()
        {
            txtCantidadEntradasDetalle.Text = txtCantidadDeEntradas.Text;
            txtMontoAPagar.Text = '$' + getTotal().ToString();
            txtMontoPorEntrada.Text = '$' + tarifaSeleccionada.getMonto().ToString();
            txtMontoPorGuia.Text = '$' + tarifaSeleccionada.getMontoAdicionalPorGuia().ToString();
        }

        private void setCantidadEntradas(int cantidadDeEntradas)
        {
            this.cantidadEntradas = cantidadDeEntradas;
            controlador.setCantidadEntradas(cantidadDeEntradas);
        }

        public void setDatosTarifa(Tarifa tarifaSeleccionada)
        {
            controlador.setDatosTarifas(tarifaSeleccionada);
        }

        public void setTarifas(List<Tarifa> tarifas)
        {
            this.tarifas = tarifas;
            List<_Tarifa> listTarifas = new List<_Tarifa>();
            foreach (Tarifa tarifa in tarifas)
            {
                listTarifas.Add(new _Tarifa(tarifa.getId(), tarifa.getTipoDeEntrada().getNombre(), tarifa.getTipoVisita().getNombre(), tarifa.getMonto(), tarifa.getMontoAdicionalPorGuia()));
            }
            dtgTarifas.DataSource = listTarifas;
            dtgTarifas.Columns["IdTarifa"].Visible = false;
            dtgTarifas.Columns["Visita"].HeaderCell.Value = "   Tipo De Visita";
            dtgTarifas.Columns["Entrada"].HeaderCell.Value = " Tipo De Entrada";
        }

        private void dtgTarifas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            DataGridViewColumn column = dtgTarifas.Columns[e.ColumnIndex];

            if (column.DataPropertyName.Contains("_"))
            {
                object data = dtgTarifas.Rows[e.RowIndex].DataBoundItem;
                string[] properties = column.DataPropertyName.Split('.');
                for (int i = 0; i < properties.Length && data != null; i++)
                    data = data.GetType().GetProperty(properties[i]).GetValue(data);
                dtgTarifas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = data;

            }
        }

        private void dtgTarifas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDuracion.Text = "";
            dtgTarifas.CurrentRow.Selected = true;
            _Tarifa tarifaSeleccionadaUI = (_Tarifa)dtgTarifas.SelectedRows[0].DataBoundItem;
            Tarifa tarifaSeleccionada = new Tarifa();
            foreach (Tarifa tarifa in this.tarifas)
            {
                if (tarifa.getId() == tarifaSeleccionadaUI.IdTarifa)
                {
                    tarifaSeleccionada = tarifa;
                    break;
                }
            }
            setTarifaSeleccionada(tarifaSeleccionada);
            setMontoPorGuia(tarifaSeleccionada.getMonto());
            setDatosTarifa(tarifaSeleccionada);
        }

        public void setTotal(double total)
        {
            panelDetalleEntrada.Visible = true;
            panelDetalleEntrada.Enabled = true;
            dtgTarifas.Enabled = false;
            txtDuracion.Enabled = false;
            txtCantidadDeEntradas.Enabled = false;
            this.total = total;
        }

        public double getTotal()
        {
            return this.total;
        }

        public void setSedeActual(Sede sedeActual)
        {
            lblSede.Text = lblSede.Text + sedeActual.Nombre;
        }

        public void setDuracionCompleta(int duracion)
        {
            int minutes = duracion;
            int seconds = minutes * 60;
            var duracionTxt = new Hours(seconds);
            txtDuracion.Text = duracionTxt.ToString();
        }

        private void btnSalirSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de cancelar la venta?", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                panelDetalleEntrada.Visible = false;
                dtgTarifas.Enabled = true;
                txtDuracion.Enabled = true;
                txtCantidadDeEntradas.Enabled = true;

            }
        }

        private void btnGenerar_Click_1(object sender, EventArgs e)
        {
            string cantidadDeEntradaTxt = txtCantidadDeEntradas.Text;
            if (cantidadDeEntradaTxt == "")
            {
                MessageBox.Show("Se debe ingresar una cantidad de entradas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int cantEntradas = Int32.Parse(cantidadDeEntradaTxt);
            setCantidadEntradas(cantEntradas);
        }


        private void setMontoPorEntrada(double montoSeleccionado)
        {
            this.montoPorEntrada = montoSeleccionado;
        }

        private double getMontoPorEntrada()
        {
            return this.montoPorEntrada;
        }


        private void setMontoPorGuia(double montoPorGuia)
        {
            this.montoPorGuia = montoPorGuia;
        }

        private double getMontoPorGuia()
        {
            return this.montoPorGuia;
        }

        /**
         * Muestra las entradas generadas por el controlador
         */
        private void imprimirEntradas()
        {

        }

        private void setTarifaSeleccionada(Tarifa tarifaSeleccionada)
        {
            this.tarifaSeleccionada = tarifaSeleccionada;
        }

        private Tarifa getTarifaSeleccionada()
        {
            return tarifaSeleccionada;
        }

    }
}
