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
		public static string Convertir_fecha(string fecha)
		{
			string resultado = DateTime.ParseExact(fecha, "yyyyMMdd",
				CultureInfo.InvariantCulture).ToString("yyyy/MM/dd");

			DateTime pDate = Convert.ToDateTime(resultado);
			string fechaNueva = pDate.ToString("yyyy-MM-dd hh:mm:ss");
			return fechaNueva;
		}
	}
}
