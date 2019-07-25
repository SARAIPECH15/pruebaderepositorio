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
    public partial class EditarCapitulo : System.Web.UI.Page
    {
        CapituloDAO objdaocap = new CapituloDAO();
        CapituloBO objbocap = new CapituloBO();

        string idcap,idhis;




        protected void Page_Load(object sender, EventArgs e)
        {
            idhis = Request.QueryString["idhis"];
            idcap = Request.QueryString["idcap"];

            if (!IsPostBack)
            {
                if (Session["ID_US"] == null)
                {

                }
                else
                {
                    objbocap.Codigo_cap =Convert.ToInt32 (idcap);
                    objbocap.Codig_his = Convert.ToInt32(idhis);
                    objdaocap.busca_capitulo(objbocap);
                    txtAreacapitulo.Value = objbocap.Contenido;
                    txtNombre.Text = objbocap.Nombre;
                    int numcap =objbocap.Numero;
                    txtNumeroCap.Text =numcap.ToString();
                   
                }
            }

        }

        private void llenarbo()
        {

        }



        protected void btnguardar_Click(object sender, EventArgs e)
        {

        }
    }
}