using Ejercicio2;
CajaAhorro cajaAhorro = new CajaAhorro();
cajaAhorro.Movimiento += CajaAhorroHandler;

cajaAhorro.Depositar(567);
cajaAhorro.Retirar(200);

static void CajaAhorroHandler(object? sender, LanzarEvento e)
{
    Console.WriteLine ($"Nombre: {e.Nombre}; Saldo actual: {e.SaldoActual}; Accion realizada: {e.AccionRealizada}");
}