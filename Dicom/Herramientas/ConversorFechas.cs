using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dicom.Herramientas
{
	class ConversorFechas
	{
        /// <summary>
        /// Convierte fechas
        /// </summary>
        /// <param name="fecha">Fecha</param>
        /// <returns></returns>
		public static string Convertir_fecha(string fecha)
		{
			string resultado = DateTime.ParseExact(fecha, "yyyyMMdd",
				CultureInfo.InvariantCulture).ToString("yyyy/MM/dd");

			DateTime pDate = Convert.ToDateTime(resultado);
			string fechaNueva = pDate.ToString("yyyy-MM-dd hh:mm:ss");
			return fechaNueva;
		}

        /// <summary>
        /// Convierte fechas
        /// </summary>
        /// <param name="fecha">Fecha en formato texto</param>
        /// <returns></returns>
        public static DateTime ConvertirFechaHL7(string fecha)
        {
            if (fecha.Length == 4)
            {
                return new DateTime(Convert.ToInt32(fecha),0,0);
            }

            if (fecha.Length == 6)
            {
                return new DateTime(Convert.ToInt32(Convert.ToString(fecha[0]) + Convert.ToString(fecha[1]) + Convert.ToString(fecha[2]) + Convert.ToString(fecha[3])), Convert.ToInt32(Convert.ToString(fecha[4]) + Convert.ToString(fecha[5])), 0);
            }

            if (fecha.Length == 8)
            {
                return new DateTime(Convert.ToInt32(Convert.ToString(fecha[0]) + Convert.ToString(fecha[1]) + Convert.ToString(fecha[2]) + Convert.ToString(fecha[3])), Convert.ToInt32(Convert.ToString(fecha[4]) + Convert.ToString(fecha[5])), Convert.ToInt32(Convert.ToString(fecha[6]) + Convert.ToString(fecha[7])));
            }

            if (fecha.Length == 10)
            {
                return new DateTime(Convert.ToInt32(Convert.ToString(fecha[0]) + Convert.ToString(fecha[1]) + Convert.ToString(fecha[2]) + Convert.ToString(fecha[3])), Convert.ToInt32(Convert.ToString(fecha[4]) + Convert.ToString(fecha[5])), Convert.ToInt32(Convert.ToString(fecha[6]) + Convert.ToString(fecha[7])), Convert.ToInt32(Convert.ToString(fecha[8]) + Convert.ToString(fecha[9])), 0,0);
            }

            if (fecha.Length >= 12)
            {
                return new DateTime(Convert.ToInt32(Convert.ToString(fecha[0]) + Convert.ToString(fecha[1]) + Convert.ToString(fecha[2]) + Convert.ToString(fecha[3])), Convert.ToInt32(Convert.ToString(fecha[4]) + Convert.ToString(fecha[5])), Convert.ToInt32(Convert.ToString(fecha[6]) + Convert.ToString(fecha[7])), Convert.ToInt32(Convert.ToString(fecha[8]) + Convert.ToString(fecha[9])), Convert.ToInt32(Convert.ToString(fecha[10]) + Convert.ToString(fecha[11])), 0);
            }

            return DateTime.Now;
        }

    }
}
