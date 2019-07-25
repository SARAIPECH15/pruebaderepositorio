using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoWebPageMaster.BO;
using ProyectoWebPageMaster.DAO;
using System.Data;

namespace ProyectoWebPageMaster.MasterPage
{
    public partial class Site1 : System.Web.UI.MasterPage
    {

        UsuariosBO objbo = new UsuariosBO();
        UsuariosDAO objdao = new UsuariosDAO();
        Class1 objcargardatos = new Class1();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargardatos();
            }
        }

        private void cargardatos()
        {
            DataSet datos = objcargardatos.datos_gen();
            lstgeneros.DataSource = datos;
            lstgeneros.DataBind();

        }

    }
}