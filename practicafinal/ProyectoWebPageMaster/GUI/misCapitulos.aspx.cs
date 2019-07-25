using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoWebPageMaster.BO;
using ProyectoWebPageMaster.DAO;
using System.Data;

namespace ProyectoWebPageMaster.GUI
{
    public partial class misCapitulos : System.Web.UI.Page
    {
        crearhistorias_DAO objDAO = new crearhistorias_DAO();
        CapituloBO objboCap = new CapituloBO();

        string idhistoria;
        int idhis;

        protected void Page_Load(object sender, EventArgs e)
        {
            idhistoria = Request.QueryString["id"];
            idhis = Convert.ToInt32(idhistoria);
            if (!IsPostBack)
            {
                cargar_capitulos();
            }
        }


        private void cargar_capitulos()
        {
            DataSet datos = objDAO.busca_infoLibros(idhis);

            //se enlaza al control de origen de datos especificados
            lstcapitulos.DataSource = datos;
            
            //para enlazar a un origen de datos que implementa con los datos especificos
            lstcapitulos.DataBind();
          
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("CrearCapitulo.aspx?id="+idhis);
        }

        protected void DataPager1_PreRender(object sender, EventArgs e)
        {
            cargar_capitulos();
        }
    }
}