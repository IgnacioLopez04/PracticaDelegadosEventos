namespace Logica
{
    public class Ascensor
    {
        private int Piso { get; set; }

        public EventHandler<PisoArgs> Evento;
        private void SubirPiso()
        {
            Piso += 1;
        }
        private void BajarPiso()
        {
            Piso -= 1;
        }
        public void DefinirPiso(int pisoNuevo)
        {
            int diferencia = Math.Abs(Piso - pisoNuevo);

            if (Piso > pisoNuevo)
            {
                for (int i = 0; i < diferencia; i++)
                {
                    BajarPiso();
                    this.Evento(this, new PisoArgs() { Piso = this.Piso });
                }
            }
            else
            {
                for (int i = 0; i < diferencia; i++)
                {
                    SubirPiso();
                    this.Evento(this, new PisoArgs() { Piso = this.Piso });
                }
            }
        }

        public void LlamarAscensor(int pisoActual)
        {
            Piso = pisoActual;
        }
    }

    public class PisoArgs : EventArgs
    {
        public int Piso { get; set; }
    }
}