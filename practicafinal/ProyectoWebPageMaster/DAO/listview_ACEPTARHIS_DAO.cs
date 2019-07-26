using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using ProyectoWebPageMaster.DAO;
using ProyectoWebPageMaster.BO;

namespace ProyectoWebPageMaster.DAO
{
	public class listview_ACEPTARHIS_DAO
	{
		Conexion Objconec = new Conexion();

		public DataSet busca_HISTORIA()
		{

			return Objconec.EjecutarSentencia("select * from HISTORIA WHERE ID_AUTORIZA IS NULL");


		}

		public int MODIFICARHISTORIA(HistoriasBO objHIS)
		{
			int id = Objconec.EjecutarComando(string.Format("update HISTORIA set ID_AUTORIZA={0} where CODIG_HIS={1}",objHIS.Idautoriza,objHIS.Codig_his));
			return 1;
		}


		public void busca_datosdehistoria(HistoriasBO objbo)
		{
			DataSet datos = Objconec.EjecutarSentencia("select * from HISTORIA where CODIG_HIS="+ objbo.Codig_his);
			objbo.Foto = datos.Tables[0].Rows[0]["FOTO"].ToString();
			objbo.Nombre = datos.Tables[0].Rows[0]["NOMBRE"].ToString();
			objbo.Prologo = datos.Tables[0].Rows[0]["PROLOGO"].ToString();
			objbo.Prologo = datos.Tables[0].Rows[0]["PROLOGO"].ToString();
			objbo.Prologo = datos.Tables[0].Rows[0]["PROLOGO"].ToString();
			objbo.Idautor = int.Parse(datos.Tables[0].Rows[0]["ID_AUTOR"].ToString());

		}
		public DataSet busca_CAPITULO()
		{

			return Objconec.EjecutarSentencia("  select HISTORIA.NOMBRE , CAPITULO.CODIGO_CAP, CAPITULO.NOMBRE, CAPITULO.NUMERO,CAPITULO.CONTENIDO, USUARIO.USUARIO AS AUTOR  from CAPITULO inner join HISTORIA ON HISTORIA.CODIG_HIS= CAPITULO.CODIG_HIS INNER JOIN USUARIO ON HISTORIA.ID_AUTOR = USUARIO.ID_US  WHERE CAPITULO.CODIGO_EST=2");


		}

		public int MODIFICARCAPITULO(HistoriasBO objHIS)
		{
			int id = Objconec.EjecutarComando(string.Format("update CAPITULO set CODIGO_EST={0} where CODIGO_CAP={1}", objHIS.Codigo_est, objHIS.Cod_cap));
			return 1;
		}

		public void busca_datosCAPITULOS(HistoriasBO objbo)
		{
			DataSet datos = Objconec.EjecutarSentencia("  select HISTORIA.NOMBRE as HISTORIA, CAPITULO.CODIGO_CAP, CAPITULO.NOMBRE, CAPITULO.NUMERO,CAPITULO.CONTENIDO ,USUARIO.USUARIO  AS AUTOR from CAPITULO inner join HISTORIA ON HISTORIA.CODIG_HIS= CAPITULO.CODIG_HIS INNER JOIN USUARIO ON HISTORIA.ID_AUTOR = USUARIO.ID_US  WHERE CAPITULO.CODIGO_EST=2 AND CAPITULO.CODIGO_CAP=" + objbo.Cod_cap);
		
			objbo.Nombre = datos.Tables[0].Rows[0]["HISTORIA"].ToString();
		
			objbo.Cod_cap = int.Parse(datos.Tables[0].Rows[0]["CODIGO_CAP"].ToString());
			objbo.Nombre_cap = datos.Tables[0].Rows[0]["NOMBRE"].ToString();
			objbo.Numero_cap = datos.Tables[0].Rows[0]["NUMERO"].ToString();
			objbo.Contenido = datos.Tables[0].Rows[0]["CONTENIDO"].ToString();
			objbo.Nombreusu = datos.Tables[0].Rows[0]["AUTOR"].ToString();

		}
	}
}