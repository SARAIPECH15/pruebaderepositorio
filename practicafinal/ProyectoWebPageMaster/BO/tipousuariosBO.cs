using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using ProyectoWebPageMaster.DAO;

namespace ProyectoWebPageMaster.BO
{
    public class tipousuariosBO
    {

        private int id_tipousuario;
        private string nombre;

        public int Id_tipousuario { get => id_tipousuario; set => id_tipousuario = value; }
        public string Nombre { get => nombre; set => nombre = value; }


    }
}