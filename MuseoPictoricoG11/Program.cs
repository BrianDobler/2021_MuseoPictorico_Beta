using MuseoPictoricoG11.Pantallas;
using System;
using System.Windows.Forms;

namespace MuseoPictoricoG11
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MenuV2());

            PantallaEntrada pantallaEntrada = new PantallaEntrada();
            PantallaSala pantallaSala = new PantallaSala();
            Application.Run(new Multiform1(pantallaSala, pantallaEntrada, new MenuV2(pantallaEntrada, pantallaSala)));


        }
    }
}
