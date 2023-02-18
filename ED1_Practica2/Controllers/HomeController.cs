using ED1_Practica2.Models;
using Microsoft.AspNetCore.Mvc;

using System.Diagnostics;

namespace ED1_Practica2.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;
        private readonly Equipo equipos;
        private readonly Jugadores jugadores;
        List<Equipo> ListaDeEquipos = new List<Equipo>();
        List<Jugadores> ListaDeJugadores = new List<Jugadores>();




        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;


            equipos = new Equipo();
            ListaDeEquipos.Add(new Equipo() { nombre = "OVEJAS", coach = "Luis Guerra", creacion = "2018", liga = "KingsLeague" });
            ListaDeEquipos.Add(new Equipo() { nombre = "KUNISPORTS", coach = "Martín Posse", creacion = "2019", liga = "KingsLeague" });
            ListaDeEquipos.Add(new Equipo() { nombre = "MINIONSFC", coach = "Gru Martin", creacion = "2020", liga = "KingsLeague" });
            ListaDeEquipos.Add(new Equipo() { nombre = "PIOFC", coach = "Gerrardo Torrado", creacion = "2022", liga = "KingsLeague" });









            jugadores = new Jugadores();

            //Jugadores del equipo de OVEJAS

            ListaDeJugadores.Add(new Jugadores() { nombre = "Lester", apellido = "Andrade", equipo = "OVEJAS", rol = "SDI", kda = 6.20, cs = 110 });
            ListaDeJugadores.Add(new Jugadores() { nombre = "Juan", apellido = "Flores", equipo = "OVEJAS", rol = "MD", kda = 5.10, cs = 115 });
            ListaDeJugadores.Add(new Jugadores() { nombre = "Paul", apellido = "Esquivel", equipo = "OVEJAS", rol = "SD", kda = 7.30, cs = 83 });
            ListaDeJugadores.Add(new Jugadores() { nombre = "Sebastian", apellido = "Castrillo", equipo = "OVEJAS", rol = "DFC", kda = 6.60, cs = 74 });
            ListaDeJugadores.Add(new Jugadores() { nombre = "Rodrigo", apellido = "Vetel", equipo = "OVEJAS", rol = "POR", kda = 4.40, cs = 96 });


            //Jugadores del equipo de KUNISPORTS 

            ListaDeJugadores.Add(new Jugadores() { nombre = "Jorge", apellido = "Woo", equipo = "KUNISPORTS", rol = "POR", kda = 6.40, cs = 205 });
            ListaDeJugadores.Add(new Jugadores() { nombre = "Allam", apellido = "lee", equipo = "KUNISPORTS", rol = "DFI", kda = 4.60, cs = 104 });
            ListaDeJugadores.Add(new Jugadores() { nombre = "Nicolas", apellido = "Gómez", equipo = "KUNISPORTS", rol = "MCD", kda = 6.90, cs = 21 });
            ListaDeJugadores.Add(new Jugadores() { nombre = "Gustavo", apellido = "Fernandez", equipo = "KUNISPORTS", rol = "LIB", kda = 7.50, cs = 11 });
            ListaDeJugadores.Add(new Jugadores() { nombre = "Leandro", apellido = "Rodríguez", equipo = "KUNISPORTS", rol = "DC", kda = 6.80, cs = 75 });


            //Jugadores del equipo de MINIONS FC

            ListaDeJugadores.Add(new Jugadores() { nombre = "Bob", apellido = "Villavicencio", equipo = "MINIONSFC", rol = "LIB", kda = 4.30, cs = 70 });
            ListaDeJugadores.Add(new Jugadores() { nombre = "Stuart", apellido = "Brady", equipo = "MINIONSFC", rol = "CAI", kda = 6.80, cs = 90 });
            ListaDeJugadores.Add(new Jugadores() { nombre = "Neffario", apellido = "Roell", equipo = "MINIONSFC", rol = "MCD", kda = 5.60, cs = 126 });
            ListaDeJugadores.Add(new Jugadores() { nombre = "Herb", apellido = "Volante", equipo = "MINIONSFC", rol = "MD", kda = 9.30, cs = 111 });
            ListaDeJugadores.Add(new Jugadores() { nombre = "Kevin", apellido = "Reus", equipo = "MINIONSFC", rol = "MC", kda = 3.60, cs = 88 });


            //Jugadores del equipo de PIO FC 

            ListaDeJugadores.Add(new Jugadores() { nombre = "Jorge", apellido = "Solarez", equipo = "PIOFC", rol = "SD", kda = 9.40, cs = 170 });
            ListaDeJugadores.Add(new Jugadores() { nombre = "Carlos", apellido = "Ventura", equipo = "PIOFC", rol = "POR", kda = 6.50, cs = 122 });
            ListaDeJugadores.Add(new Jugadores() { nombre = "Adrian", apellido = "Shimada", equipo = "PIOFC", rol = "SDI", kda = 6.20, cs = 31 });
            ListaDeJugadores.Add(new Jugadores() { nombre = "Rodrigo", apellido = "Ramirez", equipo = "PIOFC", rol = "DFI", kda = 8.30, cs = 135 });
            ListaDeJugadores.Add(new Jugadores() { nombre = "Santiago", apellido = "Cifuentes", equipo = "PIOFC", rol = "CAD", kda = 8.00, cs = 80 });
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}