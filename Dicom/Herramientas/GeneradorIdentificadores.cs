using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dicom.Herramientas
{
    class GeneradorIdentificadores
    {
        /// <summary>
        /// Genera un accession number aleatorio
        /// </summary>
        /// <returns>Accession number</returns>
        public static string GenerarAccessionNumber()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[6];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);
            Consola.Imprimir(finalString);

            return finalString;
        }

    }
}
