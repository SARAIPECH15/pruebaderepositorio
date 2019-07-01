using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoWebPageMaster.DAO;
using ProyectoWebPageMaster.BO;

namespace ProyectoWebPageMaster.GUI
{
    public partial class login : System.Web.UI.Page
    {

        UsuariosBO objboLogin = new UsuariosBO();
        UsuariosDAO objdaoLogin = new UsuariosDAO();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_registrate_Click(object sender, EventArgs e)
        {
            int id;

            objboLogin.Usuario = txt_Usuario.Text;
            objboLogin.Contrasenia = txt_password.Text;


            id = objdaoLogin.verificar_login(objboLogin);
            if (id != 0)
            {
                Session["ID_US"] = id;

                Response.Redirect("home.aspx");
            }
        }
    }
}