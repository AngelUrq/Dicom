using Dicom.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Dicom.Entidades;
using Dicom.WorklistSCP.Model;

namespace Dicom.WorklistSCP
{
    public class WorklistServer
    {
        private static IDicomServer _server;
        private static Timer _itemsLoaderTimer;

        protected WorklistServer()
        {
        }

        public static string AETitle { get; set; }

        public static IWorklistItemsSource CreateItemsSourceService => new WorklistItemsProvider();

        public static List<WorklistItem> CurrentWorklistItems { get; private set; }

        public static void Start(int port, string aet)
        {
            AETitle = aet;
            _server = DicomServer.Create<Worklist_SCP.WorklistService>(port);
            // every 30 seconds the worklist source is queried and the current list of items is cached in _currentWorklistItems
            _itemsLoaderTimer = new Timer((state) =>
            {
                var newWorklistItems = CreateItemsSourceService.GetAllCurrentWorklistItems();
                CurrentWorklistItems = newWorklistItems;
            }, null, TimeSpan.Zero, TimeSpan.FromSeconds(30));
        }

        public static void Stop()
        {
            _server.Dispose();
        }
    }
}
