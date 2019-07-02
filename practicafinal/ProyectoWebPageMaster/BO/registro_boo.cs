using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;

namespace ProyectoWebPageMaster.BO
{
	public class registro_boo
	{
		private int id;
		private string fotoperfil;
		private string nombre;
		private string email;
		private string usuario;
		private string contrasenia;
		private string apeliido;
		private string direccion;
		private int cod_pais;
		private int cod_ciu;
		private int id_tipous;

		public int Id { get => id; set => id = value; }
		public string Fotoperfil { get => fotoperfil; set => fotoperfil = value; }
		public string Nombre { get => nombre; set => nombre = value; }
		public string Email { get => email; set => email = value; }
		public string Usuario { get => usuario; set => usuario = value; }
		public string Comtrasena { get => contrasenia; set => contrasenia = value; }
		public string Apeliido { get => apeliido; set => apeliido = value; }
		public string Direccion { get => direccion; set => direccion = value; }
		public int Cod_pais { get => cod_pais; set => cod_pais = value; }
		public int Cod_ciu { get => cod_ciu; set => cod_ciu = value; }
		public int Id_tipous { get => id_tipous; set => id_tipous = value; }

		public Image RedimencionarImagen(Image Imgoriginal, int Altoimg)
		{
			var Radio = (double)Altoimg / Imgoriginal.Height;//diferencia entre la imagenes
			var NuevoAncho = (int)(Imgoriginal.Width * Radio);
			var NuevoAlto = (int)(Imgoriginal.Height * Radio);
			var ImagenRedimencionada = new Bitmap(NuevoAncho, NuevoAlto);
			//creo archivo apartir del bitmap con las nuevas dimensiones
			var g = Graphics.FromImage(ImagenRedimencionada);
			g.DrawImage(Imgoriginal, 0, 0, NuevoAncho, NuevoAlto);
			return ImagenRedimencionada;
		}
	}
}