using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
using ProyectoWebPageMaster.BO;
using ProyectoWebPageMaster.DAO;







namespace ProyectoWebPageMaster.GUI
{
    public partial class REGISTRO : System.Web.UI.Page
    {





        protected void Page_Load(object sender, EventArgs e)
        {
			if (!IsPostBack)
			{
				llenadoDropDownPais();
			}
			if (!IsPostBack)
			{
				llenadoDropDownEstado();
			}


		}

		registro_boo objbo = new registro_boo();
		regis_dao objdao = new regis_dao();

		estadosDAO objestadosDAO = new estadosDAO();
	
		PaisDAO objpaisDAO = new PaisDAO();






		private void llenadoDropDownPais()
		{

			DropDownPais.DataSource = objpaisDAO.Consultar("Select * from PAIS");
			DropDownPais.DataTextField = "NOMBRE";
		 DropDownPais.DataValueField = "COD_PAIS";
			DropDownPais.DataBind();
			DropDownPais.Items.Insert(0, new ListItem("Seleccionar", "0"));


		}
		public void LimpiarControles()
		{
			txt_Apellidos.Text = "";
			txt_Direccion.Text = "";
			Txt_email.Text = "";
			txt_password.Text = "";
			txt_Usuario.Text = "";
			txt_password.Attributes.Add("value", "");


		}

		protected void llenarbo()
		{
			

			objbo.Nombre=txt_nombre.Text;
			objbo.Usuario = txt_Usuario.Text;
			objbo.Email = Txt_email.Text;
			objbo.Direccion = txt_Direccion.Text;
			objbo.Comtrasena = txt_password.Text;
			objbo.Apeliido = txt_Apellidos.Text;
			objbo.Id_tipous = 1;

			objbo.Cod_ciu= Convert.ToInt32(DropDownEstado.SelectedValue);
			objbo.Cod_pais= Convert.ToInt32(DropDownPais.SelectedValue);







		}
		private void llenadoDropDownEstado()
		{

			DropDownEstado.DataSource = objestadosDAO.Consultar("Select * from CIUDAD");
		DropDownEstado.DataTextField = "NOMBRE";
			DropDownEstado.DataValueField = "COD_CIU";
		DropDownEstado.DataBind();
		 DropDownEstado.Items.Insert(0, new ListItem("Seleccionar", "0"));


		}

		protected void btn_registrate_Click(object sender, EventArgs e)
		{

			//llena el BO 
			llenarbo();

			//SI EXISTE ARCHIVO EN EL CONTROL
			if (Fu_perfil.HasFile)
			{
				//validar extensiones aceptadas
				//OBTIENE LA EXTENSION DEL ARCHIVO
				String fileExtension = Path.GetExtension(Fu_perfil.FileName).ToLower();

				//ARREGLO TIPO STRING DE EXTENSIONES.
				String[] Exten_validas = { ".png", ".jpeg", ".jpg" };
				for (int i = 0; i < Exten_validas.Length; i++)
				{
					//si la extensión es alguna de las válidas
					if (fileExtension == Exten_validas[i])
					{
						System.Drawing.Image ObjetoImagen;
						string NombreArchivoPequenio = "_" + Path.GetFileName(Fu_perfil.PostedFile.FileName.Replace("_", ""));

						objbo.Fotoperfil = NombreArchivoPequenio;
						//agrega a la base de datos
					    objbo.Id = objdao.agregarusuario(objbo);

						string RutaImagenes = "~/Recursos/fotos_usuarios/";
						Bitmap ImagenEnBinario = new Bitmap(Fu_perfil.PostedFile.InputStream);
						ObjetoImagen = objbo.RedimencionarImagen(ImagenEnBinario, 100);
						switch (fileExtension)
						{
							case ".png":
								ObjetoImagen.Save(Server.MapPath(RutaImagenes) + objbo.Id + NombreArchivoPequenio, ImageFormat.Png);

								break;
							case ".jpg":
								ObjetoImagen.Save(Server.MapPath(RutaImagenes) + objbo.Id + NombreArchivoPequenio, ImageFormat.Jpeg);
								break;
							case ".jpeg":
								ObjetoImagen.Save(Server.MapPath(RutaImagenes) + objbo.Id + NombreArchivoPequenio, ImageFormat.Jpeg);
								break;
						}


					}
				}

			}
			else
			{
				objbo.Fotoperfil = "";
				objbo.Id = objdao.agregarusuario(objbo);


			}

			//EL SCRIPT DE ALERTA

			string scriptjs = @"<script type='text/javascript'>
                            $.alert({
                        title: 'Alert!',
                 content: 'Datos agregados correctamente!',
              });
            </script>";

			//ESTE LO EJECUTA



			ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", scriptjs, false);
			LimpiarControles();





		}
	}
}