namespace Eventos.Models
{
    public class cat_evento
    {
       public int Id { get; set; }
        public String Nombre_Cat { get; set; }
        public String Precio_cat_Entrada { get; set; }
        public String contraseña_cat { get; set; }

        public cat_evento() { }
        public cat_evento(int Id,
         String Nombre_Cat,
       String Precio_cat_Entrada,
     String contraseña_cat) {


            Id = Id;
            Nombre_Cat = Nombre_Cat;
            Precio_cat_Entrada = Precio_cat_Entrada;
            contraseña_cat = contraseña_cat;
        
        
        }
    }
}
