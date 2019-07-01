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
    public partial class Site1 : System.Web.UI.MasterPage
    {

        UsuariosBO objbo = new UsuariosBO();
        UsuariosDAO objdao = new UsuariosDAO();

        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
    }
}