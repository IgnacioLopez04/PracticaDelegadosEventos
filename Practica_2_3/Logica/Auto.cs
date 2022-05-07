namespace Logica
{
    public class Auto
    {
        private bool Encendido { get; set; }
        private int VelocidadActual { get; set; }
        private int VelocidadMaxima { get; set; }

        public delegate bool ArrancarAuto();
        public delegate string Velocidad(int velocidad);

        public EventHandler<EventoArgs> ExcesoVelocidadMaxima;

        public Auto()
        {
            Encendido = false;
            VelocidadActual = 50;
            VelocidadMaxima = 100;
        }
        private void Encender()
        {
            Encendido = true;
        }

        private void Apagar()
        {
            Encendido = false;
        }

        private void SubirVelocidad(int velocidad)
        {
            VelocidadActual = velocidad;
        }

        private void BajarVelocidad(int velocidad)
        {
            VelocidadActual = velocidad;
        }

        public bool Arrancar()
        {
            if(Encendido == false)
            {
                Encender();
                return true;
            }
            return false;
        }

        public string ModificarVelocidad(int velocidad)
        {
            if (velocidad == 0)
            {
                Apagar();
                return "Se apagó el auto.";
            }
            else if(velocidad > VelocidadActual)
            {
                if(velocidad > VelocidadMaxima)
                {
                    this.ExcesoVelocidadMaxima(this, new EventoArgs() { VelocidadMaxima = this.VelocidadMaxima });
                    return "Debe ser una velocidad menor a la velocidad maxima.";
                }
                else
                {
                    int velocidadVieja = VelocidadActual;
                    SubirVelocidad(velocidad);
                    return $"Aumento de la velocidad de {Math.Abs(velocidadVieja - velocidad)}km/h.";
                }
                
            }
            else
            {
                int velocidadVieja = VelocidadActual;
                BajarVelocidad(velocidad);
                return $"Disminuye la velocidad en {Math.Abs(velocidadVieja - velocidad)}km/h.";
            }  
        }
    }

    public class EventoArgs : EventArgs
    {
        public int VelocidadMaxima { get; set; }
    }
}