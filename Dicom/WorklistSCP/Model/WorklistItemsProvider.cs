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
            DataTable estudios =  EstudioControl.BuscarEstudiosEnFecha(DateTime.Now.ToString("s"));

            lista = new List<WorklistItem>();
            lista = (from DataRow dr in estudios.Rows
                           select new WorklistItem()
                           { 
                               PatientID = dr["CODIGO PACIENTE"].ToString(),
                               Surname = dr["APELLIDO PATERNO"].ToString() + " " + dr["APELLIDO MATERNO"].ToString(),
                               Forename = dr["NOMBRES"].ToString(),
                               Sex = dr["GENERO"].ToString(),
                               DateOfBirth = Convert.ToDateTime(dr["FECHA INICIO"]),

                               AccessionNumber = "AB123",
                               Modality = dr["MODALIDAD"].ToString(),
                               HospitalName = null,
                               PerformingPhysician = null,
                               //ProcedureID = "200001",
                               //ProcedureStepID = "200002",
                               StudyUID = "1.2.34.567890.1234567890.1",
                               //ScheduledAET = "MRMODALITY",
                               //ReferringPhysician = "Smith^John^Md",
                               ExamDateAndTime = DateTime.Now,

                           }).ToList();


            return lista;
        }

    }
}
