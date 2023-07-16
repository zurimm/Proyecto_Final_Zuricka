namespace Eventos.Models
{
    public class Metodo_pago
    {
        public int Id { get; set; }
        public int Numero_Tarjeta { get; set; }
        public String Fecha_vencimiento { get; set; }
        public int CVV { get; set; }
        public String Nombre_tarjeta { get; set; }

        public Metodo_pago() { }
        public Metodo_pago(int Id, int Numero_Tarjeta, String Fecha_vencimiento, int CVV, 
        String Nombre_tarjeta ) {

            Id = Id ;
            Numero_Tarjeta = Numero_Tarjeta;
            Fecha_vencimiento = Fecha_vencimiento;
            CVV = CVV;
            Nombre_tarjeta = Nombre_tarjeta;
        
        }

    }
}
