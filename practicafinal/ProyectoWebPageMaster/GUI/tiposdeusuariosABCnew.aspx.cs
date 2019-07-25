
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoWebPageMaster.DAO;
using ProyectoWebPageMaster.BO;



namespace ProyectoWebPageMaster.GUI
{
    public partial class tiposdeusuariosABCnew : System.Web.UI.Page
    {
        tipousuariosBO objtipousuariosBO = new tipousuariosBO();
        tipousuariosDAO objtipousuariosDAO = new tipousuariosDAO();



        protected void Page_Load(object sender, EventArgs e)
        {
            gridtipousuarios.DataSource = objtipousuariosDAO.buscar_tipousuarios();
            gridtipousuarios.DataBind();
        }

        public void LimpiarControles()
        {

            txtidtipousuario.Text = "";
            txttipousuario.Text = "";

        }

        protected void llenarbo()
        {

            objtipousuariosBO.Nombre = txttipousuario.Text;


        }






        protected void btnagregar_Click(object sender, EventArgs e)
        {
            //llena el BO 
            llenarbo();
            objtipousuariosBO.Id_tipousuario = objtipousuariosDAO.agregatiporusuario(objtipousuariosBO);

            string scriptjs = @"<script type='text/javascript'>
                            $.alert({
                 title: 'Alert!',
                 content: 'Datos agregados correctamente!',
                 });
                        </script>";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", scriptjs, false);
            LimpiarControles();
            gridtipousuarios.DataSource = objtipousuariosDAO.buscar_tipousuarios();
            gridtipousuarios.DataBind();
        }

        protected void btnactualizar_Click(object sender, EventArgs e)
        {
            llenarbo();
            //agrego el id al bo
            objtipousuariosBO.Id_tipousuario = int.Parse(txtidtipousuario.Text);

            int valor = objtipousuariosDAO.modificartipousuario(objtipousuariosBO);
            string scriptjs = @"<script type='text/javascript'>
                            $.alert({
                title: 'Alert!',
                content: 'Datos actualizados correctamente!',
                });
                        </script>";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", scriptjs, false);
            LimpiarControles();


            gridtipousuarios.DataSource = objtipousuariosDAO.buscar_tipousuarios();
            gridtipousuarios.DataBind();
        }

        protected void btneliminar_Click(object sender, EventArgs e)
        {
            objtipousuariosBO.Id_tipousuario = int.Parse(txtidtipousuario.Text);
            llenarbo();
            int valor = objtipousuariosDAO.eliminartipousuario(objtipousuariosBO);
            string scriptjs = @"<script type='text/javascript'>
                            $.alert({
                  title: 'Mensaje del sistema!',
                  type: 'blue',
                     content: 'Datos eliminados correctamente!',
                   });
                        </script>";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", scriptjs, false);
            LimpiarControles();

            gridtipousuarios.DataSource = objtipousuariosDAO.buscar_tipousuarios();
            gridtipousuarios.DataBind();
        }

        protected void gridtipousuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtidtipousuario.Text = HttpUtility.HtmlDecode(gridtipousuarios.SelectedRow.Cells[0].Text);
            txttipousuario.Text = HttpUtility.HtmlDecode(gridtipousuarios.SelectedRow.Cells[1].Text);

            btneliminar.Visible = true;
            btnagregar.Visible = false;
            btnactualizar.Visible = true;
        }

        protected void gridtipousuarios_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(gridtipousuarios, "Select$" + e.Row.RowIndex);
                e.Row.Attributes["style"] = "cursor:pointer";
           
            }
        }

        protected void txttipousuario_Load(object sender, EventArgs e)
        {
            if (txttipousuario.Enabled == true)
            {
                btnactualizar.Visible = false;
                btnagregar.Visible = true;
                btneliminar.Visible = false;
            }
        }
    }
}