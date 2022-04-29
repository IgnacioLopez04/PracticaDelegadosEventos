using Ejercicio1;

Persona persona = new Persona();
Logger logger = new Logger();   
persona.NombreModificado += logger.ImprimirEnPantallaHandler;

Console.WriteLine("Nuevo nombre: ");
persona.ActualizarNombre(Console.ReadLine());


