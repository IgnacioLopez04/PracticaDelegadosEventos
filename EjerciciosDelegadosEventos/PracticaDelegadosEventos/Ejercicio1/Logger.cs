using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public class Logger
    {
        public void ImprimirEnPantallaHandler(object? sender, NombreModificadoClase e)
        {
            Console.WriteLine($"El nombre viejo es: {e.NombreViejo}; El nuevo nombre es: {e.NombreNuevo}.");
        }
    }
}
