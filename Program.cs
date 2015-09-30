using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zUpdator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                try
                {
                    if (String.IsNullOrEmpty(args[0])) { }
                }
                catch (IndexOutOfRangeException iex)
                {
                    ArgumentException argex = new ArgumentException("This process belongs to PTr Launcher, it cannot be opened alone.", iex);
                    throw argex;
                }

                string[] aux_args = args[0].Split('_');

                Application.Run(new MainUpdator(aux_args[0], aux_args[1]));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "zUpdator", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
