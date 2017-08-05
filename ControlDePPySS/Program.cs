using ControlDePPySS.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlDePPySS
{
    public static class Program
    {
        public static int MyProperty { get; set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLogin());
        }
    }
}
