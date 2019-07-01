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
	public partial class abcsubclasificacionaspx : System.Web.UI.Page
	{

        estadosBO objestadoBO = new estadosBO();
        estadosDAO objestadosDAO = new estadosDAO();
        pais_BO objpaisBO = new pais_BO();
        PaisDAO objpaisDAO = new PaisDAO();

		protected void Page_Load(object sender, EventArgs e)
		{
            GridViewpaises.DataSource = objpaisDAO.buscar_usuarios();
            GridViewpaises.DataBind();


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
            dropPaises.Items.Insert(0,new ListItem("Seleccionar","0"));


        }
        public void LimpiarControles()
        {
            txtestado.Text = "";
            txtidpais.Text = "";
            txtpais.Text = "";
           
        }

        protected void llenarbo()
        {
            objestadoBO.Nombre = txtestado.Text;
            objpaisBO.Nombre = txtpais.Text;
            
            objestadoBO.COD_PAIS1 = Convert.ToInt32(dropPaises.SelectedValue);
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
            GridViewpaises.DataSource = objpaisDAO.buscar_usuarios();
            GridViewpaises.DataBind();
        }

        protected void btnagregarEstado_Click(object sender, EventArgs e)
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



        }

        protected void btnmodificarEstado_Click(object sender, EventArgs e)
        {
            
        }

        protected void btneliminarEstado_Click(object sender, EventArgs e)
        {

        }

        protected void dropPaises_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        protected void btnmodificar_Click(object sender, EventArgs e)
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


            GridViewpaises.DataSource = objpaisDAO.buscar_usuarios();
            GridViewpaises.DataBind();
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

            GridViewpaises.DataSource = objpaisDAO.buscar_usuarios();
            GridViewpaises.DataBind();
        }

        protected void GridViewpaises_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtidpais.Text =HttpUtility.HtmlDecode(GridViewpaises.SelectedRow.Cells[0].Text);
            txtpais.Text =HttpUtility.HtmlDecode(GridViewpaises.SelectedRow.Cells[1].Text);
           
            
        }

        protected void GridViewpaises_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(GridViewpaises, "Select$" + e.Row.RowIndex);
                e.Row.Attributes["style"] = "cursor:pointer";
            }
        }

        protected void gridviewestados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}