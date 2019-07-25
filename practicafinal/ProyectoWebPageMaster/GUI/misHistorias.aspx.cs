using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoWebPageMaster.DAO;
using System.Data;

namespace ProyectoWebPageMaster.GUI
{
    public partial class misHistorias : System.Web.UI.Page
    {
        crearhistorias_DAO objDAO = new crearhistorias_DAO();


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargar_imagenes();
            }
        }


        private void cargar_imagenes()
        {
            DataSet datos = objDAO.busca_portadasHistorias();

            //se enlaza al control de origen de datos especificados
            lstfotos.DataSource = datos;
            //para enlazar a un origen de datos que implementa con los datos especificos
            lstfotos.DataBind();
        }

        protected void DataPager1_PreRender(object sender, EventArgs e)
        {
            cargar_imagenes();
        }

        protected void lstfotos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}