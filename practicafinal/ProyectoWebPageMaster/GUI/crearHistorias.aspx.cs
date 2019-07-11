using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoWebPageMaster.BO;
using ProyectoWebPageMaster.DAO;


namespace ProyectoWebPageMaster.GUI
{
    public partial class crearHistorias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
			if (!IsPostBack)
			{

				llenadoCheklistgenero();
				llenadodrowlistcategiria();
			}
        }


		regis_dao ObjgenDAO = new regis_dao();
		private void llenadoCheklistgenero()
		{

			CheckBoxList1.DataSource = ObjgenDAO.Consultar("Select * from GENERO");
			CheckBoxList1.DataTextField = "NOMBRE";
			CheckBoxList1.DataValueField = "CODIGO_GEN";
			CheckBoxList1.DataBind();
			CheckBoxList1.Items.Insert(0, new ListItem("Seleccionar", "0"));


		}

		

		private void llenadodrowlistcategiria()
		{

			DropDownList2.DataSource = ObjgenDAO.Consultar("Select * from CATEGORIA");
			DropDownList2.DataTextField = "NOMBRE";
			DropDownList2.DataValueField = "CODIGO_CAT";
			DropDownList2.DataBind();
			DropDownList2.Items.Insert(0, new ListItem("Seleccionar", "0"));


		}

		protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}