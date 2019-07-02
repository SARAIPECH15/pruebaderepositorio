using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProyectoWebPageMaster.BO;
using ProyectoWebPageMaster.DAO;
using System.Data;


namespace ProyectoWebPageMaster.DAO
{
	public class registro_dao
	{

		Conexion objConectar = new Conexion();


		

		public int agregarusuario(registro_bo objusuario)
		{
			//inserta y devuelve el ultimo el id insertado

			//LLAMA AL CIMANDO PORQUE ES UN INSERT

			int id = objConectar.EjecutarComando("INSERT INTO USUARIO (FOTO,USUARIO,CONTRASENIA,NOMBRE,APELLIDO,DIRECCION,ID_TIPOUSUARIO, COD_PAIS,COD_CIU,Email) output INSERTED.ID_US values('"+objusuario.Fotoperfil+ "','" + objusuario.Usuario + "','" + objusuario.Comtrasena + "','" + objusuario.Nombre + "','"+objusuario.Apeliido+ "','" + objusuario.Direccion+ "','"+objusuario.Id_tipous+"','" + objusuario.Cod_pais + "','" + objusuario.Cod_ciu + "','" + objusuario.Email + "')");
			return id;

		}
		public int modificarusuario(registro_bo objusuario)
		{
			int id = objConectar.EjecutarComando(string.Format("update usuarios set nombre='{0}',email='{1}',usuario='{2}',pass_usuario='{3}',fotoperfil='{4}' where id={5}", objusuario.Nombre, objusuario.Email, objusuario.Usuario, objusuario.Comtrasena, objusuario.Fotoperfil, objusuario.Id));
			return 1;
		}

		public int eliminarusuario(registro_bo objusuario)
		{
			int id = objConectar.EjecutarComando(string.Format("delete from usuarios where id={0}", objusuario.Id));
			return 1;
		}


		public int verificar_login(registro_bo	 objbo)
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
		public void busca_usuario(registro_bo objbo)
		{
			DataSet datos = objConectar.EjecutarSentencia("select * from usuarios where id=" + objbo.Id);
			objbo.Email = datos.Tables[0].Rows[0]["email"].ToString();
			objbo.Nombre = datos.Tables[0].Rows[0]["nombre"].ToString();
			objbo.Comtrasena = datos.Tables[0].Rows[0]["pass_usuario"].ToString();
			objbo.Usuario = datos.Tables[0].Rows[0]["usuario"].ToString();
			objbo.Fotoperfil = datos.Tables[0].Rows[0]["fotoperfil"].ToString();

		}

	}
}