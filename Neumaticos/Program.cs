using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neumaticos
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //el ejercicio que hicimos al principio, lo comento para poder inicializar la ventana de inicio
            //Application.Run(new Form1());

            Application.Run(new UT3Informes.Inicio());
        }
    }
}
