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
    public partial class CrearCapitulo : System.Web.UI.Page
    {
        CapituloBO objcapbo = new CapituloBO();
        CapituloDAO objcapdao = new CapituloDAO();


        string idhistoria;

        protected void Page_Load(object sender, EventArgs e)
        {
            idhistoria = Request.QueryString["id"];
        }

        public void llenarbo()
        {
            objcapbo.Nombre = txtNombre.Text;
            objcapbo.Numero = Convert.ToInt32(txtNumeroCap.Text);
            objcapbo.Contenido = txtAreacapitulo.Value;
            objcapbo.Codig_his = Convert.ToInt32(idhistoria);

        }





        protected void btnguardar_Click(object sender, EventArgs e)
        {
            llenarbo();
            objcapbo.Codigo_cap = objcapdao.agregarCapitulo(objcapbo);

            string scriptjs = @"<script type='text/javascript'>
                            $.alert({
               title: 'Alert!',
                content: 'Felicidades! Tu historia fue creada!',
                });
                        </script>";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", scriptjs, false);
        }
    }
}