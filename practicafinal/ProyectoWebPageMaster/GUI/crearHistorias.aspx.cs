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

        crearhistorias_DAO cmd = new crearhistorias_DAO();
        Genero_Historia cmd2 = new Genero_Historia();
        historias objhistoriadao = new historias();
        HistoriasBO objhistoriabo = new HistoriasBO();

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
			//CheckBoxList1.Items.Insert(0, new ListItem("Seleccionar", "0"));


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

       

        protected void btnGuardar2_Click(object sender, EventArgs e)
        {



            foreach (ListItem listacursos in CheckBoxList1.Items)
            {

                if (listacursos.Selected == true)
                {

                    string idgenero = listacursos.Value.ToString();
                    cmd2.Codigo_genero = Convert.ToInt32(idgenero);
                    cmd2.Codigo_historia = 1;
                    cmd.agregarGeneroHistoria(cmd2);
                }
                
            }
        }
    }
}