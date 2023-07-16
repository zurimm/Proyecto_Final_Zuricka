using System.ComponentModel.DataAnnotations;

namespace Eventos.Models
{
    public class Administrador
    {



        public int Id { get; set; }
        public String Nombre_Adm { get; set; }
        public String email_Adm { get; set; }
        public String contraseña_Adm { get; set; }

        public Administrador() { }
        public Administrador(int Id,
        String Nombre_Adm,
        String email_Adm,
        String contraseña_Adm ) {

            Id = Id;
            Nombre_Adm = Nombre_Adm;
            email_Adm = email_Adm;
            contraseña_Adm = contraseña_Adm;
        
        }

    }
}
