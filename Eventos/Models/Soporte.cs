namespace Eventos.Models
{
    public class Soporte
    {
        public int Id { get; set; }
        public String Nombre_Soporte { get; set; }
        public String email_Soporte { get; set; }
        public String contraseña_Soporte { get; set; }

        public Soporte() { }
        public Soporte(int Id, String Nombre_Soporte,  String email_Soporte, String contraseña_Soporte ) {

            Id = Id;
            Nombre_Soporte = Nombre_Soporte;
            email_Soporte = email_Soporte;
            contraseña_Soporte = contraseña_Soporte;
        
        
        }


    }
}
