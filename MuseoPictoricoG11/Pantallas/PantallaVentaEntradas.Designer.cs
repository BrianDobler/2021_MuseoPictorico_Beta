namespace MuseoPictoricoG11.Pantallas
{
    partial class PantallaVentaEntradas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaVentaEntradas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblRegVentEntr = new System.Windows.Forms.Label();
            this.lblIngreseCantidad = new System.Windows.Forms.Label();
            this.txtCantidadDeEntradas = new System.Windows.Forms.TextBox();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.panelDetalleEntrada = new System.Windows.Forms.Panel();
            this.btnconfirmarVenta = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtMontoAPagar = new System.Windows.Forms.TextBox();
            this.txtMontoPorGuia = new System.Windows.Forms.TextBox();
            this.txtMontoPorEntrada = new System.Windows.Forms.TextBox();
            this.txtCantidadEntradasDetalle = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator5 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator4 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblMontoAPagar = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSalirSesion = new System.Windows.Forms.Button();
            this.btnGenerar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblSede = new System.Windows.Forms.Label();
            this.dtgTarifas = new System.Windows.Forms.DataGridView();
            this.tarifaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelDetalleEntrada.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTarifas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarifaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRegVentEntr
            // 
            this.lblRegVentEntr.AutoSize = true;
            this.lblRegVentEntr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(98)))), ((int)(((byte)(20)))));
            this.lblRegVentEntr.Location = new System.Drawing.Point(68, 17);
            this.lblRegVentEntr.Name = "lblRegVentEntr";
            this.lblRegVentEntr.Size = new System.Drawing.Size(229, 20);
            this.lblRegVentEntr.TabIndex = 1;
            this.lblRegVentEntr.Text = "Registrar Venta de Entradas  - ";
            // 
            // lblIngreseCantidad
            // 
            this.lblIngreseCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIngreseCantidad.AutoSize = true;
            this.lblIngreseCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(98)))), ((int)(((byte)(20)))));
            this.lblIngreseCantidad.Location = new System.Drawing.Point(117, 519);
            this.lblIngreseCantidad.Name = "lblIngreseCantidad";
            this.lblIngreseCantidad.Size = new System.Drawing.Size(324, 20);
            this.lblIngreseCantidad.TabIndex = 2;
            this.lblIngreseCantidad.Text = "Ingrese la cantidad de Entradas a generar:";
            // 
            // txtCantidadDeEntradas
            // 
            this.txtCantidadDeEntradas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCantidadDeEntradas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(194)))), ((int)(((byte)(146)))));
            this.txtCantidadDeEntradas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantidadDeEntradas.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadDeEntradas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(98)))), ((int)(((byte)(20)))));
            this.txtCantidadDeEntradas.Location = new System.Drawing.Point(447, 505);
            this.txtCantidadDeEntradas.MaxLength = 3;
            this.txtCantidadDeEntradas.Name = "txtCantidadDeEntradas";
            this.txtCantidadDeEntradas.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCantidadDeEntradas.Size = new System.Drawing.Size(106, 30);
            this.txtCantidadDeEntradas.TabIndex = 3;
            // 
            // lblDuracion
            // 
            this.lblDuracion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(98)))), ((int)(((byte)(20)))));
            this.lblDuracion.Location = new System.Drawing.Point(117, 479);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(227, 20);
            this.lblDuracion.TabIndex = 36;
            this.lblDuracion.Text = "Duración de Visita Completa: ";
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(98)))), ((int)(((byte)(20)))));
            this.bunifuSeparator2.LineThickness = 65535;
            this.bunifuSeparator2.Location = new System.Drawing.Point(348, 491);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(102, 6);
            this.bunifuSeparator2.TabIndex = 37;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // txtDuracion
            // 
            this.txtDuracion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDuracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(194)))), ((int)(((byte)(146)))));
            this.txtDuracion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDuracion.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuracion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(98)))), ((int)(((byte)(20)))));
            this.txtDuracion.Location = new System.Drawing.Point(345, 465);
            this.txtDuracion.MaxLength = 8;
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDuracion.Size = new System.Drawing.Size(106, 30);
            this.txtDuracion.TabIndex = 38;
            // 
            // panelDetalleEntrada
            // 
            this.panelDetalleEntrada.Controls.Add(this.btnconfirmarVenta);
            this.panelDetalleEntrada.Controls.Add(this.txtMontoAPagar);
            this.panelDetalleEntrada.Controls.Add(this.txtMontoPorGuia);
            this.panelDetalleEntrada.Controls.Add(this.txtMontoPorEntrada);
            this.panelDetalleEntrada.Controls.Add(this.txtCantidadEntradasDetalle);
            this.panelDetalleEntrada.Controls.Add(this.panel2);
            this.panelDetalleEntrada.Controls.Add(this.panel3);
            this.panelDetalleEntrada.Controls.Add(this.bunifuSeparator3);
            this.panelDetalleEntrada.Controls.Add(this.bunifuSeparator5);
            this.panelDetalleEntrada.Controls.Add(this.bunifuSeparator4);
            this.panelDetalleEntrada.Controls.Add(this.lblMontoAPagar);
            this.panelDetalleEntrada.Controls.Add(this.label6);
            this.panelDetalleEntrada.Controls.Add(this.label2);
            this.panelDetalleEntrada.Controls.Add(this.label5);
            this.panelDetalleEntrada.Controls.Add(this.label1);
            this.panelDetalleEntrada.Controls.Add(this.label4);
            this.panelDetalleEntrada.Controls.Add(this.label3);
            this.panelDetalleEntrada.Controls.Add(this.panelTop);
            this.panelDetalleEntrada.Location = new System.Drawing.Point(132, 131);
            this.panelDetalleEntrada.Name = "panelDetalleEntrada";
            this.panelDetalleEntrada.Size = new System.Drawing.Size(408, 283);
            this.panelDetalleEntrada.TabIndex = 39;
            this.panelDetalleEntrada.Visible = false;
            // 
            // btnconfirmarVenta
            // 
            this.btnconfirmarVenta.ActiveBorderThickness = 1;
            this.btnconfirmarVenta.ActiveCornerRadius = 40;
            this.btnconfirmarVenta.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(194)))), ((int)(((byte)(146)))));
            this.btnconfirmarVenta.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(116)))), ((int)(((byte)(42)))));
            this.btnconfirmarVenta.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(116)))), ((int)(((byte)(42)))));
            this.btnconfirmarVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(194)))), ((int)(((byte)(146)))));
            this.btnconfirmarVenta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnconfirmarVenta.BackgroundImage")));
            this.btnconfirmarVenta.ButtonText = "C O N F I R M A R";
            this.btnconfirmarVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnconfirmarVenta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconfirmarVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(194)))), ((int)(((byte)(146)))));
            this.btnconfirmarVenta.IdleBorderThickness = 1;
            this.btnconfirmarVenta.IdleCornerRadius = 40;
            this.btnconfirmarVenta.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(116)))), ((int)(((byte)(42)))));
            this.btnconfirmarVenta.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(194)))), ((int)(((byte)(146)))));
            this.btnconfirmarVenta.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(194)))), ((int)(((byte)(146)))));
            this.btnconfirmarVenta.Location = new System.Drawing.Point(123, 216);
            this.btnconfirmarVenta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnconfirmarVenta.Name = "btnconfirmarVenta";
            this.btnconfirmarVenta.Size = new System.Drawing.Size(166, 54);
            this.btnconfirmarVenta.TabIndex = 59;
            this.btnconfirmarVenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnconfirmarVenta.Click += new System.EventHandler(this.confirmarVenta);
            // 
            // txtMontoAPagar
            // 
            this.txtMontoAPagar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMontoAPagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(194)))), ((int)(((byte)(146)))));
            this.txtMontoAPagar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMontoAPagar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoAPagar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(98)))), ((int)(((byte)(20)))));
            this.txtMontoAPagar.Location = new System.Drawing.Point(242, 164);
            this.txtMontoAPagar.MaxLength = 8;
            this.txtMontoAPagar.Name = "txtMontoAPagar";
            this.txtMontoAPagar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMontoAPagar.Size = new System.Drawing.Size(139, 30);
            this.txtMontoAPagar.TabIndex = 58;
            // 
            // txtMontoPorGuia
            // 
            this.txtMontoPorGuia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMontoPorGuia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(194)))), ((int)(((byte)(146)))));
            this.txtMontoPorGuia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMontoPorGuia.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoPorGuia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(98)))), ((int)(((byte)(20)))));
            this.txtMontoPorGuia.Location = new System.Drawing.Point(242, 111);
            this.txtMontoPorGuia.MaxLength = 8;
            this.txtMontoPorGuia.Name = "txtMontoPorGuia";
            this.txtMontoPorGuia.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMontoPorGuia.Size = new System.Drawing.Size(139, 30);
            this.txtMontoPorGuia.TabIndex = 57;
            // 
            // txtMontoPorEntrada
            // 
            this.txtMontoPorEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMontoPorEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(194)))), ((int)(((byte)(146)))));
            this.txtMontoPorEntrada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMontoPorEntrada.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoPorEntrada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(98)))), ((int)(((byte)(20)))));
            this.txtMontoPorEntrada.Location = new System.Drawing.Point(242, 76);
            this.txtMontoPorEntrada.MaxLength = 8;
            this.txtMontoPorEntrada.Name = "txtMontoPorEntrada";
            this.txtMontoPorEntrada.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMontoPorEntrada.Size = new System.Drawing.Size(139, 30);
            this.txtMontoPorEntrada.TabIndex = 54;
            // 
            // txtCantidadEntradasDetalle
            // 
            this.txtCantidadEntradasDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCantidadEntradasDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(194)))), ((int)(((byte)(146)))));
            this.txtCantidadEntradasDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantidadEntradasDetalle.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadEntradasDetalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(98)))), ((int)(((byte)(20)))));
            this.txtCantidadEntradasDetalle.Location = new System.Drawing.Point(242, 38);
            this.txtCantidadEntradasDetalle.MaxLength = 8;
            this.txtCantidadEntradasDetalle.Name = "txtCantidadEntradasDetalle";
            this.txtCantidadEntradasDetalle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCantidadEntradasDetalle.Size = new System.Drawing.Size(141, 30);
            this.txtCantidadEntradasDetalle.TabIndex = 53;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(123)))), ((int)(((byte)(45)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.MinimumSize = new System.Drawing.Size(4, 275);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(4, 275);
            this.panel2.TabIndex = 52;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(123)))), ((int)(((byte)(45)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(404, 35);
            this.panel3.MinimumSize = new System.Drawing.Size(4, 275);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(4, 275);
            this.panel3.TabIndex = 51;
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuSeparator3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(123)))), ((int)(((byte)(45)))));
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(123)))), ((int)(((byte)(45)))));
            this.bunifuSeparator3.LineThickness = 4;
            this.bunifuSeparator3.Location = new System.Drawing.Point(-11, 276);
            this.bunifuSeparator3.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(444, 11);
            this.bunifuSeparator3.TabIndex = 50;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = false;
            // 
            // bunifuSeparator5
            // 
            this.bunifuSeparator5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSeparator5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuSeparator5.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(98)))), ((int)(((byte)(20)))));
            this.bunifuSeparator5.LineThickness = 2;
            this.bunifuSeparator5.Location = new System.Drawing.Point(25, 198);
            this.bunifuSeparator5.Margin = new System.Windows.Forms.Padding(14, 18, 14, 18);
            this.bunifuSeparator5.Name = "bunifuSeparator5";
            this.bunifuSeparator5.Size = new System.Drawing.Size(356, 15);
            this.bunifuSeparator5.TabIndex = 48;
            this.bunifuSeparator5.Transparency = 255;
            this.bunifuSeparator5.Vertical = false;
            // 
            // bunifuSeparator4
            // 
            this.bunifuSeparator4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSeparator4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(98)))), ((int)(((byte)(20)))));
            this.bunifuSeparator4.LineThickness = 2;
            this.bunifuSeparator4.Location = new System.Drawing.Point(25, 151);
            this.bunifuSeparator4.Margin = new System.Windows.Forms.Padding(10, 14, 10, 14);
            this.bunifuSeparator4.Name = "bunifuSeparator4";
            this.bunifuSeparator4.Size = new System.Drawing.Size(356, 9);
            this.bunifuSeparator4.TabIndex = 47;
            this.bunifuSeparator4.Transparency = 255;
            this.bunifuSeparator4.Vertical = false;
            // 
            // lblMontoAPagar
            // 
            this.lblMontoAPagar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMontoAPagar.AutoSize = true;
            this.lblMontoAPagar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoAPagar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(98)))), ((int)(((byte)(20)))));
            this.lblMontoAPagar.Location = new System.Drawing.Point(39, 169);
            this.lblMontoAPagar.Name = "lblMontoAPagar";
            this.lblMontoAPagar.Size = new System.Drawing.Size(136, 21);
            this.lblMontoAPagar.TabIndex = 46;
            this.lblMontoAPagar.Text = "Monto a Pagar: ";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(98)))), ((int)(((byte)(20)))));
            this.label6.Location = new System.Drawing.Point(39, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 21);
            this.label6.TabIndex = 44;
            this.label6.Text = "Monto por Guía: ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(98)))), ((int)(((byte)(20)))));
            this.label2.Location = new System.Drawing.Point(39, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 21);
            this.label2.TabIndex = 45;
            this.label2.Text = "Monto por Guía: ";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(98)))), ((int)(((byte)(20)))));
            this.label5.Location = new System.Drawing.Point(39, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 21);
            this.label5.TabIndex = 42;
            this.label5.Text = "Monto por Entrada: ";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(98)))), ((int)(((byte)(20)))));
            this.label1.Location = new System.Drawing.Point(39, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 21);
            this.label1.TabIndex = 43;
            this.label1.Text = "Monto por Entrada: ";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(98)))), ((int)(((byte)(20)))));
            this.label4.Location = new System.Drawing.Point(39, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 21);
            this.label4.TabIndex = 40;
            this.label4.Text = "Cantidad de Entradas: ";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(98)))), ((int)(((byte)(20)))));
            this.label3.Location = new System.Drawing.Point(39, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 21);
            this.label3.TabIndex = 41;
            this.label3.Text = "Cantidad de Entradas: ";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(123)))), ((int)(((byte)(45)))));
            this.panelTop.Controls.Add(this.label7);
            this.panelTop.Controls.Add(this.btnSalirSesion);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(408, 35);
            this.panelTop.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(194)))), ((int)(((byte)(146)))));
            this.label7.Location = new System.Drawing.Point(128, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 19);
            this.label7.TabIndex = 47;
            this.label7.Text = "Detalle de Entradas";
            // 
            // btnSalirSesion
            // 
            this.btnSalirSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(123)))), ((int)(((byte)(45)))));
            this.btnSalirSesion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalirSesion.BackgroundImage")));
            this.btnSalirSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalirSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalirSesion.FlatAppearance.BorderSize = 0;
            this.btnSalirSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSalirSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(123)))), ((int)(((byte)(45)))));
            this.btnSalirSesion.Location = new System.Drawing.Point(371, -3);
            this.btnSalirSesion.Name = "btnSalirSesion";
            this.btnSalirSesion.Size = new System.Drawing.Size(40, 40);
            this.btnSalirSesion.TabIndex = 46;
            this.btnSalirSesion.UseVisualStyleBackColor = false;
            this.btnSalirSesion.Click += new System.EventHandler(this.btnSalirSesion_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.ActiveBorderThickness = 1;
            this.btnGenerar.ActiveCornerRadius = 40;
            this.btnGenerar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(194)))), ((int)(((byte)(146)))));
            this.btnGenerar.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(116)))), ((int)(((byte)(42)))));
            this.btnGenerar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(116)))), ((int)(((byte)(42)))));
            this.btnGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(194)))), ((int)(((byte)(146)))));
            this.btnGenerar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGenerar.BackgroundImage")));
            this.btnGenerar.ButtonText = " G E N E R A R";
            this.btnGenerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(194)))), ((int)(((byte)(146)))));
            this.btnGenerar.IdleBorderThickness = 1;
            this.btnGenerar.IdleCornerRadius = 40;
            this.btnGenerar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(116)))), ((int)(((byte)(42)))));
            this.btnGenerar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(194)))), ((int)(((byte)(146)))));
            this.btnGenerar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(194)))), ((int)(((byte)(146)))));
            this.btnGenerar.Location = new System.Drawing.Point(254, 549);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(166, 54);
            this.btnGenerar.TabIndex = 60;
            this.btnGenerar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click_1);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(98)))), ((int)(((byte)(20)))));
            this.bunifuSeparator1.LineThickness = 65535;
            this.bunifuSeparator1.Location = new System.Drawing.Point(447, 540);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(106, 2);
            this.bunifuSeparator1.TabIndex = 62;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // lblSede
            // 
            this.lblSede.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSede.AutoSize = true;
            this.lblSede.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(98)))), ((int)(((byte)(20)))));
            this.lblSede.Location = new System.Drawing.Point(293, 17);
            this.lblSede.Name = "lblSede";
            this.lblSede.Size = new System.Drawing.Size(50, 20);
            this.lblSede.TabIndex = 63;
            this.lblSede.Text = "Sede:";
            // 
            // dtgTarifas
            // 
            this.dtgTarifas.AllowUserToAddRows = false;
            this.dtgTarifas.AllowUserToDeleteRows = false;
            this.dtgTarifas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgTarifas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgTarifas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(214)))), ((int)(((byte)(182)))));
            this.dtgTarifas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dtgTarifas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(123)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(194)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(123)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(194)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgTarifas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgTarifas.ColumnHeadersHeight = 29;
            this.dtgTarifas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(123)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(194)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(123)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(194)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgTarifas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgTarifas.EnableHeadersVisualStyles = false;
            this.dtgTarifas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(123)))), ((int)(((byte)(45)))));
            this.dtgTarifas.Location = new System.Drawing.Point(68, 50);
            this.dtgTarifas.MultiSelect = false;
            this.dtgTarifas.Name = "dtgTarifas";
            this.dtgTarifas.ReadOnly = true;
            this.dtgTarifas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(123)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(194)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(123)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(194)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgTarifas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgTarifas.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(221)))), ((int)(((byte)(194)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(98)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(123)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(221)))), ((int)(((byte)(194)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgTarifas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgTarifas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgTarifas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgTarifas.Size = new System.Drawing.Size(534, 409);
            this.dtgTarifas.TabIndex = 61;
            this.dtgTarifas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgTarifas_CellClick);
            this.dtgTarifas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgTarifas_CellFormatting);
            // 
            // tarifaBindingSource
            // 
            this.tarifaBindingSource.DataSource = typeof(MuseoPictoricoG11.Modelos.Tarifa);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this.panelDetalleEntrada;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this;
            // 
            // PantallaVentaEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(194)))), ((int)(((byte)(146)))));
            this.ClientSize = new System.Drawing.Size(671, 614);
            this.Controls.Add(this.lblSede);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.panelDetalleEntrada);
            this.Controls.Add(this.txtDuracion);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.lblDuracion);
            this.Controls.Add(this.txtCantidadDeEntradas);
            this.Controls.Add(this.lblIngreseCantidad);
            this.Controls.Add(this.lblRegVentEntr);
            this.Controls.Add(this.dtgTarifas);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PantallaVentaEntradas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PantallaVentaEntradas";
            this.panelDetalleEntrada.ResumeLayout(false);
            this.panelDetalleEntrada.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTarifas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarifaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblRegVentEntr;
        private System.Windows.Forms.Label lblIngreseCantidad;
        private System.Windows.Forms.TextBox txtCantidadDeEntradas;
        private System.Windows.Forms.Label lblDuracion;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.Panel panelDetalleEntrada;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalirSesion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblMontoAPagar;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator5;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator4;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtMontoPorGuia;
        private System.Windows.Forms.TextBox txtMontoPorEntrada;
        private System.Windows.Forms.TextBox txtCantidadEntradasDetalle;
        private System.Windows.Forms.TextBox txtMontoAPagar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnconfirmarVenta;
        private Bunifu.Framework.UI.BunifuThinButton2 btnGenerar;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label lblSede;
        private System.Windows.Forms.DataGridView dtgTarifas;
        private System.Windows.Forms.DataGridViewTextBoxColumn mTipoVisitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tarifaBindingSource;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
    }
}