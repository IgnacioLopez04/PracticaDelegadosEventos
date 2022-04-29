namespace Ejercicio1
{
    public class Persona
    {
        public EventHandler<NombreModificadoClase> NombreModificado;

        public delegate string actualizacionNombreCompletado(string nombre);

        private string Nombre { get; set; }

        public string ActualizarNombre(string nombreNuevo)
        {
            Nombre = nombreNuevo;
            this.NombreModificado(this, new NombreModificadoClase() { NombreNuevo = nombreNuevo, NombreViejo = "Juan"});

            return Nombre;
        }
    }

    public class NombreModificadoClase : EventArgs
    {
        public string NombreViejo { get; set; }
        public string NombreNuevo { get; set; }
    }
    
}