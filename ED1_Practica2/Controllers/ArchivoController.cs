using ED1_Practica2.Models;
using Microsoft.AspNetCore.Mvc;

namespace ED1_Practica2.Controllers
{
	[Route("[controller]")]
	public class ArchivoController : Controller
	{


		List<Jugadores> _listadesdearchivo = new List<Jugadores>();

		public IActionResult Index()
		{
			return View();
		}
		[HttpPost("LeerArchivo")]


		public IActionResult SubirArchivo(IFormFile archivo)
		{
			if (archivo != null)
			{
				try
				{
					//Crear una copia del archivo recibido
					string ruta = Path.Combine(Path.GetTempPath(), archivo.Name);
					using (var stream = new FileStream(ruta, FileMode.Create))
					{
						archivo.CopyTo(stream); //Copiar el contenido del archivo
					}

					//Leer el arhivo
					string informacionArchivo = System.IO.File.ReadAllText(ruta);
					//Obtener lineas del archivo y llenar lista
					foreach (string linea in informacionArchivo.Split('\n'))
					{
						if (!string.IsNullOrEmpty(linea))
						{
							//Extraer la informacion de cada persona
							string[] FilaActual = linea.Split(',');
							_listadesdearchivo.Add(new Jugadores
							{

								Nombre = FilaActual[0],
								Rol = FilaActual[1],
								KDA = Convert.ToInt32(FilaActual[2]),
								CreepScore = Convert.ToInt32((FilaActual[3]))



							});


						}
					}
				}
				catch (Exception e)
				{
					ViewBag.Error = "Error el archivo no puede ser leido" + e.Message;
				}
			}
			else
			{
				ViewBag.Error = "La ruta de lectura es incorrecta";
			}

			return View(_listadesdearchivo);
		}

		[Route("CargarArchivo")]

		public IActionResult SubirArchivo()
		{
			return View();
		}

	}
}
