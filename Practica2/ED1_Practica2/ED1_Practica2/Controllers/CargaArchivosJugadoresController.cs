using ED1_Practica2.Models;
using Microsoft.AspNetCore.Mvc;

namespace ED1_Practica2.Controllers
{
    [Route("[controller]")]
    public class CargaArchivosJugadoresController : Controller
    {
        private List<Jugadores> _listDesdeArchivo = new List<Jugadores>();

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("subirarchivo")]
        public IActionResult SubirArchivo(IFormFile archivo)
        {
            if (archivo != null)
            {
                try
                {
                    //copia del archivo recibido en el servidor.
                    string ruta = Path.Combine(Path.GetTempPath(), archivo.Name); //ruta temporal del archivo
                    using (var stream = new FileStream(ruta, FileMode.Create))
                    {
                        archivo.CopyTo(stream); //copia el contenido del archivo
                    }


                    //leectura del archivo.     
                    string informacionArchivo = System.IO.File.ReadAllText(ruta);


                    //obtener lineas del archivo y llenar lista    
                    foreach (string linea in informacionArchivo.Split('\n'))
                    {
                        if (!string.IsNullOrEmpty(linea))
                        {
                            //obtener informacion de cada persona   
                            string[] FilaActual = linea.Split(',');
                            _listDesdeArchivo.Add(new Jugadores
                            {
                                Nombre = FilaActual[0],
                                Apellido = FilaActual[1],
                                Rol = FilaActual[2],
                                KDA = FilaActual[3],
                                CreepScore = FilaActual[4],
                                Equipo = FilaActual[5]
                            });
                        }
                    }

                }
                catch (Exception e)
                {

                    ViewBag.Error = "Error al leer el archivo." + e.Message;
                }
            }
            else
            {
                ViewBag.Error = "No se ha ingresado la ruta de archivo.";
            }
            return View(_listDesdeArchivo);
        }
    

        /*si el controller o metodo tiene una vista que va a RECIBIR Y MOSTRAR informacion, se debe crear otro metodo con la misma ruta y 
         *mismo nombre pero sin inlcuir el parametro, para que no diga que esta nulo o algo parecido*/
        [Route("subirarchivo")]
        public IActionResult SubirArchivo()
        {
            return View();
        }
    }
}
