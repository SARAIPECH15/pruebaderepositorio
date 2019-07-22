using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoWebPageMaster.BO
{
    public class CapituloBO
    {



        private int codigo_cap;
        private int codig_his;
        private DateTime fecha_rzo;
        private string nombre;
        private int numero;
        private int codigo_est;
        private string contenido;

        public int Codigo_cap { get => codigo_cap; set => codigo_cap = value; }
        public int Codig_his { get => codig_his; set => codig_his = value; }
        public DateTime Fecha_rzo { get => fecha_rzo; set => fecha_rzo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Numero { get => numero; set => numero = value; }
        public int Codigo_est { get => codigo_est; set => codigo_est = value; }
        public string Contenido { get => contenido; set => contenido = value; }




    }
}