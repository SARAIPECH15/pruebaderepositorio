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
            int id = objConectar.EjecutarComando("INSERT INTO HISTORIA_GENERO (CODIGO_GEN,CODIG_HIS) values('" + objgenero2.Codigo_genero+ "','"+objgenero2.Codigo_historia+"')");
            return id;

        }


        public int agregarHistoria(HistoriasBO objhistoria)
        {
            //inserta y devuelve el ultimo el id insertado
            int id = objConectar.EjecutarComando("INSERT INTO HISTORIA (FOTO,ID_AUTOR,FECHA_PUBL,NOMBRE,CODIGO_CAT,CODIGO_EST,PROLOGO) output INSERTED.CODIG_HIS values('" + objhistoria.Foto + "','" + objhistoria.Idautor + "',GETDATE(),'"+objhistoria.Nombre+"','"+objhistoria.Codigo_cat+"','1','"+objhistoria.Prologo+"')");
            return id;
            
        }



        public DataSet busca_portadasHistorias()
        {
            return objConectar.EjecutarSentencia("select * FROM HISTORIA");
        }

        public DataSet busca_infoLibros(int idhis)
        {
            return objConectar.EjecutarSentencia("select * FROM CAPITULO where CODIG_HIS=" + idhis);
        }


        public int actualizarHistoria(HistoriasBO objusuario)
        {
            int id = objConectar.EjecutarComando(string.Format("update HISTORIA set FOTO='{0}', NOMBRE='{1}', PROLOGO='{2}', CODIGO_CAT={3} where CODIG_HIS={4}", objusuario.Foto, objusuario.Nombre,objusuario.Prologo,objusuario.Codigo_cat,objusuario.Codig_his));
            return 1;
        }


        public void busca_libro(HistoriasBO objbo)
        {
            string sen = "select * from HISTORIA where CODIG_HIS=" + objbo.Codig_his;
            DataSet datos = objConectar.EjecutarSentencia(sen);
            objbo.Foto = datos.Tables[0].Rows[0]["FOTO"].ToString();
            objbo.Nombre = datos.Tables[0].Rows[0]["NOMBRE"].ToString();
            objbo.Prologo = datos.Tables[0].Rows[0]["PROLOGO"].ToString();
            objbo.Codigo_cat = Convert.ToInt32(datos.Tables[0].Rows[0]["CODIGO_CAT"].ToString());
            // return datos;
        }

        public void busca_historiagenero(Genero_Historia objbo)
        {
            string sen = "select * from historia_genero where CODIG_HIS=" + objbo.Codigo_historia;
            DataSet datos = objConectar.EjecutarSentencia(sen);
            objbo.Codigo_genero = Convert.ToInt32(datos.Tables[0].Rows[0]["CODIGO_GEN"].ToString());
            
            // return datos;
        }



        public int actualizargenerohistoria(Genero_Historia objusuario)
        {
            int id = objConectar.EjecutarComando(string.Format("update historia_genero set CODIGO_GEN={0} where CODIG_HIS={1}", objusuario.Codigo_genero,objusuario.Codigo_historia));
            return 1;
        }

    }
}