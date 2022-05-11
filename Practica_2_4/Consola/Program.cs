using Logica;

Ascensor ascensor = new Ascensor();
ascensor.Evento += ImprimirPisoHandler;

Console.WriteLine("Piso actual: ");
int pisoActual = int.Parse(Console.ReadLine());
Console.WriteLine("Piso nuevo: ");
int pisoNuevo = int.Parse(Console.ReadLine());

Console.BackgroundColor = ConsoleColor.White;
Console.ForegroundColor = ConsoleColor.Red;


ascensor.LlamarAscensor(pisoActual);
ascensor.DefinirPiso(pisoNuevo);

void ImprimirPisoHandler(object sender, PisoArgs e)
{
    Console.Clear();

    Console.SetCursorPosition(55,13);
    
    Console.WriteLine(e.Piso);
    Console.Beep();
    Thread.Sleep(1000);
}
