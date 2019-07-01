using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoWebPageMaster.BO
{
    public class UsuariosBO
    {
        private int id_us;
        private string foto;
        private string usuario;
        private string contrasenia;
        private string nombre;
        private string apellido;
        private string direccion;
        private int id_tipousuario;
        private int cod_pais;

        public int Id_us { get => id_us; set => id_us = value; }
        public string Foto { get => foto; set => foto = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Contrasenia { get => contrasenia; set => contrasenia = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Id_tipousuario { get => id_tipousuario; set => id_tipousuario = value; }
        public int Cod_pais { get => cod_pais; set => cod_pais = value; }




    }
}