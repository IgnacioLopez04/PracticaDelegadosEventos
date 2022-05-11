namespace Logica
{
    public class Persona
    {
        private string Nombre { get; set; }

        public EventHandler<actualizacionNombreCompleto> NombreModificado;

        public void ActualizarNombre(string nombreNuevo)
        {
            this.NombreModificado(this, new actualizacionNombreCompleto() { NombreNuevo = nombreNuevo, NombreViejo = "Juan" });
            Nombre = nombreNuevo;
        }
    }

    public class actualizacionNombreCompleto : EventArgs
    {
        public string NombreNuevo { get; set; }
        public string NombreViejo { get; set; }
    }
}