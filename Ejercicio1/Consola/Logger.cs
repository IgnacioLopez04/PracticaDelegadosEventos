using Logica;

Console.WriteLine("Ingrese un nuevo nombre: ");
string nombre = Console.ReadLine();

Persona persona = new Persona();
persona.NombreModificado += ModificarNombreHandler;
persona.NombreModificado += CalcularLetrasHandler;
persona.ActualizarNombre(nombre);

void ModificarNombreHandler(object sender, actualizacionNombreCompleto e)
{
    Console.WriteLine($"El nombre fue modificado de {e.NombreViejo} a {e.NombreNuevo}");
}

void CalcularLetrasHandler(object sender, actualizacionNombreCompleto e)
{
    Console.WriteLine($"La diferencia de letras entre los nombres es de: {CalculoLetras.Instancia.CalularDiferenciasLetras(e.NombreNuevo, e.NombreViejo)}");
}
