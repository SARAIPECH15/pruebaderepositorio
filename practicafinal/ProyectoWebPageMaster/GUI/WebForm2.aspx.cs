using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoWebPageMaster.DAO;
using ProyectoWebPageMaster.BO;
using System.Data;



namespace ProyectoWebPageMaster.GUI
{
	public partial class WebForm2 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{



		}

		Estadistica_DAO objdao = new Estadistica_DAO();
		ESTADISTICA_BO datos = new ESTADISTICA_BO();

		int[] Barras = new int[3];
		string[] nombs = new string[3];




		public void obtener_datos()
		{

			datos.Barras1 = Barras;
			datos.Nombs = nombs;
			objdao.obtenerdatos(datos);


			Graficas.Series["Serie"].Points.DataBindXY(datos.Barras1,datos.Nombs);



		}
			














	}
}