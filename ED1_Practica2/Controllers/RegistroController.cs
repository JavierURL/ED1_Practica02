using ED1_Practica2.Models;
using Microsoft.AspNetCore.Mvc;

namespace ED1_Practica2.Controllers
{
	public class RegistroController : Controller
	{
		public ActionResult Registro()
		{
			return View(new Jugadores());
		}

		// POST JUGADOR

		[HttpPost]

		public ActionResult Registroo(Jugadores reg)
		{
			if (!ModelState.IsValid)
			{
				return View(reg);
			}
			ViewBag.mensaje = "ERROR";
			return View(reg);
		}
	}
}
}
