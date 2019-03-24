using Dicom.Control;
using Dicom.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Dicom.WorklistSCP.Model
{
    class WorklistItemsProvider : IWorklistItemsSource
    {
        private List<WorklistItem> lista;

        /// <summary>
        /// This method returns some hard coded worklist items - of course they should be loaded from database or some other service
        /// </summary>
        
        public List<WorklistItem> GetAllCurrentWorklistItems()
        {
            DataTable estudios =  EstudioControl.BuscarEstudiosEnFecha(DateTime.Now.ToString("s"), 1, 0);

            lista = new List<WorklistItem>();
            lista = (from DataRow dr in estudios.Rows
                     select new WorklistItem()
                     {
                         PatientID = dr["CODIGO PACIENTE"].ToString(),
                         Surname = dr["APELLIDO PATERNO"].ToString() + " " + dr["APELLIDO MATERNO"].ToString(),
                         Forename = dr["NOMBRES"].ToString(),
                         Sex = dr["GENERO"].ToString(),
                         DateOfBirth = Convert.ToDateTime(dr["FECHA DE NACIMIENTO"]),

                         AccessionNumber = dr["ACCESSION NUMBER"].ToString(),
                         Title = null,
                         
                         Modality = dr["DESCRIPCION"].ToString(),
                         ExamDescription = "",
                         ExamRoom = "",
                         ReferringPhysician = dr["MEDICO DE REFERENCIA"].ToString(),
                         PerformingPhysician = dr["MEDICO DE EJERCICIO"].ToString(),
                         HospitalName = null,
                         
                         ProcedureID = "",
                         ProcedureStepID = "",
                         StudyUID = "1.2.34.567890.1234567890.1",
                         ScheduledAET = dr["MODALIDAD"].ToString(),
                         ExamDateAndTime = Convert.ToDateTime(dr["FECHA INICIO"])

                     }).ToList();

            return lista;
        }

    }
}
