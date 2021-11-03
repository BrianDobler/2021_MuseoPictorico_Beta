namespace MuseoPictoricoG11.Pantallas
{
    partial class PantallaConsultaEntradas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaConsultaEntradas));
            this.lblRegVentEntr = new System.Windows.Forms.Label();
            this.dtgConsultaEntradas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCantidadEntradasVendidas = new System.Windows.Forms.Label();
            this.lblCantidadReservasVisitasConfirmadas = new System.Windows.Forms.Label();
            this.lblCountReservasVisitasConfirmadas = new System.Windows.Forms.Label();
            this.lblCantidadMaximaVisitantesDeSede = new System.Windows.Forms.Label();
            this.lblCountMaximaVisitantes = new System.Windows.Forms.Label();
            this.lblSede = new System.Windows.Forms.Label();
            this.fechaVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entradaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultaEntradas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRegVentEntr
            // 
            this.lblRegVentEntr.AutoSize = true;
            this.lblRegVentEntr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(98)))), ((int)(((byte)(20)))));
            this.lblRegVentEntr.Location = new System.Drawing.Point(76, 16);
            this.lblRegVentEntr.Name = "lblRegVentEntr";
            this.lblRegVentEntr.Size = new System.Drawing.Size(235, 20);
            this.lblRegVentEntr.TabIndex = 64;
            this.lblRegVentEntr.Text = "Consultar Venta de Entradas  - ";
            // 
            // dtgConsultaEntradas
            // 
            this.dtgConsultaEntradas.AllowUserToAddRows = false;
            this.dtgConsultaEntradas.AutoGenerateColumns = false;
            this.dtgConsultaEntradas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgConsultaEntradas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgConsultaEntradas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(214)))), ((int)(((byte)(182)))));
            this.dtgConsultaEntradas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dtgConsultaEntradas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(123)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(194)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(123)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(194)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgConsultaEntradas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgConsultaEntradas.ColumnHeadersHeight = 29;
            this.dtgConsultaEntradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgConsultaEntradas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechaVentaDataGridViewTextBoxColumn,
            this.horaVentaDataGridViewTextBoxColumn,
            this.montoDataGridViewTextBoxColumn,
            this.numeroDataGridViewTextBoxColumn});
            this.dtgConsultaEntradas.DataSource = this.entradaBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(123)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(194)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(123)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(194)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgConsultaEntradas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgConsultaEntradas.EnableHeadersVisualStyles = false;
            this.dtgConsultaEntradas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(123)))), ((int)(((byte)(45)))));
            this.dtgConsultaEntradas.Location = new System.Drawing.Point(80, 50);
            this.dtgConsultaEntradas.MultiSelect = false;
            this.dtgConsultaEntradas.Name = "dtgConsultaEntradas";
            this.dtgConsultaEntradas.ReadOnly = true;
            this.dtgConsultaEntradas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(123)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(194)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(123)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(194)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgConsultaEntradas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgConsultaEntradas.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(221)))), ((int)(((byte)(194)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(98)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(123)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(221)))), ((int)(((byte)(194)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgConsultaEntradas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgConsultaEntradas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgConsultaEntradas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgConsultaEntradas.Size = new System.Drawing.Size(509, 409);
            this.dtgConsultaEntradas.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(98)))), ((int)(((byte)(20)))));
            this.label1.Location = new System.Drawing.Point(76, 492);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 67;
            this.label1.Text = "Entradas Vendidas:";
            // 
            // lblCantidadEntradasVendidas
            // 
            this.lblCantidadEntradasVendidas.AutoSize = true;
            this.lblCantidadEntradasVendidas.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadEntradasVendidas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(98)))), ((int)(((byte)(20)))));
            this.lblCantidadEntradasVendidas.Location = new System.Drawing.Point(231, 485);
            this.lblCantidadEntradasVendidas.Name = "lblCantidadEntradasVendidas";
            this.lblCantidadEntradasVendidas.Size = new System.Drawing.Size(0, 30);
            this.lblCantidadEntradasVendidas.TabIndex = 68;
            // 
            // lblCantidadReservasVisitasConfirmadas
            // 
            this.lblCantidadReservasVisitasConfirmadas.AutoSize = true;
            this.lblCantidadReservasVisitasConfirmadas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(98)))), ((int)(((byte)(20)))));
            this.lblCantidadReservasVisitasConfirmadas.Location = new System.Drawing.Point(76, 530);
            this.lblCantidadReservasVisitasConfirmadas.Name = "lblCantidadReservasVisitasConfirmadas";
            this.lblCantidadReservasVisitasConfirmadas.Size = new System.Drawing.Size(224, 20);
            this.lblCantidadReservasVisitasConfirmadas.TabIndex = 69;
            this.lblCantidadReservasVisitasConfirmadas.Text = "Reservas Visitas Confirmadas:";
            // 
            // lblCountReservasVisitasConfirmadas
            // 
            this.lblCountReservasVisitasConfirmadas.AutoSize = true;
            this.lblCountReservasVisitasConfirmadas.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountReservasVisitasConfirmadas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(98)))), ((int)(((byte)(20)))));
            this.lblCountReservasVisitasConfirmadas.Location = new System.Drawing.Point(307, 523);
            this.lblCountReservasVisitasConfirmadas.Name = "lblCountReservasVisitasConfirmadas";
            this.lblCountReservasVisitasConfirmadas.Size = new System.Drawing.Size(0, 30);
            this.lblCountReservasVisitasConfirmadas.TabIndex = 70;
            // 
            // lblCantidadMaximaVisitantesDeSede
            // 
            this.lblCantidadMaximaVisitantesDeSede.AutoSize = true;
            this.lblCantidadMaximaVisitantesDeSede.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(98)))), ((int)(((byte)(20)))));
            this.lblCantidadMaximaVisitantesDeSede.Location = new System.Drawing.Point(76, 568);
            this.lblCantidadMaximaVisitantesDeSede.Name = "lblCantidadMaximaVisitantesDeSede";
            this.lblCantidadMaximaVisitantesDeSede.Size = new System.Drawing.Size(281, 20);
            this.lblCantidadMaximaVisitantesDeSede.TabIndex = 71;
            this.lblCantidadMaximaVisitantesDeSede.Text = "Cantidad Máxima Visitantes de Sede:";
            // 
            // lblCountMaximaVisitantes
            // 
            this.lblCountMaximaVisitantes.AutoSize = true;
            this.lblCountMaximaVisitantes.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountMaximaVisitantes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(98)))), ((int)(((byte)(20)))));
            this.lblCountMaximaVisitantes.Location = new System.Drawing.Point(360, 561);
            this.lblCountMaximaVisitantes.Name = "lblCountMaximaVisitantes";
            this.lblCountMaximaVisitantes.Size = new System.Drawing.Size(0, 30);
            this.lblCountMaximaVisitantes.TabIndex = 72;
            // 
            // lblSede
            // 
            this.lblSede.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSede.AutoSize = true;
            this.lblSede.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(98)))), ((int)(((byte)(20)))));
            this.lblSede.Location = new System.Drawing.Point(307, 16);
            this.lblSede.Name = "lblSede";
            this.lblSede.Size = new System.Drawing.Size(50, 20);
            this.lblSede.TabIndex = 73;
            this.lblSede.Text = "Sede:";
            // 
            // fechaVentaDataGridViewTextBoxColumn
            // 
            this.fechaVentaDataGridViewTextBoxColumn.DataPropertyName = "FechaVenta";
            this.fechaVentaDataGridViewTextBoxColumn.HeaderText = "Fecha Venta";
            this.fechaVentaDataGridViewTextBoxColumn.Name = "fechaVentaDataGridViewTextBoxColumn";
            this.fechaVentaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaVentaDataGridViewTextBoxColumn.Width = 128;
            // 
            // horaVentaDataGridViewTextBoxColumn
            // 
            this.horaVentaDataGridViewTextBoxColumn.DataPropertyName = "HoraVenta";
            this.horaVentaDataGridViewTextBoxColumn.HeaderText = "Hora Venta";
            this.horaVentaDataGridViewTextBoxColumn.Name = "horaVentaDataGridViewTextBoxColumn";
            this.horaVentaDataGridViewTextBoxColumn.ReadOnly = true;
            this.horaVentaDataGridViewTextBoxColumn.Width = 117;
            // 
            // montoDataGridViewTextBoxColumn
            // 
            this.montoDataGridViewTextBoxColumn.DataPropertyName = "Monto";
            this.montoDataGridViewTextBoxColumn.HeaderText = "Monto";
            this.montoDataGridViewTextBoxColumn.Name = "montoDataGridViewTextBoxColumn";
            this.montoDataGridViewTextBoxColumn.ReadOnly = true;
            this.montoDataGridViewTextBoxColumn.Width = 82;
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "Numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "Numero De Entrada";
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            this.numeroDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeroDataGridViewTextBoxColumn.Width = 177;
            // 
            // entradaBindingSource
            // 
            this.entradaBindingSource.DataSource = typeof(MuseoPictoricoG11.Modelos.Entrada);
            // 
            // PantallaConsultaEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(194)))), ((int)(((byte)(146)))));
            this.ClientSize = new System.Drawing.Size(671, 614);
            this.Controls.Add(this.lblSede);
            this.Controls.Add(this.lblCountMaximaVisitantes);
            this.Controls.Add(this.lblCantidadMaximaVisitantesDeSede);
            this.Controls.Add(this.lblCountReservasVisitasConfirmadas);
            this.Controls.Add(this.lblCantidadReservasVisitasConfirmadas);
            this.Controls.Add(this.lblCantidadEntradasVendidas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRegVentEntr);
            this.Controls.Add(this.dtgConsultaEntradas);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PantallaConsultaEntradas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PantallaConsultaEntradas";
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultaEntradas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblRegVentEntr;
        private System.Windows.Forms.DataGridView dtgConsultaEntradas;
        private System.Windows.Forms.BindingSource entradaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaVentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaVentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCantidadEntradasVendidas;
        private System.Windows.Forms.Label lblCantidadReservasVisitasConfirmadas;
        private System.Windows.Forms.Label lblCountReservasVisitasConfirmadas;
        private System.Windows.Forms.Label lblCantidadMaximaVisitantesDeSede;
        private System.Windows.Forms.Label lblCountMaximaVisitantes;
        private System.Windows.Forms.Label lblSede;
    }
}