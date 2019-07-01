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
	public partial class abccategoria : System.Web.UI.Page
	{
        CATEGORIA_BO objCategoriaBO = new CATEGORIA_BO();
        CATEGORIA_DAO objCategoriaDAO = new CATEGORIA_DAO();
		protected void Page_Load(object sender, EventArgs e)
		{
            dgv_clasificacion.DataSource = objCategoriaDAO.buscar_Genero();
            dgv_clasificacion.DataBind();
        }

        protected void llenarbo()
        {
            objCategoriaBO.NOMBRE1 = txt_Categoria.Text;
        }
        protected void Btn_AgregarCat_Click(object sender, EventArgs e)
        {
            llenarbo();
            objCategoriaBO.CODIGO_CAT1 = objCategoriaDAO.AgregarCat(objCategoriaBO);

            dgv_clasificacion.DataSource = objCategoriaDAO.buscar_Genero();
            dgv_clasificacion.DataBind();
        }

        protected void btn_ModificarCat_Click(object sender, EventArgs e)
        {
            llenarbo();
            objCategoriaBO.CODIGO_CAT1 = int.Parse(txt_Codifgo_Cat.Text);
            int valor = objCategoriaDAO.ModificarCat(objCategoriaBO);
            dgv_clasificacion.DataSource = objCategoriaDAO.buscar_Genero();
            dgv_clasificacion.DataBind();
        }

        protected void Btn_EliminarCat_Click(object sender, EventArgs e)
        {

        }

        protected void dgv_clasificacion_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(dgv_clasificacion, "Select$" + e.Row.RowIndex);
                e.Row.Attributes["style"] = "cursor:pointer";
            }
        }

        protected void dgv_clasificacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_Codifgo_Cat.Text = dgv_clasificacion.SelectedRow.Cells[0].Text.Trim();
            txt_Categoria.Text = dgv_clasificacion.SelectedRow.Cells[1].Text.Trim();
        }
    }
}