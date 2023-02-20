using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ED1_Practica2.Models
{
	public class Jugadores
	{
		[Display(Name = "Nombre")]
		[Required(AllowEmptyStrings = false, ErrorMessage = " Error los datos son invalidos")]
		[StringLength(50)]
		public string Nombre { get; set; }

		[Display(Name = "Apellido")]
		[Required(AllowEmptyStrings = false, ErrorMessage = " Error los datos son invalidos")]
		[StringLength(50)]
		public string Apellido { get; set; }


		[Display(Name = "Rol")]
		[Required(AllowEmptyStrings = false, ErrorMessage = " Error los datos son invalidos")]
		[StringLength(50)]
		public string Rol { get; set; }


		[Display(Name = "KDA")]
		[Required(AllowEmptyStrings = false, ErrorMessage = " Error los datos son invalidos")]
		[StringLength(50)]
		public decimal KDA { get; set; }


		[Display(Name = "Creep Score")]
		[Required(AllowEmptyStrings = false, ErrorMessage = " Error los datos son invalidos")]
		[StringLength(50)]
		public int CreepScore { get; set; }


		[Display(Name = "Equipo")]
		[Required(AllowEmptyStrings = false, ErrorMessage = " Error los datos son invalidos")]
		[StringLength(50)]
		public string Equipo { get; set; }
	}
}
