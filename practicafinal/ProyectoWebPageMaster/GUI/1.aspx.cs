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
	public partial class _1 : System.Web.UI.Page
	{

		UsuariosBO objboLogin = new UsuariosBO();
		UsuariosDAO objdaoLogin = new UsuariosDAO();
		registro_boo objbo2 = new registro_boo();
		regis_dao objdao2 = new regis_dao();

		protected void Page_Load(object sender, EventArgs e)
		{

			

		}

		protected void Btn_iniciar2_Click(object sender, EventArgs e)
		{
			int id;

			objboLogin.Usuario = txt_Usuario.Value;
			objboLogin.Contrasenia = txt_password.Value;


			id = objdaoLogin.verificar_login(objboLogin);
			if (id != 0)
			{
				int tipo1;
				Session["ID_US"] = id;
				objboLogin.Id_us = Convert.ToInt32(Session["ID_US"]);
				objdaoLogin.busca_usuario(objboLogin);
				tipo1 = objboLogin.Id_tipousuario;
				if (tipo1 == 1)
				{
					Response.Redirect("../GUI/tiposdeusuariosABCnew.aspx");
				}
				else
				{
					Response.Redirect("../GUI/home.aspx");
				}
			}


			






		}
	}
}