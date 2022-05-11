using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class CalculoLetras
    {
        private static CalculoLetras Instace = null;
        private CalculoLetras() { }
        public static CalculoLetras Instancia
        {
            get
            {
                if (Instace == null)
                {
                    Instace = new CalculoLetras();
                }
                return Instace;
            }
        }

        public int CalularDiferenciasLetras(string nombreNuevo, string nombreViejo)
        {
            return nombreNuevo.Length - nombreViejo.Length;
        }
    }
}
