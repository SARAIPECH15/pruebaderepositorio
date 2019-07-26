using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using ProyectoWebPageMaster.BO;
using ProyectoWebPageMaster.DAO;

namespace ProyectoWebPageMaster.GUI
{
    public partial class HISTORIASPARAUSUARIOS : System.Web.UI.Page
    {
        GENERO_BO objgenBO = new GENERO_BO();
        Class1 objGenDao = new Class1();

        string idgenero;
        protected void Page_Load(object sender, EventArgs e)
        {
            idgenero = Request.QueryString["idgen"].ToString();


            if (!IsPostBack)
            {
                cargarhistporgenero();
            }
        }
     
        private void cargarhistporgenero()
        {
            objgenBO.CODIGO_GEN1 = Convert.ToInt32(idgenero);
            DataSet datos = objGenDao.selecciondegenero(objgenBO);
            lstfotos.DataSource = datos;
            lstfotos.DataBind();
        }


    }
}