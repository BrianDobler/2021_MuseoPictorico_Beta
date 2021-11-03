using MuseoPictoricoG11.LogicaDeNegocio;
using MuseoPictoricoG11.Modelos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MuseoPictoricoG11.Pantallas
{
    public partial class Login : Form
    {
        private UsuarioServicio _usuarioServicio;
        private SesionServicio _sesionServicio;

        public Login()
        {
            InitializeComponent();
            _usuarioServicio = new UsuarioServicio();
            _sesionServicio = new SesionServicio();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            timer1.Start();
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

        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void imgLogo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnSalirSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de cerrar el programa?", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                Application.Exit();

            }
        }

        private void BtnIng_Click(object sender, EventArgs e)
        {
            var nombreIngresado = txtUsuario.Text;
            var passwordIngresado = txtContraseña.Text;
            Usuario usuarioSistema = _usuarioServicio.Login(nombreIngresado, passwordIngresado);
            if (usuarioSistema == null)
            {

                MessageBox.Show("Usted no esta registrado en el sistema," +
                    " por favor luego de completar los campos solicitados aprete la" +
                    " opción 'Registrarme' para poder continuar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorUser.Visible = true;
                errorPass.Visible = true;
                checkUser.Visible = false;
                checkPass.Visible = false;
            }
            else
            {
                //inicio la sesion con el usuario logueado.
                _sesionServicio.IniciarSesion(usuarioSistema);

                this.Dispose();
            }
        }

        private void btnOcultarContraseña_Click(object sender, EventArgs e)
        {
            btnOcultarContraseña.Visible = false;
            btnMostrarContraseña.Visible = true;
            if (txtContraseña.UseSystemPasswordChar == true && btnOcultarContraseña.Visible == true)
            {
                txtContraseña.UseSystemPasswordChar = false;
                btnMostrarContraseña.Visible = true;
                btnOcultarContraseña.Visible = false;

            }
            else
            {
                txtContraseña.UseSystemPasswordChar = true;
                btnOcultarContraseña.Visible = false;
                btnMostrarContraseña.Visible = true;

            }
        }

        private void btnMostrarContraseña_Click(object sender, EventArgs e)
        {

            btnOcultarContraseña.Visible = true;
            btnMostrarContraseña.Visible = false;
            if (txtContraseña.UseSystemPasswordChar == false && btnMostrarContraseña.Visible == true)
            {
                txtContraseña.UseSystemPasswordChar = false;
                btnOcultarContraseña.Visible = true;
                btnMostrarContraseña.Visible = false;
            }
            else
            {
                txtContraseña.UseSystemPasswordChar = false;
                btnOcultarContraseña.Visible = true;
                btnMostrarContraseña.Visible = false;


            }
        }
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Ingrese el Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.FromArgb(225, 194, 146);
                errorUser.Visible = true;
            }
            else
            {
                if (txtUsuario.Text == "usuario")
                {
                    checkUser.Visible = true;
                    errorUser.Visible = false;
                }
            }
        }
        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Ingrese el Usuario";
                txtUsuario.ForeColor = Color.FromArgb(210, 158, 96);
                errorUser.Visible = true;
            }
            else
            {
                if (txtUsuario.Text == "usuario")
                {
                    checkUser.Visible = true;
                    errorUser.Visible = false;
                }
                else
                    errorUser.Visible = true;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Ingrese la Contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.FromArgb(225, 194, 146);
                txtContraseña.UseSystemPasswordChar = true;
                btnMostrarContraseña.Visible = true;
                errorPass.Visible = true;
            }
            else
            {
                if (txtUsuario.Text == "usuario")
                {
                    checkUser.Visible = true;
                    errorUser.Visible = false;
                }
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Ingrese la Contraseña";
                txtContraseña.ForeColor = Color.FromArgb(210, 158, 96);
                txtContraseña.UseSystemPasswordChar = false;
                btnMostrarContraseña.Visible = false;
                errorPass.Visible = true;
            }
            else
            {
                if (txtContraseña.Text == "usuario")
                {
                    errorPass.Visible = false;
                    checkPass.Visible = true;
                }
                else
                    errorPass.Visible = true;
            }
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            hasOlvi.ForeColor = Color.FromArgb(75, 64, 48);
        }

        private void lblCrear_Move(object sender, EventArgs e)
        {
            lblCrear.ForeColor = Color.FromArgb(75, 64, 48);
        }

        private void lblCrear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Empleado emp = new Empleado("Abel", 50, 23265764029, 26576402, "Domicilio", DateTime.Parse("30/01/1999"), DateTime.Parse("12/4/1978"), "mail", "Ankara", true, "Telefono");
            Empleado emp = new Empleado("Abel", 50, 23265764029, 26576402, "Domicilio", DateTime.Parse("1999/01/30"), DateTime.Parse("1978/04/12"), "mail", "Ankara", true, "Telefono");
            Tarifa t1 = new Tarifa() { m_TipoDeEntrada = new TipoDeEntrada() { Nombre = "Estudiantes" }, m_TipoVisita = new TipoVisita() { Nombre = "Completa" }, FechaFinVigencia = DateTime.Now.AddDays(5), FechaInicioVigencia = DateTime.Now, Monto = 320, MontoAdicionalGuia = 50 };
            Tarifa t2 = new Tarifa() { m_TipoDeEntrada = new TipoDeEntrada() { Nombre = "Estudiantes" }, m_TipoVisita = new TipoVisita() { Nombre = "Por Exposicion" }, FechaFinVigencia = DateTime.Now.AddDays(5), FechaInicioVigencia = DateTime.Now, Monto = 60, MontoAdicionalGuia = 50 };
            Tarifa t3 = new Tarifa() { m_TipoDeEntrada = new TipoDeEntrada() { Nombre = "Estudiantes" }, m_TipoVisita = new TipoVisita() { Nombre = "Completa" }, FechaFinVigencia = DateTime.Now.AddDays(5), FechaInicioVigencia = DateTime.Now, Monto = 320, MontoAdicionalGuia = 0 };
            Tarifa t4 = new Tarifa() { m_TipoDeEntrada = new TipoDeEntrada() { Nombre = "Estudiantes" }, m_TipoVisita = new TipoVisita() { Nombre = "Por Exposicion" }, FechaFinVigencia = DateTime.Now.AddDays(5), FechaInicioVigencia = DateTime.Now, Monto = 60, MontoAdicionalGuia = 0 };
            Tarifa t5 = new Tarifa() { m_TipoDeEntrada = new TipoDeEntrada() { Nombre = "Jubilados" }, m_TipoVisita = new TipoVisita() { Nombre = "Completa" }, FechaFinVigencia = DateTime.Now.AddDays(5), FechaInicioVigencia = DateTime.Now, Monto = 250, MontoAdicionalGuia = 30 };
            Tarifa t6 = new Tarifa() { m_TipoDeEntrada = new TipoDeEntrada() { Nombre = "Jubilados" }, m_TipoVisita = new TipoVisita() { Nombre = "Por Exposicion" }, FechaFinVigencia = DateTime.Now.AddDays(5), FechaInicioVigencia = DateTime.Now, Monto = 50, MontoAdicionalGuia = 30 };
            Tarifa t7 = new Tarifa() { m_TipoDeEntrada = new TipoDeEntrada() { Nombre = "Jubilados" }, m_TipoVisita = new TipoVisita() { Nombre = "Completa" }, FechaFinVigencia = DateTime.Now.AddDays(5), FechaInicioVigencia = DateTime.Now, Monto = 250, MontoAdicionalGuia = 0 };
            Tarifa t8 = new Tarifa() { m_TipoDeEntrada = new TipoDeEntrada() { Nombre = "Jubilados" }, m_TipoVisita = new TipoVisita() { Nombre = "Por Exposicion" }, FechaFinVigencia = DateTime.Now.AddDays(5), FechaInicioVigencia = DateTime.Now, Monto = 50, MontoAdicionalGuia = 0 };
            Tarifa t9 = new Tarifa() { m_TipoDeEntrada = new TipoDeEntrada() { Nombre = "Menores de 12 años" }, m_TipoVisita = new TipoVisita() { Nombre = "Completa" }, FechaFinVigencia = DateTime.Now.AddDays(5), FechaInicioVigencia = DateTime.Now, Monto = 150, MontoAdicionalGuia = 20 };
            Tarifa t10 = new Tarifa() { m_TipoDeEntrada = new TipoDeEntrada() { Nombre = "Menores de 12 años" }, m_TipoVisita = new TipoVisita() { Nombre = "Por Exposicion" }, FechaFinVigencia = DateTime.Now.AddDays(5), FechaInicioVigencia = DateTime.Now, Monto = 30, MontoAdicionalGuia = 20 };
            Tarifa t11 = new Tarifa() { m_TipoDeEntrada = new TipoDeEntrada() { Nombre = "Menores de 12 años" }, m_TipoVisita = new TipoVisita() { Nombre = "Completa" }, FechaFinVigencia = DateTime.Now.AddDays(5), FechaInicioVigencia = DateTime.Now, Monto = 150, MontoAdicionalGuia = 0 };
            Tarifa t12 = new Tarifa() { m_TipoDeEntrada = new TipoDeEntrada() { Nombre = "Menores de 12 años" }, m_TipoVisita = new TipoVisita() { Nombre = "Por Exposicion" }, FechaFinVigencia = DateTime.Now.AddDays(5), FechaInicioVigencia = DateTime.Now, Monto = 30, MontoAdicionalGuia = 0 };
            Tarifa t13 = new Tarifa() { m_TipoDeEntrada = new TipoDeEntrada() { Nombre = "Publico en General" }, m_TipoVisita = new TipoVisita() { Nombre = "Completa" }, FechaFinVigencia = DateTime.Now.AddDays(5), FechaInicioVigencia = DateTime.Now, Monto = 400, MontoAdicionalGuia = 70 };
            Tarifa t14 = new Tarifa() { m_TipoDeEntrada = new TipoDeEntrada() { Nombre = "Publico en General" }, m_TipoVisita = new TipoVisita() { Nombre = "Por Exposicion" }, FechaFinVigencia = DateTime.Now.AddDays(5), FechaInicioVigencia = DateTime.Now, Monto = 80, MontoAdicionalGuia = 70 };
            Tarifa t15 = new Tarifa() { m_TipoDeEntrada = new TipoDeEntrada() { Nombre = "Publico en General" }, m_TipoVisita = new TipoVisita() { Nombre = "Completa" }, FechaFinVigencia = DateTime.Now.AddDays(5), FechaInicioVigencia = DateTime.Now, Monto = 400, MontoAdicionalGuia = 0 };
            Tarifa t16 = new Tarifa() { m_TipoDeEntrada = new TipoDeEntrada() { Nombre = "Publico en General" }, m_TipoVisita = new TipoVisita() { Nombre = " Por Exposicion " }, FechaFinVigencia = DateTime.Now.AddDays(5), FechaInicioVigencia = DateTime.Now, Monto = 80, MontoAdicionalGuia = 0 };

            /*************************** Seteamos Datos Exposicion para una Sede ***********/
            Obra obra1 = new Obra()
            {
                Alto = 200.0,
                Ancho = 200.0,
                CodigoSensor = 1,
                Descripcion = "Obra sobre tela - Dobler",
                DuracionExtendida = 40,
                DuracionResumida = 48,
                FechaCreacion = DateTime.Now,
                Nombre = "Dobler y su tinta",
                Peso = 1.34,
                Valuacion = 1.50
            };
            Obra obra2 = new Obra()
            {
                Alto = 200.0,
                Ancho = 200.0,
                CodigoSensor = 1,
                Descripcion = "Obra sobre tela - Dobler",
                DuracionExtendida = 120,
                DuracionResumida = 90,
                FechaCreacion = DateTime.Now,
                Nombre = "Dobler y su tinta",
                Peso = 1.34,
                Valuacion = 1.50
            };

            DetalleExposicion detalleExposicion = new DetalleExposicion
            {
                m_Obra = obra1,
                LugarAsignado = "Cordoba"
            };
            DetalleExposicion detalleExposicion1 = new DetalleExposicion
            {
                m_Obra = obra2,
                LugarAsignado = "Cordoba"
            };

            List<DetalleExposicion> detalleExposiciones = new List<DetalleExposicion>();
            detalleExposiciones.Add(detalleExposicion);
            detalleExposiciones.Add(detalleExposicion1);
            DateTime currentDate = DateTime.Now;
            Exposicion exposicion = new Exposicion()
            {
                m_DetalleExposicion = detalleExposiciones,
                FechaFinReplanificada = currentDate.AddDays(1),
                FechaInicioReplanificada = DateTime.Parse("30/01/1999"),
                HoraApertura = DateTime.Parse("30/01/1999"),
                FechaHoraFin = DateTime.Parse("30/01/1999"),
                HoraCierre = DateTime.Parse("30/01/1999"),
                Nombre = "Tintas sobre tela"
            };

            List<Exposicion> exposiciones = new List<Exposicion>();
            exposiciones.Add(exposicion);
            /***************************************************************************************/
            Sede sede = new Sede(200, "Domicilio", DateTime.Now, "Cordoba") { m_Tarifa = new List<Tarifa>() };
            sede.m_Tarifa.Add(t1);
            sede.m_Tarifa.Add(t2);
            sede.m_Exposicion = exposiciones;
            sede.m_Tarifa.Add(t3);
            sede.m_Tarifa.Add(t4); sede.m_Tarifa.Add(t5); sede.m_Tarifa.Add(t6); sede.m_Tarifa.Add(t7); sede.m_Tarifa.Add(t8);
            sede.m_Tarifa.Add(t9); sede.m_Tarifa.Add(t10); sede.m_Tarifa.Add(t11); sede.m_Tarifa.Add(t12); sede.m_Tarifa.Add(t13);
            sede.m_Tarifa.Add(t14); sede.m_Tarifa.Add(t15); sede.m_Tarifa.Add(t16);
            emp.m_Sede = sede;
            _usuarioServicio.crearUsuario("usuario", "usuario", DateTime.Now, emp);
            checkUser.Visible = true;
            checkPass.Visible = true;
        }


    }
}
