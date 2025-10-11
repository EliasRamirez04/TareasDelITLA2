namespace ComunidadApp.Modelos
{
    public class MiembroDeLaComunidad
    {
        public string Nombre { get; set; }
        public string Cedula { get; set; }

        public virtual void MostrarInfo()
        {
            Console.WriteLine($"Nombre: {Nombre}, Cédula: {Cedula}");
        }
    }
}