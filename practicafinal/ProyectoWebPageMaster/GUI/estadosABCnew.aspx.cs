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
    public partial class estadosABCnew : System.Web.UI.Page
    {
        PaisDAO objpaisDAO = new PaisDAO();
        estadosBO objestadoBO = new estadosBO();
        estadosDAO objestadosDAO = new estadosDAO();

        protected void Page_Load(object sender, EventArgs e)
        {
            gridestado.DataSource = objestadosDAO.buscar_estados();
            gridestado.DataBind();

            if (!IsPostBack)
            {
                llenadoDropDownPais();
            }


        }


        private void llenadoDropDownPais()
        {

            dropPaises.DataSource = objpaisDAO.Consultar("Select * from PAIS");
            dropPaises.DataTextField = "NOMBRE";
            dropPaises.DataValueField = "COD_PAIS";
            dropPaises.DataBind();
            dropPaises.Items.Insert(0, new ListItem("Seleccionar", "0"));


        }


        public void LimpiarControles()
        {
            txtestado.Text = "";
            txtidestado.Text = "";
           

        }

        protected void llenarbo()
        {
            objestadoBO.Nombre = txtestado.Text;
            

            objestadoBO.COD_PAIS1 = Convert.ToInt32(dropPaises.SelectedValue);
        }

        protected void btnagregar_Click(object sender, EventArgs e)
        {
            //llena el BO 
            llenarbo();
            objestadoBO.Cod_estado = objestadosDAO.agregarCIUDAD(objestadoBO);
            string scriptjs = @"<script type='text/javascript'>
                            $.alert({
                 title: 'Alert!',
                   content: 'Datos agregados correctamente!',
               });
                        </script>";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", scriptjs, false);
            LimpiarControles();

            gridestado.DataSource = objestadosDAO.buscar_estados();
            gridestado.DataBind();
        }

        protected void btnactualizar_Click(object sender, EventArgs e)
        {



            llenarbo();
            //agrego el id al bo
            objestadoBO.Cod_estado = int.Parse(txtidestado.Text);

            int valor = objestadosDAO.modificarestado(objestadoBO);
            string scriptjs = @"<script type='text/javascript'>
                            $.alert({
                title: 'Alert!',
                content: 'Datos actualizados correctamente!',
                });
                        </script>";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", scriptjs, false);
            LimpiarControles();
            gridestado.DataSource = objestadosDAO.buscar_estados();
            gridestado.DataBind();


        }

        protected void btneliminar_Click(object sender, EventArgs e)
        {


            objestadoBO.Cod_estado = int.Parse(txtidestado.Text);
            llenarbo();
            int valor = objestadosDAO.eliminarestado(objestadoBO);
            string scriptjs = @"<script type='text/javascript'>
                            $.alert({
                  title: 'Mensaje del sistema!',
                  type: 'blue',
                     content: 'Datos eliminados correctamente!',
                   });
                        </script>";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", scriptjs, false);
            LimpiarControles();

            gridestado.DataSource = objestadosDAO.buscar_estados();
            gridestado.DataBind();


        }

        protected void gridestado_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtidestado.Text = HttpUtility.HtmlDecode(gridestado.SelectedRow.Cells[0].Text);
            txtestado.Text = HttpUtility.HtmlDecode(gridestado.SelectedRow.Cells[2].Text);
            dropPaises.Text = HttpUtility.HtmlDecode(gridestado.SelectedRow.Cells[1].Text);

        }

        protected void gridestado_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(gridestado, "Select$" + e.Row.RowIndex);
                e.Row.Attributes["style"] = "cursor:pointer";
            }
        }
    }
}