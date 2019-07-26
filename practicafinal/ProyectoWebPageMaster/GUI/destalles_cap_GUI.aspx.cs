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
	public partial class destalles_cap_GUIaspx : System.Web.UI.Page
	{
		string id_cap;
		protected void Page_Load(object sender, EventArgs e)
		{
			id_cap = Request.QueryString["CODIGO_CAP"].ToString();

			if (!IsPostBack)
			{

				llenadotexts();
			}
		
					   			 		  			

		}
		HistoriasBO objhis = new HistoriasBO();
		listview_ACEPTARHIS_DAO objdao = new listview_ACEPTARHIS_DAO();
		public void llenadotexts()
		{



			objhis.Cod_cap = int.Parse(id_cap);


			objdao.busca_datosCAPITULOS(objhis);

			txtTitulo.Text = objhis.Nombre;
			txtcontenido.Value = objhis.Contenido;
			TXT_ID_cap.Text = objhis.Cod_cap.ToString();
			TXT_QUIEN.Text = objhis.Nombreusu;
			txt_nombre.Text = objhis.Nombre_cap;
			Txt_numero.Text = objhis.Numero_cap;
			




		}

		protected void btnGuardar2_Click(object sender, EventArgs e)
		{
			///ACTUALIZA codigo_est
			objhis.Cod_cap = int.Parse(TXT_ID_cap.Text);
			objhis.Codigo_est = 3;

			int valor = objdao.MODIFICARCAPITULO(objhis);
			string scriptjs = @"<script type='text/javascript'>
                            $.alert({
               title: 'Alert!',
                content: 'Datos actualizados correctamente!',
                });
                        </script>";
			ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", scriptjs, false);

		}
	}
}