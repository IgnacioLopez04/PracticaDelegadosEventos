using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public class CalculoLetras
    {
        public int CalcularLetrasNombre(string nombreNuevo, string nombreViejo)
        {
            return nombreNuevo.Length - nombreViejo.Length;
        }

        public void ImprimirTotalLetrasHandler(object? sender, NombreModificadoClase e)
        {
            Console.WriteLine($"La cantidad de la diferencia de letras que hay de entre los nombres es: {CalcularLetrasNombre(e.NombreNuevo, e.NombreViejo)}");
        }
    }
}
