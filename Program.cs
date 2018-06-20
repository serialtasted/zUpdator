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
                    ArgumentException argex = new ArgumentException("This process belongs to PTrangers Arma 3 Launcher, it cannot be opened alone.", iex);
                    throw argex;
                }

                try
                {
                    Application.Run(new MainUpdator(args[0], args[1], args[2]));
                    //Application.Run(new MainUpdator("-curversion=1.7", " -newversion=1.7", " -filename=arma3Launcher.exe"));
                }
                catch
                {
                    ArgumentException argex = new ArgumentException("The updator could not be initialized.\nPlease update the launcher manually by downloading it from the project's github page. \"github.com/serialtasted/arma3Launcher/releases\"");
                    throw argex;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "zUpdator", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
