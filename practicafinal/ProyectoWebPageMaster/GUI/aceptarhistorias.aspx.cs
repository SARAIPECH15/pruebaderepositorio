﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoWebPageMaster.BO;
using ProyectoWebPageMaster.DAO;
using System.Data.Sql;
using System.Data;
using System.IO;
namespace ProyectoWebPageMaster.GUI
{
	public partial class aceptarhistorias : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		listview_ACEPTARHIS_DAO objdao = new listview_ACEPTARHIS_DAO();
		private void cargar_HISTORIAS()
		{

			
			DataSet datos = objdao.busca_HISTORIA();

			//se enlaZA EL CONTROL DE ORIGEN de dagos especificado
			lstfotos.DataSource = datos;

			//para enlazar a un orgine de datos	que implemente con los datos especificados 
			lstfotos.DataBind();
			

			
			




		}
		//CARGAR DATOS DE UNA HISTORIA
		int ID_HIS;
		

		


		protected void lstfotos_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
		
		protected void imagenes(object sender, EventArgs e)
		{
			cargar_HISTORIAS();
		}

		protected void Button2_Click(object sender, EventArgs e)
		{
			
		}
	}
}