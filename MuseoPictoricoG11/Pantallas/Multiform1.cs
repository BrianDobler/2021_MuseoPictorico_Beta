using System.Threading;
using System.Windows.Forms;

namespace MuseoPictoricoG11.Pantallas
{
    public class Multiform1 : ApplicationContext
    {
        private int openForms;
        public Multiform1(params Form[] forms)
        {
            openForms = forms.Length;

            foreach (var form in forms)
            {
                form.FormClosed += (s, args) =>
                {
                    //When we have closed the last of the "starting" forms, 
                    //end the program.
                    if (Interlocked.Decrement(ref openForms) == 0)
                        ExitThread();
                };

                form.Show();
            }
        }

    }
}
