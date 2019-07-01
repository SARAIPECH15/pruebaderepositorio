using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProyectoWebPageMaster.DAO;

namespace ProyectoWebPageMaster.BO
{
    public class pais_BO
    {

        private int cod_pais;
        private int cod_estado;
        private string nombre;

        public int Cod_pais { get => cod_pais; set => cod_pais = value; }
       
        public string Nombre { get => nombre; set => nombre = value; }
    }
}