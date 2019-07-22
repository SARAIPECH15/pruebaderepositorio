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
		Conexion OBJCONEX = new Conexion();

		public DataSet busca_HISTORIA()
		{

			return OBJCONEX.EjecutarSentencia("select * from HISTORIA WHERE ID_AUTORIZA IS NULL");


		}




}	}