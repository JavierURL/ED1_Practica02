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
            ListaDeEquipos.Add(new Equipo() { nombre = "DUX", coach = "Nacho Castro", creacion = "2017", liga = "KingsLeague" });
            ListaDeEquipos.Add(new Equipo() { nombre = "KUNISPORTS", coach = "Martín Posse", creacion = "2019", liga = "KingsLeague" });
            ListaDeEquipos.Add(new Equipo() { nombre = "ElBARRIO", coach = "Juan Arroita", creacion = "2022", liga = "KingsLeague" });
            ListaDeEquipos.Add(new Equipo() { nombre = "PIOFC", coach = "Gerrardo Torrado", creacion = "2022", liga = "KingsLeague" });









            jugadores = new Jugadores();

            //Jugadores del equipo de DUX

            ListaDeJugadores.Add(new Jugadores() { nombre = "Cardona", apellido = "Coro", equipo = "DRX", rol = "ADC", kda = 7.60, cs = 205 });
            ListaDeJugadores.Add(new Jugadores() { nombre = "Victor", apellido = "Bocel", equipo = "DRX", rol = "Jungla", kda = 7.90, cs = 98 });
            ListaDeJugadores.Add(new Jugadores() { nombre = "Joan Inés", apellido = "Castellanos", equipo = "DRX", rol = "SUP", kda = 4.50, cs = 21 });
            ListaDeJugadores.Add(new Jugadores() { nombre = "Ruggeri", apellido = "Hyeok", equipo = "DRX", rol = "MID", kda = 4.00, cs = 97 });
            ListaDeJugadores.Add(new Jugadores() { nombre = "Hidalgo", apellido = "Kyoya", equipo = "DRX", rol = "TOP", kda = 6.70, cs = 77 });


            //Jugadores del equipo de KuniSports 

            ListaDeJugadores.Add(new Jugadores() { nombre = "Jorge", apellido = "Woo", equipo = "KPS", rol = "ADC", kda = 6.40, cs = 205 });
            ListaDeJugadores.Add(new Jugadores() { nombre = "Allam", apellido = "lee", equipo = "KPS", rol = "DFI", kda = 4.60, cs = 104 });
            ListaDeJugadores.Add(new Jugadores() { nombre = "Nicolas", apellido = "Gómez", equipo = "KPS", rol = "MCD", kda = 6.90, cs = 21 });
            ListaDeJugadores.Add(new Jugadores() { nombre = "Gustavo", apellido = "Fernandez", equipo = "KPS", rol = "EL", kda = 7.50, cs = 11 });
            ListaDeJugadores.Add(new Jugadores() { nombre = "Leandro", apellido = "Rodríguez", equipo = "KPS", rol = "DC", kda = 6.80, cs = 75 });


            //Jugadores del equipo de El Barrio

            ListaDeJugadores.Add(new Jugadores() { nombre = "Oscar", apellido = "Wun", equipo = "Fnatic", rol = "ADC", kda = 5.40, cs = 190 });
            ListaDeJugadores.Add(new Jugadores() { nombre = "Joselu", apellido = "Martinez", equipo = "Fnatic", rol = "Jungla", kda = 7.60, cs = 112 });
            ListaDeJugadores.Add(new Jugadores() { nombre = "", apellido = "Paredez", equipo = "Fnatic", rol = "SUP", kda = 9.20, cs = 29 });
            ListaDeJugadores.Add(new Jugadores() { nombre = "", apellido = "Melano", equipo = "Fnatic", rol = "MID", kda = 7.30, cs = 123 });
            ListaDeJugadores.Add(new Jugadores() { nombre = "Jacobo", apellido = "Segura", equipo = "Fnatic", rol = "TOP", kda = 8.40, cs = 79 });


            //Jugadores del equipo de Pio FC 

            ListaDeJugadores.Add(new Jugadores() { nombre = "Jorge", apellido = "Solarez", equipo = "Mad lions", rol = "ADC", kda = 9.40, cs = 170 });
            ListaDeJugadores.Add(new Jugadores() { nombre = "Carlos", apellido = "Ventura", equipo = "Mad lions", rol = "Jungla", kda = 6.50, cs = 122 });
            ListaDeJugadores.Add(new Jugadores() { nombre = "Adrian", apellido = "Shimada", equipo = "Mad lions", rol = "SUP", kda = 6.20, cs = 31 });
            ListaDeJugadores.Add(new Jugadores() { nombre = "Rodrigo", apellido = "Ramirez", equipo = "Mad lions", rol = "MID", kda = 8.30, cs = 135 });
            ListaDeJugadores.Add(new Jugadores() { nombre = "Santiago", apellido = "Cifuentes", equipo = "Mad lions", rol = "TOP", kda = 8.00, cs = 80 });
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