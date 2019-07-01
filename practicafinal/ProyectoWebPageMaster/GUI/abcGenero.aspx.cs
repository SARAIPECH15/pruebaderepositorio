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
	public partial class abcESTATUS : System.Web.UI.Page
	{

        GENERO_BO objGenBO = new GENERO_BO();
        GENERO_DAO objGenDAO = new GENERO_DAO();
		protected void Page_Load(object sender, EventArgs e)
		{
            dgv_Genero.DataSource = objGenDAO.buscar_Genero();
            dgv_Genero.DataBind();

        }

        protected void llenarbo()
        {
            objGenBO.NOMBRE1 = txt_Genero.Text;
        }



        protected void btn_AgregarGen_Click(object sender, EventArgs e)
        {
            llenarbo();
            objGenBO.CODIGO_GEN1 = objGenDAO.AgregarGen(objGenBO);

            dgv_Genero.DataSource = objGenDAO.buscar_Genero();
            dgv_Genero.DataBind();


        }

        protected void btn_ModificarGen_Click(object sender, EventArgs e)
        {
            llenarbo();
            objGenBO.CODIGO_GEN1 = int.Parse(txt_CODIGO_GEN.Text);
            int valor = objGenDAO.ModificarGen(objGenBO);
            dgv_Genero.DataSource = objGenDAO.buscar_Genero();
            dgv_Genero.DataBind();

        }

        protected void dgv_Genero_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(dgv_Genero, "Select$" + e.Row.RowIndex);
                e.Row.Attributes["style"] = "cursor:pointer";
            }

        }

        protected void dgv_Genero_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_CODIGO_GEN.Text = dgv_Genero.SelectedRow.Cells[0].Text.Trim();
            txt_Genero.Text = dgv_Genero.SelectedRow.Cells[1].Text.Trim();

        }

        protected void btn_EliminarGen_Click(object sender, EventArgs e)
        {
            objGenBO.CODIGO_GEN1 = int.Parse(txt_CODIGO_GEN.Text);
            llenarbo();
            int valor = objGenDAO.Eliminar_Gen(objGenBO);
            dgv_Genero.DataSource = objGenDAO.buscar_Genero();
            dgv_Genero.DataBind();

        }
    }
}