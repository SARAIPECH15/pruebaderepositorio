using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Drawing.Imaging;
using System.IO;
using System.Drawing;
using ProyectoWebPageMaster.DAO;
using ProyectoWebPageMaster.BO;
namespace ProyectoWebPageMaster.GUI
{
	public partial class detalles : System.Web.UI.Page
	{
		string id_historia;
		protected void Page_Load(object sender, EventArgs e)
		{
		
			id_historia= Request.QueryString["CODIG_HIS"].ToString();

			if (!IsPostBack)
			{

				llenadotexts();
			}


		}

		HistoriasBO objhis = new HistoriasBO();
		listview_ACEPTARHIS objdao = new listview_ACEPTARHIS();

		





		public void llenadotexts()
		{



			objhis.Codig_his = int.Parse(id_historia);


			objdao.busca_datosdehistoria(objhis);
				string ruta = "~/recursos/fotos_portadasLibros/" + objhis.Codig_his +objhis.Foto;
			      Image1.ImageUrl = ruta;
				txtTitulo.Text = objhis.Nombre;
			txtprologo.Value = objhis.Prologo;
			TXT_ID.Text = objhis.Codig_his.ToString();
			TXT_AUTOR.Text = objhis.Idautor.ToString();
			





		}

		

		

		protected void btnGuardar2_Click(object sender, EventArgs e)
		{
		   ///ACTUALIZA ID_AUTORIZA
			objhis.Codig_his= int.Parse(TXT_ID.Text);
			objhis.Idautor = int.Parse(TXT_AUTOR.Text);
			objhis.Idautoriza = Convert.ToInt32(Session["ID_US"]);

			int valor = objdao.MODIFICARHISTORIA(objhis);
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