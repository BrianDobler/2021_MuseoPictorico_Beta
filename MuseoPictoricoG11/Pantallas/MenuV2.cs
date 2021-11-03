using MuseoPictoricoG11.LogicaDeNegocio;
using MuseoPictoricoG11.Modelos;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MuseoPictoricoG11.Pantallas
{
    public partial class MenuV2 : Form
    {
        private Usuario _usuario;
        private SesionServicio _sesionServicio = new SesionServicio();
        private UsuarioServicio _usuarioServicio = new UsuarioServicio();

        public MenuV2(PantallaEntrada pantallaEntrada, PantallaSala pantallaSala)
        {
            this.pantallaEntrada = pantallaEntrada;
            this.pantallaSala = pantallaSala;
            InitializeComponent();
            customizeDesing();
            PantallaPrincipal();
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

        private void MenuV2_Load(object sender, EventArgs e)
        {
            new CargaProgram().ShowDialog();
            new Login().ShowDialog();
            this.Opacity = 0.0;
            timer1.Start();
            this._usuario = UsuarioServicio.UsuarioLogueado;
            this.lblUsuario.Text = this._usuario.NombreUsuario;
            this.lblPerfil.Text = "Responsable de Ventas";
        }

        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void MenuV2_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PanelSup_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #region SubMenu ocutlo
        //Se OcultanSubMenu
        private void customizeDesing()
        {
            subMenuVentaEnt.Visible = false;
            subMenuTipoEntrada.Visible = false;
            subMenuRankingEntr.Visible = false;
        }

        private void hideSubMenu()
        {
            if (subMenuVentaEnt.Visible == true)
                subMenuVentaEnt.Visible = false;
            if (subMenuTipoEntrada.Visible == true)
                subMenuTipoEntrada.Visible = false;
            if (subMenuRankingEntr.Visible == true)
                subMenuRankingEntr.Visible = false;

        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnVentaDeEntradas_Click(object sender, EventArgs e)
        {
            showSubMenu(subMenuVentaEnt);
        }
        private void btnTipoDeEntrada_Click(object sender, EventArgs e)
        {
            showSubMenu(subMenuTipoEntrada);
        }

        private void btnRankingDeEntrada_Click(object sender, EventArgs e)
        {
            showSubMenu(subMenuRankingEntr);
        }
        private void btnRegistrarVentaDeEntradas_Click(object sender, EventArgs e)
        {
            //AbrirFormEnPanel(new PantallaVentaEntradas(this, pantallaEntrada, pantallaSala));

            PantallaVentaEntradas pantallaVentaEntradas = new PantallaVentaEntradas(this, pantallaEntrada, pantallaSala);
            AbrirFormEnPanel(pantallaVentaEntradas);

            hideSubMenu();
        }
        private void btnRegistrarVentaDeEntrada_Click(object sender, EventArgs e)
        {
            /////AbrirFormEnPanel(new PantallaVentaEntradas(this, pantallaEntrada, pantallaSala));
            PantallaVentaEntradas pantallaVentaEntradas = new PantallaVentaEntradas(this, pantallaEntrada, pantallaSala);
            AbrirFormEnPanel(pantallaVentaEntradas);

            hideSubMenu();
        }
        private void btnConsultarVentaEntrada_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new PantallaConsultaEntradas(this));
            hideSubMenu();
        }

        #endregion
        //ABRIR SUBFORMULARIOS EN PANEL PRINCIPAL
        private void AbrirFormEnPanel(object Formhijo)
        {
            if (this.PanelPrincipalDeForm.Controls.Count > 0)
                this.PanelPrincipalDeForm.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelPrincipalDeForm.Controls.Add(fh);
            this.PanelPrincipalDeForm.Tag = fh;
            fh.Show();
        }

        private void btnSalirMenu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de cerrar el programa?", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                _sesionServicio.CerrarSesion();
                Application.Exit();
            }
        }

        private void btnMaximizarMenu_Click(object sender, EventArgs e)
        {
            btnMaximizarMenu.Visible = false;
            btnRestaurarMenu.Visible = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnRestaurarMenu_Click(object sender, EventArgs e)
        {
            btnRestaurarMenu.Visible = false;
            btnMaximizarMenu.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimizarMenu_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void PantallaPrincipal()
        {
            AbrirFormEnPanel(new PantallaPrincipal(this));
        }

        private void btnPantallaPrincipal_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new PantallaPrincipal(this));
            hideSubMenu();
        }

        private void btnConfiguraciones_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Usted no tiene permisos para editar esta ventana", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                hideSubMenu();
            }
        }

        //DarkMode
        #region
        private void modoClaro()
        {
            PanelSup.BackColor = Color.FromArgb(196, 123, 45);
            PanIzquierdo.BackColor = Color.FromArgb(196, 123, 45);
            panelIzqAb.BackColor = Color.FromArgb(196, 123, 45);
            lblUsuario.BackColor = Color.FromArgb(246, 217, 170);
            lblUsuario.ForeColor = Color.FromArgb(75, 64, 48);
            lblVersion.BackColor = Color.FromArgb(196, 123, 45);
            lblVersion.ForeColor = Color.FromArgb(75, 64, 48);

            btnPantallaPrincipal.onHoverState.BorderColor = Color.FromArgb(225, 194, 146);
            btnPantallaPrincipal.onHoverState.FillColor = Color.FromArgb(225, 194, 146);
            btnPantallaPrincipal.onHoverState.ForeColor = Color.FromArgb(75, 64, 48);
            btnPantallaPrincipal.OnIdleState.ForeColor = Color.FromArgb(75, 64, 48);
            btnPantallaPrincipal.OnPressedState.BorderColor = Color.FromArgb(75, 64, 48);
            btnPantallaPrincipal.OnPressedState.FillColor = Color.FromArgb(75, 64, 48);
            btnPantallaPrincipal.OnPressedState.ForeColor = Color.FromArgb(225, 194, 146);


            btnVentaDeEntradas.ForeColor = Color.FromArgb(75, 64, 48);
            btnTipoDeEntrada.ForeColor = Color.FromArgb(75, 64, 48);
            btnRankingDeEntrada.ForeColor = Color.FromArgb(75, 64, 48);
            btnConfiguraciones.ForeColor = Color.FromArgb(75, 64, 48);
            btnMinimizarMenu.BackColor = Color.FromArgb(196, 123, 45);
            btnMaximizarMenu.BackColor = Color.FromArgb(196, 123, 45);
            btnRestaurarMenu.BackColor = Color.FromArgb(196, 123, 45);
            btnSalirMenu.BackColor = Color.FromArgb(196, 123, 45);
            panelLogo.BackColor = Color.FromArgb(196, 123, 45);
            panelUser.BackColor = Color.FromArgb(196, 123, 45);
        }
        private void modoOscuro()
        {
            PanelSup.BackColor = Color.FromArgb(75, 64, 48);
            lblMuseoSup.ForeColor = Color.FromArgb(225, 194, 146);
            logoUserDark.BackColor = Color.FromArgb(75, 64, 48);
            lblUsuario.BackColor = Color.FromArgb(167, 172, 166);
            lblUsuario.ForeColor = Color.FromArgb(75, 64, 48);
            PanIzquierdo.BackColor = Color.FromArgb(75, 64, 48);
            panelIzqAb.BackColor = Color.FromArgb(75, 64, 48);
            lblVersion.BackColor = Color.FromArgb(75, 64, 48);
            lblVersion.ForeColor = Color.FromArgb(225, 194, 146);

            btnPantallaPrincipal.onHoverState.BorderColor = Color.FromArgb(75, 64, 48);
            btnPantallaPrincipal.onHoverState.FillColor = Color.FromArgb(75, 64, 48);
            btnPantallaPrincipal.onHoverState.ForeColor = Color.FromArgb(225, 194, 146);
            btnPantallaPrincipal.OnIdleState.ForeColor = Color.FromArgb(225, 194, 146);
            btnPantallaPrincipal.OnPressedState.BorderColor = Color.FromArgb(75, 64, 48);
            btnPantallaPrincipal.OnPressedState.FillColor = Color.FromArgb(75, 64, 48);
            btnPantallaPrincipal.OnPressedState.ForeColor = Color.FromArgb(225, 194, 146);

            btnVentaDeEntradas.ForeColor = Color.FromArgb(225, 194, 146);
            btnTipoDeEntrada.ForeColor = Color.FromArgb(225, 194, 146);
            btnRankingDeEntrada.ForeColor = Color.FromArgb(225, 194, 146);
            btnConfiguraciones.ForeColor = Color.FromArgb(225, 194, 146);
            btnMinimizarMenu.BackColor = Color.FromArgb(75, 64, 48);
            btnMaximizarMenu.BackColor = Color.FromArgb(75, 64, 48);
            btnRestaurarMenu.BackColor = Color.FromArgb(75, 64, 48);
            btnSalirMenu.BackColor = Color.FromArgb(75, 64, 48);
            panelLogo.BackColor = Color.FromArgb(75, 64, 48);
            panelUser.BackColor = Color.FromArgb(75, 64, 48);
        }
        public void btnDarkMode_Click(object sender, EventArgs e)
        {
            btnLightMode.Visible = true;
            btnDarkMode.Visible = false;
            logoUser.Visible = false;
            logoUserDark.Visible = true;
            if (btnDarkMode.Visible == true)
            {
                this.Opacity = 0.2;
                timer2.Start();
                modoClaro();

            }

            else
                this.Opacity = 0.2;
            timer2.Start();
            modoOscuro();

        }
        public void btnLightMode_Click(object sender, EventArgs e)
        {
            btnLightMode.Visible = false;
            btnDarkMode.Visible = true;
            logoUser.Visible = true;
            logoUserDark.Visible = false;
            if (btnLightMode.Visible == true)
            {
                this.Opacity = 0.2;
                timer2.Start();
                modoOscuro();

            }

            else
                this.Opacity = 0.2;
            timer2.Start();
            modoClaro();

        }

        #endregion

        private void logoUser_Click(object sender, EventArgs e)
        {
            if (panelUser.Height == 0)
            {
                panelUser.Visible = false;
                panelUser.Height = 34;
                lblPerfil.Visible = true;
                AnimacionLogo.Show(panelUser);

            }
            else
                panelUser.Height = 0;
            lblPerfil.Visible = true;
            AnimacionLogoBack.Show(panelUser);
        }
        private void logoUserDark_Click(object sender, EventArgs e)
        {
            if (panelUser.Height == 0)
            {
                panelUser.Visible = false;
                panelUser.Height = 34;
                lblPerfil.Visible = true;
                AnimacionLogo.Show(panelUser);

            }
            else
                panelUser.Height = 0;
            lblPerfil.Visible = true;
            AnimacionLogoBack.Show(panelUser);
        }

        int cont = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            cont += 1;
            if (cont == 100)
            {
                timer1.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            cont += 1;
            if (cont == 100)
            {
                timer2.Stop();
            }
        }
    }
}