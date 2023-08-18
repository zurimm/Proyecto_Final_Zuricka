namespace Eventos.Models
{
    public class SporteUnificado
    {
        public int Id { get; set; }
        public Administrador DatosAdministrador { get; set; }
        public Soporte DatosSoporte { get; set; }

        public Usuario DatosUsuario { get; set; }

    }
}
