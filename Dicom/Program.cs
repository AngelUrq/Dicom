
using Dicom.Control;
using Dicom.Log;
using Dicom.WorklistSCP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dicom
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            AllocConsole();
            Consola.Imprimir("Iniciando aplicación...");

            /*LogManager.SetImplementation(ConsoleLogManager.Instance);

            var port = args != null && args.Length > 0 && int.TryParse(args[0].ToString(), out int tmp) ? tmp : 8005;

            Consola.Imprimir($"Starting QR SCP server with AET: QRSCP on port {port}");

            WorklistServer.Start(port, "QRSCP");

            Consola.Imprimir("Press any key to stop the service");

            Console.Read();

            Consola.Imprimir("Stopping QR service");

            WorklistServer.Stop();*/

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
			//Application.Run(new Test());
			Application.Run(new FrmPrincipal());

            // Initialize log manager.
           


        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
    }
}
