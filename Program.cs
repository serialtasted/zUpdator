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

                try
                {
                    Application.Run(new MainUpdator(args[0], args[1], args[2]));
                }
                catch
                {
                    Application.Run(new MainUpdator(args[0].Split('_')[0], args[0].Split('_')[1], "arma3Launcher.exe"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "zUpdator", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
