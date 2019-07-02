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



		protected void Page_Load(object sender, EventArgs e)
        {

			if (Session["ID_US"] == null)
			{
				Response.Redirect("../GUI/tiposusuariosABCnew.aspx");

			}
			else
			{
				objboLogin.Id_us = Convert.ToInt32(Session["ID_US"]);
				objdaoLogin.busca_usuario(objboLogin);
				string ruta = "~/Recursos/fotos_usuarios/" + objboLogin.Id_us + objboLogin.Foto;
				ImgfotoPerfil2.ImageUrl = ruta;
				
			}


		}
	}
}