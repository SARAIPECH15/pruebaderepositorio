using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using ProyectoWebPageMaster.DAO;
using ProyectoWebPageMaster.BO;

namespace ProyectoWebPageMaster.DAO
{
    public class UsuariosDAO
    {

        Conexion objConectar = new Conexion();

        public int verificar_login(UsuariosBO objbo)
        {
            DataSet datos = objConectar.EjecutarSentencia("select ID_US from USUARIO where USUARIO='" + objbo.Usuario + "' and CONTRASENIA='" + objbo.Contrasenia + "'");
            int id = 0;

            if (datos.Tables[0].Rows.Count > 0)
            {
                id = Convert.ToInt32(datos.Tables[0].Rows[0]["ID_US"]);

            }
            return id;
        }

        public void busca_usuario(UsuariosBO objbo)
        {
            DataSet datos = objConectar.EjecutarSentencia("select * from USUARIO where ID_US=" + objbo.Id_us);
            
            objbo.Nombre = datos.Tables[0].Rows[0]["NOMBRE"].ToString();
            objbo.Contrasenia = datos.Tables[0].Rows[0]["CONTRASENIA"].ToString();
            objbo.Usuario = datos.Tables[0].Rows[0]["USUARIO"].ToString();
           

        }

       

    }
}