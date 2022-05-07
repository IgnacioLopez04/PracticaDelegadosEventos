string parrafo = "";
string vocales = "";

Console.WriteLine("Empiece a escribir el parrafo. ");
string letra = Console.ReadLine();

Ejercio2 ejercicio = new Ejercio2();
ejercicio.Evento += VocalesHandler;

while(letra != "+")
{
    parrafo += letra;
    ejercicio.Vocal(letra);
    letra = Console.ReadLine();
}

Console.WriteLine(vocales);

void VocalesHandler(object sender, EventArgs e)
{
    vocales += letra; 
}

public class Ejercio2
{
    string vocales = "";
    private static List<string> listaVocales = new List<string>() { "a", "e", "i", "o", "u", " " };
    
    public EventHandler Evento;

    public void Vocal(string letra)
    {
        if (listaVocales.Contains(letra.ToLower()))
        {
            this.Evento(this, new EventArgs());
        }
    }
}