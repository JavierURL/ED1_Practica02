using ED1_Practica2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ED1_Practica2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public string Index()
        {
            return 
                "\nEQUIPOS" +
                "\nPara acceder a la carga manual de los equipos agregue a la URL:  /CargaManualEquipos " +
                "\nPara acceder a la carga por archivo de los equipos agregue a la URL: /CargaArchivosEquipos/SubirArchivo" +
                "\n\nJUGADORES" +
                "\nPara acceder a la carga manual de los jugadores agregue a la URL: /CargaManualJugadores " +
                "\nPara acceder a la carga por archivo de los jugadores agregue a la URL: /CargaArchivosJugadores/SubirArchivo";
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