using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace MuseoPictoricoG11.Pantallas
{
    public partial class PantallaPrincipal : Form
    {

        public PantallaPrincipal(MenuV2 menuV2)
        {

            InitializeComponent();
        }

        //mostrar fecha y hora del sistema
        private void HoraFecha_Tick_1(object sender, EventArgs e)
        {
            labHora.Text = DateAndTime.Now.ToLongTimeString();
            labFecha.Text = DateAndTime.Now.ToString("dd MMMM, yyyy");
        }
        private MenuV2 menuV2;

        public MenuV2 getMenuV2()
        {
            return (this.menuV2);
        }

    }
}
