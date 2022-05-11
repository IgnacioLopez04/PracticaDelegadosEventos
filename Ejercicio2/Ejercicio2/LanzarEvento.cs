using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class LanzarEvento : EventArgs
    {
        public string Nombre { get; set; }
        public decimal SaldoActual { get; set; }
        public string AccionRealizada { get; set; }
    }
}
