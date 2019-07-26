using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoWebPageMaster.BO;
using ProyectoWebPageMaster.DAO;




namespace ProyectoWebPageMaster.GUI
{
	public partial class _1 : System.Web.UI.Page
	{
        public const string FaceBookAppKey = "7fd4b870152fadf393fd576c8f968002";

        UsuariosBO objboLogin = new UsuariosBO();
		UsuariosDAO objdaoLogin = new UsuariosDAO();
		registro_boo objbo2 = new registro_boo();
		regis_dao objdao2 = new regis_dao();

		protected void Page_Load(object sender, EventArgs e)
		{
            if (string.IsNullOrEmpty(Request.QueryString["access_token"])) return;
           /// string json = GetFacebookUserJSON(Request.QueryString["access_token"]);
			

		}



		protected void Btn_iniciar2_Click(object sender, EventArgs e)
		{
			int id;

			objboLogin.Usuario = txt_Usuario.Value;
			objboLogin.Contrasenia = txt_password.Value;


			id = objdaoLogin.verificar_login(objboLogin);
			if (id != 0)
			{
                string scriptjs = @"<script type='text/javascript'>
                            $.alert({
                title: 'Alert!',
                  content: 'Bienvenido!',
                        });
                        </script>";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", scriptjs, false);




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
            else
            {
                string scriptjs = @"<script type='text/javascript'>
                            $.alert({
                title: 'Alert!',
                  content: 'Usuario no registrado!',
                        });
                        </script>";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", scriptjs, false);
                Response.Redirect("../GUI/REGISTRO.aspx");
            }

            






		}
	}
}