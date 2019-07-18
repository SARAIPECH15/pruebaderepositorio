using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProyectoWebPageMaster.BO;
using System.Data;
using ProyectoWebPageMaster.DAO;
using System.Data.SqlClient;

namespace ProyectoWebPageMaster.DAO
{
	public class crearhistorias_DAO
	{




		Conexion objConectar = new Conexion();




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



        public int agregarGeneroHistoria(Genero_Historia objgenero2)
        {
            //inserta y devuelve el ultimo el id insertado
            int id = objConectar.EjecutarComando("INSERT INTO HISTORIA_GENERO2 (CODIGO_GEN,CODIG_HIS) values('" + objgenero2.Codigo_genero+ "','"+objgenero2.Codigo_historia+"')");
            return id;

        }


        public int agregarHistoria(HistoriasBO objhistoria)
        {
            //inserta y devuelve el ultimo el id insertado
            int id = objConectar.EjecutarComando("INSERT INTO HISTORIA (FOTO,idAutor,FECHA_PUBL,NOMBRE,CODIGO_CAT,CODIGO_EST) output INSERTED.CODIG_HIS values('" + objhistoria.Foto + "','" + objhistoria.Idautor + "',GETDATE(),'"+objhistoria.Nombre+"','"+objhistoria.Codigo_cat+"','"+objhistoria.Codigo_est+"')");
            return id;

        }







    }
}