using ED1_Practica2.Models;
using Microsoft.AspNetCore.Mvc;

namespace ED1_Practica2.Controllers
{
    public class CargaManualEquiposController : Controller
    {
        private List<Equipos> _listDeEquipos = new List<Equipos>()
        {
            new Equipos { Nombre = "OVEJAS", Coach = "Luis Guerra", Liga = "Primera division", Creacion = "2018"},
            new Equipos { Nombre = "KUNISPORTS", Coach = "Martin Posse", Liga = "Segunda division", Creacion = "2019"},
            new Equipos { Nombre = "MINIONS FC", Coach = "Gru Silliane", Liga = "Primera division", Creacion = "2020"},
            new Equipos { Nombre = "PIO FC", Coach = "Gerardo Torrado", Liga = "Tercera division", Creacion = "2022"},
            new Equipos { Nombre = "Las Perritas FC", Coach = "Fernando García", Liga = "Segunda division", Creacion = "2020"}
        };


        public IActionResult Index()
        {
            return View(_listDeEquipos);
        }
    }
}
