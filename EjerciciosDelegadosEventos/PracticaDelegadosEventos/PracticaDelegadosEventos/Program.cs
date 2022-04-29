using Ejercicio1;

Persona persona = new Persona();

persona.NombreModificado += NombreModificadoHandler;

Console.WriteLine("Nuevo nombre: ");
persona.ActualizarNombre(Console.ReadLine());

static void NombreModificadoHandler(object? sender, NombreModificadoClase e)
{
    Console.WriteLine($"El nombre viejo es: {e.NombreViejo}; El nuevo nombre es: {e.NombreNuevo}.");
}
