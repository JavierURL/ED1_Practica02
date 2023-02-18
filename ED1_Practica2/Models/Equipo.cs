namespace ED1_Practica2.Models
{
    public class Equipo
    {
        [Name("Nombre")]
        public String nombre { get; set; }
        [Name("Coach")]
        public String coach { get; set; }
        [Name("Liga")]
        public String liga { get; set; }
        [Name("Fecha_creacion")]
        public String creacion { get; set; }



        public Equipo()
        { }
        public Equipo(String nom, String Coach, String Liga, String Creacion)
        {
            this.nombre = nom;
            this.coach = Coach;
            this.liga = Liga;
            this.creacion = Creacion;

        }
    }
}
