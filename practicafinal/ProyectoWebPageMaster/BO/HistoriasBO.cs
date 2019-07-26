﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;

namespace ProyectoWebPageMaster.BO
{
    public class HistoriasBO
    {

        private int codig_his;
        private string foto;
        private int idautoriza;
        private int idautor;
        private DateTime fechaPublico;
        private string nombre;
        private int codigo_cat;
        private int codigo_est;
        private string prologo;
		private int cod_cap;
		private string contenido;
		private int estado_cap;
		private string nombre_cap;
		private string numero_cap;
		private string nombreusu;

		private string AA;

		public int Codig_his { get => codig_his; set => codig_his = value; }
	
		public string Foto { get => foto; set => foto = value; }
        public int Idautoriza { get => idautoriza; set => idautoriza = value; }
        public int Idautor { get => idautor; set => idautor = value; }
        public DateTime FechaPublico { get => fechaPublico; set => fechaPublico = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Codigo_cat { get => codigo_cat; set => codigo_cat = value; }
        public int Codigo_est { get => codigo_est; set => codigo_est = value; }
        public string Prologo { get => prologo; set => prologo = value; }
		public int Cod_cap { get => cod_cap; set => cod_cap = value; }
		public string Contenido { get => contenido; set => contenido = value; }
		public int Estado_cap { get => estado_cap; set => estado_cap = value; }
		public string Nombre_cap { get => nombre_cap; set => nombre_cap = value; }
		public string Numero_cap { get => numero_cap; set => numero_cap = value; }
		public string Nombreusu { get => nombreusu; set => nombreusu = value; }

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