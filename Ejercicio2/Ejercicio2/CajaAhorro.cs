namespace Ejercicio2
{
    public class CajaAhorro
    {
        private string NombreCliente { get; set; }
        private decimal SaldoActual { get; set; }

        public EventHandler<LanzarEvento> Movimiento;
        public void Retirar(decimal cantidadRetiro)
        {
            if (cantidadRetiro <= SaldoActual)
            {
                SaldoActual -= cantidadRetiro;

                this.Movimiento(this, new LanzarEvento() { Nombre = this.NombreCliente, SaldoActual = this.SaldoActual, AccionRealizada = "Retiro"}); 
            }
        }

        public void Depositar(decimal deposito)
        {
            SaldoActual += deposito;
            this.Movimiento(this, new LanzarEvento() { Nombre = this.NombreCliente, SaldoActual = this.SaldoActual, AccionRealizada = "Depositar"});
        }
        
    }
}