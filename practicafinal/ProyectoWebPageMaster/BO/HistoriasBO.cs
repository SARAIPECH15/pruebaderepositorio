using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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

        public int Codig_his { get => codig_his; set => codig_his = value; }
        public string Foto { get => foto; set => foto = value; }
        public int Idautoriza { get => idautoriza; set => idautoriza = value; }
        public int Idautor { get => idautor; set => idautor = value; }
        public DateTime FechaPublico { get => fechaPublico; set => fechaPublico = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Codigo_cat { get => codigo_cat; set => codigo_cat = value; }
        public int Codigo_est { get => codigo_est; set => codigo_est = value; }


    }
}