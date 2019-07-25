using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using ProyectoWebPageMaster.BO;
using ProyectoWebPageMaster.GUI;

namespace ProyectoWebPageMaster.DAO
{
	public class Estadistica_DAO
	{


		Conexion objConectar = new Conexion();
		SqlConnection conn = new SqlConnection();
		
	
		public void obtenerdatos(ESTADISTICA_BO objdatos)
		{
			int cont = 0;
			SqlCommand cdm = new SqlCommand("SELECT grafica.NOMBRE, COUNT(grafica.NUMERO) AS TOTAL FROM  grafica group BY NOMBRE ;", conn);



			conn.Open();
			SqlDataReader reader = cdm.ExecuteReader();

			while (reader.Read())
			{
			  objdatos.Barras1[cont] = Convert.ToInt32(reader.GetString(0));
				objdatos.Nombs[cont] = reader.GetString(1);
				cont++;


			}
			reader.Close();
			objConectar.cerrarConexion();

			

			


		}

		public void recuperodatosparagraficas()
		{
			objConectar.establecerConexion();
			SqlCommand cdm = new SqlCommand("SELECT grafica.NOMBRE, COUNT(grafica.NUMERO) AS TOTAL FROM  grafica group BY NOMBRE ;");
			objConectar.abrirConexion();

			DataTable datos = new DataTable();
			datos.Load(cdm.ExecuteReader());
			conn.Close();














		}


























	}
}