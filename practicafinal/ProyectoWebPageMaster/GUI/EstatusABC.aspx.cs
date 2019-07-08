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
    public partial class EstatusABC : System.Web.UI.Page
    {
        ESTATUS_BO objEstBO = new ESTATUS_BO();
        ESTATUS_DAO onjEstDAO = new ESTATUS_DAO();
        protected void Page_Load(object sender, EventArgs e)
        {
            dgv_Estatus.DataSource = onjEstDAO.buscar_Estatus();
            dgv_Estatus.DataBind();
        }
        protected void llenarbo()
        {
            objEstBO.NOMBRE1 = txt_Est.Text;
        }
        protected void btn_AgregarEst_Click(object sender, EventArgs e)
        {
            llenarbo();
            objEstBO.CODIGO_EST1 = onjEstDAO.AgregarEST(objEstBO);
            dgv_Estatus.DataSource = onjEstDAO.buscar_Estatus();
            dgv_Estatus.DataBind();
        }

        protected void btn_ActualizarEst_Click(object sender, EventArgs e)
        {
            llenarbo();
            objEstBO.CODIGO_EST1 = int.Parse(txt_IDEst.Text);
            int valor = onjEstDAO.ModificarCat(objEstBO);
            dgv_Estatus.DataSource = onjEstDAO.buscar_Estatus();
            dgv_Estatus.DataBind();
        }

        protected void btn_EliminarEst_Click(object sender, EventArgs e)
        {
            llenarbo();
            objEstBO.CODIGO_EST1 = int.Parse(txt_IDEst.Text);
            int valor = onjEstDAO.Eliminar_EST(objEstBO);
            dgv_Estatus.DataSource = onjEstDAO.buscar_Estatus();
            dgv_Estatus.DataBind();
        }

        protected void dgv_Genero_RowDataBound(object sender, GridViewRowEventArgs e)
        {

        }

        protected void dgv_Genero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void dgv_Estatus_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(dgv_Estatus, "Select$" + e.Row.RowIndex);
                e.Row.Attributes["style"] = "cursor:pointer";
            }
        }

        protected void dgv_Estatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_IDEst.Text = dgv_Estatus.SelectedRow.Cells[0].Text.Trim();
            txt_Est.Text = dgv_Estatus.SelectedRow.Cells[1].Text.Trim();

            btn_ActualizarEst.Visible = true;
            btn_EliminarEst.Visible = true;
            btn_AgregarEst.Visible = false;
        }

        protected void txt_Est_Load(object sender, EventArgs e)
        {
           
        }

        protected void txt_Est_Load1(object sender, EventArgs e)
        {
            if (txt_Est.Enabled == true)
            {
                btn_AgregarEst.Visible = true;
                btn_EliminarEst.Visible = false;
                btn_ActualizarEst.Visible = false;
            }
        }
    }
}