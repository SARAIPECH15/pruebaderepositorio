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
    public partial class ClasificacionABC : System.Web.UI.Page
    {
        CATEGORIA_BO objCatBO = new CATEGORIA_BO();
        CATEGORIA_DAO objCatDAO = new CATEGORIA_DAO();
        protected void Page_Load(object sender, EventArgs e)
        {
            dgv_Clasificacion.DataSource = objCatDAO.buscar_Genero();
            dgv_Clasificacion.DataBind();
        }
        protected void llenarbo()
        {
            objCatBO.NOMBRE1 = txt_Clasificacion.Text;
        }
        protected void btn_AgregarClas_Click(object sender, EventArgs e)
        {
            llenarbo();
            objCatBO.CODIGO_CAT1 = objCatDAO.AgregarCat(objCatBO);
            dgv_Clasificacion.DataSource = objCatDAO.buscar_Genero();
            dgv_Clasificacion.DataBind();
        }

        protected void btn_ActualizarClas_Click(object sender, EventArgs e)
        {
            llenarbo();
            objCatBO.CODIGO_CAT1 = int.Parse(txt_IDClas.Text);
            int valor = objCatDAO.ModificarCat(objCatBO);
            dgv_Clasificacion.DataSource = objCatDAO.buscar_Genero();
            dgv_Clasificacion.DataBind();
        }

        protected void btn_EliminarClas_Click(object sender, EventArgs e)
        {
            llenarbo();
            objCatBO.CODIGO_CAT1 = int.Parse(txt_IDClas.Text);
            int valor = objCatDAO.Eliminar_Cat(objCatBO);
            dgv_Clasificacion.DataSource = objCatDAO.buscar_Genero();
            dgv_Clasificacion.DataBind();
        }

        protected void dgv_Clasificacion_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(dgv_Clasificacion, "Select$" + e.Row.RowIndex);
                e.Row.Attributes["style"] = "cursor:pointer";
            }
        }

        protected void dgv_Clasificacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_IDClas.Text = dgv_Clasificacion.SelectedRow.Cells[0].Text.Trim();
            txt_Clasificacion.Text = dgv_Clasificacion.SelectedRow.Cells[1].Text.Trim();
        }
    }
}