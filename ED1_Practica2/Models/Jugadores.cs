namespace ED1_Practica2.Models
{
    public class Jugadores
    {
        [Name("Nombre")]
        public String nombre { get; set; }
        [Name("Apellido")]
        public String apellido { get; set; }
        [Name("Rol")]
        public String rol { get; set; }
        [Name("KDA")]
        public double kda { get; set; }
        [Name("Creep Score")]
        public float cs { get; set; }
        [Name("Equipo")]
        public String equipo { get; set; }
        public Jugadores()
        { }


        public Jugadores(String name, String apellido, String Rol, double KDA, float CreepScore, String Equipo)
        {
            this.nombre = name;
            this.apellido = apellido;
            this.rol = Rol;
            this.kda = KDA;
            this.cs = CreepScore;
            this.equipo = Equipo;

        }
    }
}
