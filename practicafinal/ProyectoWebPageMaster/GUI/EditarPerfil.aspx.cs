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
    public partial class EditarPerfil : System.Web.UI.Page
    {
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
                //ruta = HttpUtility.HtmlDecode;
                imgperfilusuario.ImageUrl = ruta;
                txt_nombre.Text = objbo2.Nombre;
                txt_Apellidos.Text = objbo2.Apeliido;
                txt_Direccion.Text = objbo2.Direccion;
                Txt_email.Text = objbo2.Email;
                txt_password.Text = objbo2.Comtrasena;
                txt_Usuario.Text = objbo2.Usuario;
              // DropDownEstado.Text = objbo2.Cod_ciu;
               // DropDownPais.Text = objbo2.Cod_pais;
            }

        }
    }
}