using Ejercicio1;

Persona persona = new Persona();
Logger logger = new Logger();   
persona.NombreModificado += ImprimirEnPantallaHandler;

Console.WriteLine("Nuevo nombre: ");
persona.ActualizarNombre(Console.ReadLine());

void ImprimirEnPantallaHandler(object? sender, NombreModificadoClase e)
{
    Console.WriteLine($"El nombre viejo es: {e.NombreViejo}; El nuevo nombre es: {e.NombreNuevo}.");
}


