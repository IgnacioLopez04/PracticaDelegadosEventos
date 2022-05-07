namespace Logica
{
    public class Ejercicio1
    {
        int suma = 0;

        public EventHandler<TipoEvento> Evento;

        public int Calcular(int i)
        {
            int numero = new Random().Next(0, 100);
            suma += numero;

            if (numero < (suma / (i + 1)))
            {
                this.Evento(this, new TipoEvento() { Numero = numero }) ;
            }
            return numero;
        }
    }

    public class TipoEvento : EventArgs
    {
        public int Numero { get; set; }
    }
}