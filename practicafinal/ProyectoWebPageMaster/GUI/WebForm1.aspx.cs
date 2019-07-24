using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using ProyectoWebPageMaster.GUI;
using ProyectoWebPageMaster.MasterPage;
using ProyectoWebPageMaster.DAO;
using System.Data.SqlClient;

namespace ProyectoWebPageMaster.GUI
{
	public partial class WebForm1 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		Conexion conec = new Conexion();
		Estadistica_DAO objdao = new Estadistica_DAO();

		protected string obtenerdatos()
		{
			DataTable datos = new DataTable();
			//datos a mostrar
			datos.Columns.Add(new DataColumn("Task", typeof(string)));
			datos.Columns.Add(new DataColumn("Hours Per Day", typeof(string)));

			//datos a mostrar en el chart

			datos.Rows.Add(new Object[] { "Work", 11 });
			datos.Rows.Add(new Object[] { "Eat", 2 });
			datos.Rows.Add(new Object[] { "Commute", 2 });
			datos.Rows.Add(new Object[] { "Watch TV", 2 });
			datos.Rows.Add(new Object[] { "Sleep", 7 });

			//ahora hay que leerlos
			string strdatos;

			strdatos = "[['Task','Hours Per Day'],";


			foreach (DataRow dr in datos.Rows) {

				strdatos = strdatos + "[";
				strdatos = strdatos + "'" + dr[0] + "'" + "," + dr[1];
				strdatos = strdatos + "],";










			}
			strdatos = strdatos + "]";

			return strdatos;


			



		}

		protected string obtenerdatos3()
		{
			SqlConnection conn = new SqlConnection();
			SqlCommand cdm = new SqlCommand();
			cdm.Connection = conec.establecerConexion();
			conec.abrirConexion();
			cdm.CommandText= "ESTADISTICAS";
			cdm.CommandType = CommandType.StoredProcedure;
			
			
			DataTable datos2 = new DataTable();
			datos2.Load(cdm.ExecuteReader());
			conec.cerrarConexion();

			/*//datos a mostrar
			datos2.Columns.Add(new DataColumn("AÑO", typeof(string)));
			datos2.Columns.Add(new DataColumn("Java", typeof(string)));
			datos2.Columns.Add(new DataColumn("Python", typeof(string)));
			datos2.Columns.Add(new DataColumn("c#", typeof(string)));
			datos2.Columns.Add(new DataColumn("JavaScript", typeof(string)));
			//datos a mostrar en el chart*/
			string strdatos;

			strdatos = "[['Task','Hours Per Day'],";


			foreach (DataRow dr in datos2.Rows)
			{

				strdatos = strdatos + "[";
				strdatos = strdatos + "'" + dr[0] + "'" + "," + dr[1];
				strdatos = strdatos + "],";










			}
			strdatos = strdatos + "]";

			return strdatos;








		}




		protected string obtenerdatos2()
		{
			SqlConnection conn = new SqlConnection();
			SqlCommand cdm = new SqlCommand();
			cdm.Connection = conec.establecerConexion();
			conec.abrirConexion();
			cdm.CommandText = "SELECT FECHA , SUM(grafica.NUMERO) AS TOTAL FROM  grafica group BY FECHA, NOMBRE";
			cdm.CommandType = CommandType.Text;


			DataTable datos2 = new DataTable();
			datos2.Load(cdm.ExecuteReader());
			conec.cerrarConexion();




			//datos a mostrar

			/*datos2.Columns.Add(new DataColumn("AÑO", typeof(string)));
			datos2.Columns.Add(new DataColumn("Java", typeof(string)));
			datos2.Columns.Add(new DataColumn("Python", typeof(string)));
			datos2.Columns.Add(new DataColumn("c#", typeof(string)));
			datos2.Columns.Add(new DataColumn("JavaScript", typeof(string)));
			//datos a mostrar en el chart*/

			/*datos2.Rows.Add(new Object[] { "new Date (2015, 5, 6)", 15, 2.8, 5.7, 3.6 });
			datos2.Rows.Add(new Object[] { "new Date(2016, 5, 6)", 13, 4.4, 5.7, 7.6 });
			datos2.Rows.Add(new Object[] { "new Date(2017, 5, 6)", 14, 6.8, 5.7, 5.6 });*/

			//ahora hay que leerlos
			string strdatos;

			strdatos = "[";


			foreach (DataRow dr in datos2.Rows)
			{

				strdatos = strdatos + "[";
				strdatos = strdatos + "'" + dr[0].ToString() + "'" + "," + dr[1] + "," + dr[2];


				strdatos = strdatos + "],";









			}
			strdatos = strdatos + "]";

			return strdatos;






		}






	}
}