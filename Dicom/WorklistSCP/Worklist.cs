using Dicom.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dicom.WorklistSCP
{
    class Worklist
    {
        private int puerto;
        private string aet;

        public Worklist(int puerto, string aet)
        {
            ThreadStart proceso = new ThreadStart(ActivarServidor);
            Thread hilo = new Thread(proceso);

            this.puerto = puerto;
            this.aet = aet;

            hilo.Start();
        }

        public void ActivarServidor()
        {
            LogManager.SetImplementation(ConsoleLogManager.Instance);

            //var port = args != null && args.Length > 0 && int.TryParse(args[0].ToString(), out int tmp) ? tmp : 8005;
            //Consola.Imprimir($"Starting QR SCP server with AET: {aet} on port {port}");

            WorklistServer.Start(puerto, aet);

            //Consola.Imprimir("Press any key to stop the service");
            //Consola.Imprimir("Stopping QR service");
            //WorklistServer.Stop();
        }

        public void ObtenerLista()
        {

        }

    }
}
