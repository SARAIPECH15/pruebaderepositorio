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












	}
}