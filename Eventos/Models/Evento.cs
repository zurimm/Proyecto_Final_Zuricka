namespace Eventos.Models
{
    public class Evento
    {
       public int Id { get; set; }
        public String Nombre_evento { get; set; }
        public String Descripcion_evento { get; set; }
        public String fecha_Evento { get; set; }
        public String hora_evento { get; set; }
        public int espacios_evento { get; set; }

        public Evento  () { }
        public Evento(int Id_Evento, String nombre_evento, String descripcion_evento, String fecha_Evento ,
        String hora_evento, int espacios_evento ) {

            Id_Evento = Id_Evento;
            nombre_evento = nombre_evento;
            descripcion_evento = descripcion_evento;
            fecha_Evento = fecha_Evento;
            hora_evento = hora_evento;
            espacios_evento = espacios_evento;
        
        }



    }
}
