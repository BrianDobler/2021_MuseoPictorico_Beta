namespace MuseoPictoricoG11.Pantallas
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.barrita1 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.barrita11 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlbarrita1 = new System.Windows.Forms.Panel();
            this.barrita2 = new System.Windows.Forms.Panel();
            this.separadorUser = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblCrear = new System.Windows.Forms.LinkLabel();
            this.hasOlvi = new System.Windows.Forms.LinkLabel();
            this.checkPass = new System.Windows.Forms.PictureBox();
            this.checkUser = new System.Windows.Forms.PictureBox();
            this.errorPass = new System.Windows.Forms.PictureBox();
            this.errorUser = new System.Windows.Forms.PictureBox();
            this.btnMostrarContraseña = new System.Windows.Forms.PictureBox();
            this.BtnIng = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSalirSesion = new System.Windows.Forms.Button();
            this.btnOcultarContraseña = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.checkPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMostrarContraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOcultarContraseña)).BeginInit();
            this.SuspendLayout();
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(123)))), ((int)(((byte)(45)))));
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseña.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(158)))), ((int)(((byte)(96)))));
            this.txtContraseña.Location = new System.Drawing.Point(27, 204);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(274, 24);
            this.txtContraseña.TabIndex = 2;
            this.txtContraseña.Tag = "";
            this.txtContraseña.Text = "Ingrese la Contraseña";
            this.txtContraseña.Enter += new System.EventHandler(this.txtContraseña_Enter);
            this.txtContraseña.Leave += new System.EventHandler(this.txtContraseña_Leave);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(123)))), ((int)(((byte)(45)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(158)))), ((int)(((byte)(96)))));
            this.txtUsuario.Location = new System.Drawing.Point(27, 140);
            this.txtUsuario.MaxLength = 50;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(274, 24);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.Text = "Ingrese el Usuario";
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(194)))), ((int)(((byte)(146)))));
            this.label4.Location = new System.Drawing.Point(22, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 28);
            this.label4.TabIndex = 22;
            this.label4.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(194)))), ((int)(((byte)(146)))));
            this.label3.Location = new System.Drawing.Point(22, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 28);
            this.label3.TabIndex = 20;
            this.label3.Text = "Usuario";
            // 
            // barrita1
            // 
            this.barrita1.AutoSize = true;
            this.barrita1.BackColor = System.Drawing.Color.Transparent;
            this.barrita1.Font = new System.Drawing.Font("Poppins Medium", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barrita1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(194)))), ((int)(((byte)(146)))));
            this.barrita1.Location = new System.Drawing.Point(28, 46);
            this.barrita1.MinimumSize = new System.Drawing.Size(240, 50);
            this.barrita1.Name = "barrita1";
            this.barrita1.Size = new System.Drawing.Size(267, 65);
            this.barrita1.TabIndex = 5;
            this.barrita1.Text = " Bienvenido!";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 17;
            this.bunifuElipse1.TargetControl = this;
            // 
            // barrita11
            // 
            this.barrita11.ElipseRadius = 17;
            this.barrita11.TargetControl = this.pnlbarrita1;
            // 
            // pnlbarrita1
            // 
            this.pnlbarrita1.Location = new System.Drawing.Point(-1, 359);
            this.pnlbarrita1.Name = "pnlbarrita1";
            this.pnlbarrita1.Size = new System.Drawing.Size(333, 18);
            this.pnlbarrita1.TabIndex = 33;
            // 
            // barrita2
            // 
            this.barrita2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(194)))), ((int)(((byte)(146)))));
            this.barrita2.Location = new System.Drawing.Point(-4, 369);
            this.barrita2.Name = "barrita2";
            this.barrita2.Size = new System.Drawing.Size(614, 42);
            this.barrita2.TabIndex = 32;
            // 
            // separadorUser
            // 
            this.separadorUser.BackColor = System.Drawing.Color.Transparent;
            this.separadorUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(194)))), ((int)(((byte)(146)))));
            this.separadorUser.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(194)))), ((int)(((byte)(146)))));
            this.separadorUser.LineThickness = 2;
            this.separadorUser.Location = new System.Drawing.Point(26, 164);
            this.separadorUser.Name = "separadorUser";
            this.separadorUser.Size = new System.Drawing.Size(275, 10);
            this.separadorUser.TabIndex = 35;
            this.separadorUser.Transparency = 255;
            this.separadorUser.Vertical = false;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(194)))), ((int)(((byte)(146)))));
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(194)))), ((int)(((byte)(146)))));
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(27, 229);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(274, 10);
            this.bunifuSeparator1.TabIndex = 36;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // lblCrear
            // 
            this.lblCrear.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(64)))), ((int)(((byte)(48)))));
            this.lblCrear.AutoSize = true;
            this.lblCrear.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(64)))), ((int)(((byte)(48)))));
            this.lblCrear.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrear.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblCrear.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(158)))), ((int)(((byte)(96)))));
            this.lblCrear.Location = new System.Drawing.Point(22, 320);
            this.lblCrear.Name = "lblCrear";
            this.lblCrear.Size = new System.Drawing.Size(90, 23);
            this.lblCrear.TabIndex = 3;
            this.lblCrear.TabStop = true;
            this.lblCrear.Text = "Registrarme";
            this.lblCrear.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(158)))), ((int)(((byte)(96)))));
            this.lblCrear.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCrear_LinkClicked);
            // 
            // hasOlvi
            // 
            this.hasOlvi.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(64)))), ((int)(((byte)(48)))));
            this.hasOlvi.AutoSize = true;
            this.hasOlvi.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(64)))), ((int)(((byte)(48)))));
            this.hasOlvi.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hasOlvi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.hasOlvi.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.hasOlvi.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(158)))), ((int)(((byte)(96)))));
            this.hasOlvi.Location = new System.Drawing.Point(22, 338);
            this.hasOlvi.Name = "hasOlvi";
            this.hasOlvi.Size = new System.Drawing.Size(194, 23);
            this.hasOlvi.TabIndex = 0;
            this.hasOlvi.TabStop = true;
            this.hasOlvi.Text = "Has olvidado la contraseña?";
            this.hasOlvi.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(158)))), ((int)(((byte)(96)))));
            // 
            // checkPass
            // 
            this.checkPass.Image = global::MuseoPictoricoG11.Properties.Resources.TILDE2;
            this.checkPass.Location = new System.Drawing.Point(299, 201);
            this.checkPass.Name = "checkPass";
            this.checkPass.Size = new System.Drawing.Size(25, 25);
            this.checkPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.checkPass.TabIndex = 39;
            this.checkPass.TabStop = false;
            this.checkPass.Visible = false;
            // 
            // checkUser
            // 
            this.checkUser.Image = global::MuseoPictoricoG11.Properties.Resources.TILDE2;
            this.checkUser.Location = new System.Drawing.Point(299, 139);
            this.checkUser.Name = "checkUser";
            this.checkUser.Size = new System.Drawing.Size(25, 25);
            this.checkUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.checkUser.TabIndex = 40;
            this.checkUser.TabStop = false;
            this.checkUser.Visible = false;
            // 
            // errorPass
            // 
            this.errorPass.Image = global::MuseoPictoricoG11.Properties.Resources.error;
            this.errorPass.Location = new System.Drawing.Point(299, 201);
            this.errorPass.Name = "errorPass";
            this.errorPass.Size = new System.Drawing.Size(25, 25);
            this.errorPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.errorPass.TabIndex = 42;
            this.errorPass.TabStop = false;
            this.errorPass.Visible = false;
            // 
            // errorUser
            // 
            this.errorUser.Image = global::MuseoPictoricoG11.Properties.Resources.error;
            this.errorUser.Location = new System.Drawing.Point(299, 140);
            this.errorUser.Name = "errorUser";
            this.errorUser.Size = new System.Drawing.Size(25, 25);
            this.errorUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.errorUser.TabIndex = 41;
            this.errorUser.TabStop = false;
            this.errorUser.Visible = false;
            // 
            // btnMostrarContraseña
            // 
            this.btnMostrarContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(123)))), ((int)(((byte)(45)))));
            this.btnMostrarContraseña.Image = global::MuseoPictoricoG11.Properties.Resources.Pestaña1;
            this.btnMostrarContraseña.Location = new System.Drawing.Point(270, 201);
            this.btnMostrarContraseña.Name = "btnMostrarContraseña";
            this.btnMostrarContraseña.Size = new System.Drawing.Size(25, 25);
            this.btnMostrarContraseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMostrarContraseña.TabIndex = 26;
            this.btnMostrarContraseña.TabStop = false;
            this.btnMostrarContraseña.Visible = false;
            this.btnMostrarContraseña.Click += new System.EventHandler(this.btnMostrarContraseña_Click);
            // 
            // BtnIng
            // 
            this.BtnIng.ActiveBorderThickness = 1;
            this.BtnIng.ActiveCornerRadius = 50;
            this.BtnIng.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(194)))), ((int)(((byte)(146)))));
            this.BtnIng.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(64)))), ((int)(((byte)(48)))));
            this.BtnIng.ActiveLineColor = System.Drawing.Color.Transparent;
            this.BtnIng.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(123)))), ((int)(((byte)(45)))));
            this.BtnIng.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnIng.BackgroundImage")));
            this.BtnIng.ButtonText = "Ingresar";
            this.BtnIng.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIng.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIng.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(194)))), ((int)(((byte)(146)))));
            this.BtnIng.IdleBorderThickness = 1;
            this.BtnIng.IdleCornerRadius = 50;
            this.BtnIng.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(64)))), ((int)(((byte)(48)))));
            this.BtnIng.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(194)))), ((int)(((byte)(146)))));
            this.BtnIng.IdleLineColor = System.Drawing.Color.Transparent;
            this.BtnIng.Location = new System.Drawing.Point(26, 248);
            this.BtnIng.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnIng.Name = "BtnIng";
            this.BtnIng.Size = new System.Drawing.Size(275, 60);
            this.BtnIng.TabIndex = 4;
            this.BtnIng.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnIng.Click += new System.EventHandler(this.BtnIng_Click);
            // 
            // btnSalirSesion
            // 
            this.btnSalirSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(123)))), ((int)(((byte)(45)))));
            this.btnSalirSesion.BackgroundImage = global::MuseoPictoricoG11.Properties.Resources.Icono_cerraRcrema2;
            this.btnSalirSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalirSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalirSesion.FlatAppearance.BorderSize = 0;
            this.btnSalirSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSalirSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(123)))), ((int)(((byte)(45)))));
            this.btnSalirSesion.Location = new System.Drawing.Point(287, -2);
            this.btnSalirSesion.Name = "btnSalirSesion";
            this.btnSalirSesion.Size = new System.Drawing.Size(46, 43);
            this.btnSalirSesion.TabIndex = 6;
            this.btnSalirSesion.UseVisualStyleBackColor = false;
            this.btnSalirSesion.Click += new System.EventHandler(this.btnSalirSesion_Click);
            // 
            // btnOcultarContraseña
            // 
            this.btnOcultarContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(123)))), ((int)(((byte)(45)))));
            this.btnOcultarContraseña.Image = global::MuseoPictoricoG11.Properties.Resources.OjoCrema;
            this.btnOcultarContraseña.Location = new System.Drawing.Point(270, 201);
            this.btnOcultarContraseña.Name = "btnOcultarContraseña";
            this.btnOcultarContraseña.Size = new System.Drawing.Size(25, 25);
            this.btnOcultarContraseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnOcultarContraseña.TabIndex = 27;
            this.btnOcultarContraseña.TabStop = false;
            this.btnOcultarContraseña.Click += new System.EventHandler(this.btnOcultarContraseña_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(123)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(331, 386);
            this.Controls.Add(this.checkPass);
            this.Controls.Add(this.checkUser);
            this.Controls.Add(this.errorPass);
            this.Controls.Add(this.errorUser);
            this.Controls.Add(this.hasOlvi);
            this.Controls.Add(this.lblCrear);
            this.Controls.Add(this.btnMostrarContraseña);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.separadorUser);
            this.Controls.Add(this.pnlbarrita1);
            this.Controls.Add(this.BtnIng);
            this.Controls.Add(this.barrita2);
            this.Controls.Add(this.btnSalirSesion);
            this.Controls.Add(this.btnOcultarContraseña);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.barrita1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Login_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.checkPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMostrarContraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOcultarContraseña)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnOcultarContraseña;
        private System.Windows.Forms.PictureBox btnMostrarContraseña;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label barrita1;
        private System.Windows.Forms.Button btnSalirSesion;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse barrita11;
        private System.Windows.Forms.Panel pnlbarrita1;
        private System.Windows.Forms.Panel barrita2;
        private Bunifu.Framework.UI.BunifuSeparator separadorUser;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnIng;
        private System.Windows.Forms.LinkLabel lblCrear;
        private System.Windows.Forms.LinkLabel hasOlvi;
        private System.Windows.Forms.PictureBox checkPass;
        private System.Windows.Forms.PictureBox errorUser;
        private System.Windows.Forms.PictureBox checkUser;
        private System.Windows.Forms.PictureBox errorPass;
        private System.Windows.Forms.Timer timer1;
    }
}