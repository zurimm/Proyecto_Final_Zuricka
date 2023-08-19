namespace Eventos.Models
{
    public class Entrada
    {
        public int Id { get; set; }
        public String COSECUTIVO { get; set; }
        public Entrada() { }
        public Entrada(int id, String cosecutivo) {  Id = id; COSECUTIVO = cosecutivo; }



    }
}
