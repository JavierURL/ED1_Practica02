using ED1_Practica2.Models;
using Microsoft.AspNetCore.Mvc;

namespace ED1_Practica2.Controllers
{
    public class CargaManualJugadoresController : Controller
    {
        private List<Jugadores> _listDeJugadores = new List<Jugadores>()
        {
            new Jugadores { Nombre = "Lester", Apellido = "Andrade", Rol = "SDI", KDA = "6.20", CreepScore = "110", Equipo = "OVEJAS"},
            new Jugadores { Nombre = "Juan", Apellido = "Esquivel", Rol = "SD", KDA = "7.30", CreepScore = "115", Equipo = "OVEJAS"},
            new Jugadores { Nombre = "Paul", Apellido = "Flores", Rol = "MD", KDA = "5.10", CreepScore = "83", Equipo = "OVEJAS"},

            new Jugadores { Nombre = "Sebastian", Apellido = "Catrillo", Rol = "POR", KDA = "7.20", CreepScore = "98", Equipo = "KUNISPORTS"},
            new Jugadores { Nombre = "Jorge", Apellido = "Woo", Rol = "DFI", KDA = "5.50", CreepScore = "104", Equipo = "KUNISPORTS"},
            new Jugadores { Nombre = "Alejandro", Apellido = "Ventura", Rol = "LIB", KDA = "9.90", CreepScore = "120", Equipo = "KUNISPORTS"},

            new Jugadores { Nombre = "Bob", Apellido = "Reus", Rol = "DFI", KDA = "6.40", CreepScore = "110", Equipo = "MINIONS FC"},
            new Jugadores { Nombre = "Stuart", Apellido = "Brady", Rol = "POR", KDA = "4.60", CreepScore = "140", Equipo = "MINIONS FC"},
            new Jugadores { Nombre = "Kevin", Apellido = "Volante", Rol = "DC", KDA = "8.40", CreepScore = "100", Equipo = "MINIONS FC"},

            new Jugadores { Nombre = "Nicolas", Apellido = "Solarez", Rol = "CAD", KDA = "6.30", CreepScore = "80", Equipo = "PIO FC"},
            new Jugadores { Nombre = "Leandro", Apellido = "Shimida", Rol = "MCD", KDA = "4.10", CreepScore = "115", Equipo = "PIO FC"},
            new Jugadores { Nombre = "Rodrigo", Apellido = "Ramirez", Rol = "LIB", KDA = "7.20", CreepScore = "95", Equipo = "PIO FC"},
        };


        public IActionResult Index()
        {
            return View(_listDeJugadores);
        }
    }
}
