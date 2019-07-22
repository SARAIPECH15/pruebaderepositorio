using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using ProyectoWebPageMaster.DAO;
using ProyectoWebPageMaster.BO;

namespace ProyectoWebPageMaster.DAO
{
	public class listview_ACEPTARHIS
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
			objbo.Idautor = int.Parse(datos.Tables[0].Rows[0]["ID_AUTOR"].ToString());

		}


	}
}