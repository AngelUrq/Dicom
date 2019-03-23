using Dicom.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dicom.WorklistSCP.Model
{
    public interface IWorklistItemsSource
    {

        /// <summary>
        /// this method queries some source like database or webservice to get a list of all scheduled worklist items.
        /// This method is called periodically.
        /// </summary>
        List<WorklistItem> GetAllCurrentWorklistItems();
    }
}
