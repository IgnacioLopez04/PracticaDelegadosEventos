using Logica;
using static Logica.Auto;

string salida = "no";

Auto auto = new Auto();
ArrancarAuto arrancarAuto = new ArrancarAuto(auto.Arrancar);
Velocidad velocidad = new Velocidad(auto.ModificarVelocidad);
auto.ExcesoVelocidadMaxima += ExcesoVelocidadHandler;

while(salida == "no")
{
    arrancarAuto();

    Console.WriteLine("Ingrese una velocidad: ");
    int nuevaVelocidad = int.Parse(Console.ReadLine());

    Console.WriteLine(velocidad(nuevaVelocidad));

    Console.WriteLine("Apagar auto?");
    salida = Console.ReadLine();
}
velocidad(0);

void ExcesoVelocidadHandler(object sender, EventoArgs e)
{
    Console.WriteLine($"Velocidad máxima de {e.VelocidadMaxima} ha sido sobrepasada");
}

