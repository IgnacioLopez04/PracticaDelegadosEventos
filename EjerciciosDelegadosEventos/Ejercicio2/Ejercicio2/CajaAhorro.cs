namespace Ejercicio2
{
    public class CajaAhorro
    {
        public string NombreCliente { get; set; }
        public decimal SaldoActual { get; set; }

        public bool Retirar(decimal cantidadRetiro)
        {
            if(cantidadRetiro <= SaldoActual)
            {
                SaldoActual -= cantidadRetiro;
                return true;
            }
            return false;
        }

        public void Depositar(decimal deposito)
        {
            SaldoActual += deposito;
        }
    }
}