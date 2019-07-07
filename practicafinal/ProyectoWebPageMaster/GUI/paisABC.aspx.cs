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
    public partial class paisABC : System.Web.UI.Page
    {

        pais_BO objpaisBO = new pais_BO();
        PaisDAO objpaisDAO = new PaisDAO();


        protected void Page_Load(object sender, EventArgs e)
        {
            gridpais.DataSource = objpaisDAO.buscar_usuarios();
            gridpais.DataBind();
        }

        public void LimpiarControles()
        {

            txtidpais.Text = "";
            txtpais.Text = "";

        }

        protected void llenarbo()
        {
            
            objpaisBO.Nombre = txtpais.Text;

           
        }






        protected void btnagregar_Click(object sender, EventArgs e)
        {
            //llena el BO 
            llenarbo();
            objpaisBO.Cod_pais = objpaisDAO.agregarusuario(objpaisBO);

            string scriptjs = @"<script type='text/javascript'>
                            $.alert({
                 title: 'Alert!',
                 content: 'Datos agregados correctamente!',
                 });
             
             </script>";

            ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", scriptjs, false);
            LimpiarControles();
            gridpais.DataSource = objpaisDAO.buscar_usuarios();
            gridpais.DataBind();
        }

        protected void btnactualizar_Click(object sender, EventArgs e)
        {
            llenarbo();
            //agrego el id al bo
            objpaisBO.Cod_pais = int.Parse(txtidpais.Text);

            int valor = objpaisDAO.modificarpais(objpaisBO);
            string scriptjs = @"<script type='text/javascript'>
                            $.alert({
                title: 'Alert!',
                content: 'Datos actualizados correctamente!',
                });
                        </script>";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", scriptjs, false);
            LimpiarControles();


            gridpais.DataSource = objpaisDAO.buscar_usuarios();
            gridpais.DataBind();
        }

        protected void btneliminar_Click(object sender, EventArgs e)
        {
            objpaisBO.Cod_pais = int.Parse(txtidpais.Text);
            llenarbo();
            int valor = objpaisDAO.eliminarpais(objpaisBO);
            string scriptjs = @"<script type='text/javascript'>
                            $.alert({
                  title: 'Mensaje del sistema!',
                  type: 'blue',
                     content: 'Datos eliminados correctamente!',
                   });
                        </script>";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", scriptjs, false);
            LimpiarControles();

            gridpais.DataSource = objpaisDAO.buscar_usuarios();
            gridpais.DataBind();
        }

        protected void gridpais_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtidpais.Text = HttpUtility.HtmlDecode(gridpais.SelectedRow.Cells[0].Text);
            txtpais.Text = HttpUtility.HtmlDecode(gridpais.SelectedRow.Cells[1].Text);

            btneliminar.Visible = true;
            btnagregar.Visible = false;
            btnactualizar.Visible = true;
        }

        protected void gridpais_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(gridpais, "Select$" + e.Row.RowIndex);
                e.Row.Attributes["style"] = "cursor:pointer";       
            }
        }

        protected void txtpais_Load(object sender, EventArgs e)
        {
            if (txtidpais.Enabled==true)
            {
                btneliminar.Visible = false;
                btnagregar.Visible = true;
                btnactualizar.Visible = false;
            }
        }
    }
}