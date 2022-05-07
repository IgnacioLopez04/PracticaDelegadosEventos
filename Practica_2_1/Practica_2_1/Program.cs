using Logica;

const int nroIteraciones = 15;
Dictionary<int, int> diccionario = new Dictionary<int, int>();

Ejercicio1 ejercicio = new Ejercicio1();

ejercicio.Evento += AlmacenarNumerosHandler;

Console.WriteLine("Aparece el número(Random) cuando este sea menor al promedio de los números obtenidos previamente.");

for (int i = 0; i < nroIteraciones; i++)
{
    ejercicio.Calcular(i);
    Thread.Sleep(1000);
    Console.Clear();
}

void AlmacenarNumerosHandler(object? sender, TipoEvento e)
{
    Console.WriteLine($"Numero menor al promedio: {e.Numero}");

    diccionario.Add(e.Numero, +1);
    
}