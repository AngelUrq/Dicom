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
            WorklistServer.Start(puerto, aet);
        }

    }
}
