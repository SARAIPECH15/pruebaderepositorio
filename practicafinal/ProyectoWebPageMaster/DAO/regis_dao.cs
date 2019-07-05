using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProyectoWebPageMaster.DAO;
using ProyectoWebPageMaster.BO;
using System.Data;
using System.Data.SqlClient;
namespace ProyectoWebPageMaster.DAO
{
	public class regis_dao
	{


		Conexion objConectar = new Conexion();




		public int agregarusuario(registro_boo objusuario)
		{
			//inserta y devuelve el ultimo el id insertado

			//LLAMA AL CIMANDO PORQUE ES UN INSERT

			int id = objConectar.EjecutarComando("INSERT INTO USUARIO (FOTO,USUARIO,CONTRASENIA,NOMBRE,APELLIDO,DIRECCION,ID_TIPOUSUARIO, COD_PAIS,COD_CIU,Email) output INSERTED.ID_US values('" + objusuario.Fotoperfil + "','" + objusuario.Usuario + "','" + objusuario.Comtrasena + "','" + objusuario.Nombre + "','" + objusuario.Apeliido + "','" + objusuario.Direccion + "','" + objusuario.Id_tipous + "','" + objusuario.Cod_pais + "','" + objusuario.Cod_ciu + "','" + objusuario.Email + "')");
			return id;

		}
	


		public int verificar_login(registro_boo objbo)
		{
			DataSet datos = objConectar.EjecutarSentencia("select id from usuarios where usuario='" + objbo.Usuario + "' and pass_usuario='" + objbo.Comtrasena + "'");
			int id = 0;

			if (datos.Tables[0].Rows.Count > 0)
			{
				id = Convert.ToInt32(datos.Tables[0].Rows[0]["id"]);

			}
			return id;
		}


		//de aqui nos fuimos a bienvenido GUI para ver lo de foto




		//sirve para busar al usuario al validar sesion
		public void busca_usuario(registro_boo objbo)
		{
			DataSet datos = objConectar.EjecutarSentencia("select * from usuario where ID_US=" + objbo.Id);
			objbo.Email = datos.Tables[0].Rows[0]["Email"].ToString();
			objbo.Nombre = datos.Tables[0].Rows[0]["NOMBRE"].ToString();
			objbo.Comtrasena = datos.Tables[0].Rows[0]["CONTRASENIA"].ToString();
			objbo.Usuario = datos.Tables[0].Rows[0]["USUARIO"].ToString();
			objbo.Fotoperfil = datos.Tables[0].Rows[0]["FOTO"].ToString();

		}


        public DataSet buscar_usuarios()
        {
            DataSet datos = objConectar.EjecutarSentencia("select * from usuario");
            return datos;

        }


        public int modificarusuario(registro_boo objusuario)
        {
            int id = objConectar.EjecutarComando(string.Format("update usuario set NOMBRE='{0}',Email='{1}',USUARIO='{2}',CONTRASENIA='{3}',FOTO='{4}',APELLIDO='{5}',DIRECCION='{6}',COD_PAIS={7},COD_CIU={8},ID_TIPOUSUARIO={9} where ID_US={10}", objusuario.Nombre, objusuario.Email, objusuario.Usuario,objusuario.Comtrasena,objusuario.Fotoperfil, objusuario.Apeliido, objusuario.Direccion,objusuario.Cod_pais,objusuario.Cod_ciu,objusuario.Id_tipous, objusuario.Id));
            return 1;
        }


        public int eliminarusuario(registro_boo objusuario)
        {
            int id = objConectar.EjecutarComando(string.Format("delete from usuario where ID_US={0}", objusuario.Id));
            return 1;
        }


        public DataSet Consultar(string strSQL)
        {
            objConectar.establecerConexion();
            objConectar.abrirConexion();
            SqlCommand cmd = new SqlCommand(strSQL, objConectar.establecerConexion());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            objConectar.cerrarConexion();
            return ds;

        }




    }
}