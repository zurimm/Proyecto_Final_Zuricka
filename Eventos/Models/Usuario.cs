using Microsoft.VisualBasic;

namespace Eventos.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public String Nombre_Usuario { get; set; }
        public String email { get; set; }
        public String contraseña_usuario { get; set; }
        public String nacimiento { get; set; }

        public Usuario() { }

        public Usuario(int Id , String Nombre_Usuario , String email ,String contraseña_usuario ,String nacimiento ) {

            Id = Id;
            Nombre_Usuario = Nombre_Usuario;
            email = email;
            contraseña_usuario = contraseña_usuario;
            nacimiento = nacimiento;
        
        
        }
    }
}
