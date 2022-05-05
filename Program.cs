using System;
using System.Reflection;
using System.Windows.Forms;

namespace _2204
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Assembly.Load(_2204.Properties.Resources.);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormTC());
        }
    }
}
