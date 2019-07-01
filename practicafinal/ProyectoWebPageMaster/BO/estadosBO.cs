using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoWebPageMaster.BO
{
    public class estadosBO
    {

        private int cod_estado;
        private string nombre;
        private int COD_PAIS;

        public int Cod_estado { get => cod_estado; set => cod_estado = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int COD_PAIS1 { get => COD_PAIS; set => COD_PAIS = value; }
    }
}