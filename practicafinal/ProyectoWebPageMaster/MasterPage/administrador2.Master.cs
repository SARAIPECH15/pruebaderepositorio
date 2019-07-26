using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoWebPageMaster.BO;
using ProyectoWebPageMaster.DAO;

namespace ProyectoWebPageMaster.MasterPage
{
    public partial class administrador2 : System.Web.UI.MasterPage
    {
		UsuariosBO objboLogin = new UsuariosBO();
		UsuariosDAO objdaoLogin = new UsuariosDAO();
        registro_boo objbo2 = new registro_boo();
        regis_dao objdao2 = new regis_dao();


		protected void Page_Load(object sender, EventArgs e)
        {

			if (Session["ID_US"] == null)
			{
				Response.Redirect("../GUI/1.aspx");

			}
			else
			{
				objbo2.Id = Convert.ToInt32(Session["ID_US"]);
				objdao2.busca_usuario(objbo2);
				string ruta = "~/recursos/fotos_usuarios/" + objbo2.Id + objbo2.Fotoperfil;
				ImgfotoPerfil2.ImageUrl = ruta;
                lblnombreusuario.Text = objbo2.Usuario;
			}


		}

		
		

		protected void pruebita2(object sender, EventArgs e)
		{
			Session["ID_US"] = null;

			if (Session["ID_US"] == null)
			{

				Response.Redirect("../GUI/login.aspx");

			}

		}

		protected void pruebita_Click(object sender, EventArgs e)
		{
			Session["ID_US"] = null;

			if (Session["ID_US"] == null)
			{

				Response.Redirect("../GUI/login.aspx");

			}

		}

		protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
		{
			Session["ID_US"] = null;

			if (Session["ID_US"] == null)
			{

				Response.Redirect("../GUI/login.aspx");

			}
		}
	}
}