using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoWebPageMaster.BO;
using ProyectoWebPageMaster.DAO;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing;

namespace ProyectoWebPageMaster.GUI
{
    public partial class crearHistorias : System.Web.UI.Page
    {

        crearhistorias_DAO cmd = new crearhistorias_DAO();
        Genero_Historia cmd2 = new Genero_Historia();
        historias objhistoriadao = new historias();
        HistoriasBO objhistoriabo = new HistoriasBO();

        protected void Page_Load(object sender, EventArgs e)
        {
			if (!IsPostBack)
			{

				llenadoCheklistgenero();
				llenadodrowlistcategiria();
			}
        }


		regis_dao ObjgenDAO = new regis_dao();


        public void limpiarControles()
        {

        }

       

        public void LlenarBo()
        {
            objhistoriabo.Nombre=txtTitulo.Text;
            objhistoriabo.Idautor= Convert.ToInt32(Session["ID_US"]);
            objhistoriabo.Codigo_cat = Convert.ToInt32(DropDownList2.SelectedValue);
            objhistoriabo.Prologo = txtprologo.Value;


        }

        public void LimpiarControles()
        {

        }




		private void llenadoCheklistgenero()
		{

			CheckBoxList1.DataSource = ObjgenDAO.Consultar("Select * from GENERO");
			CheckBoxList1.DataTextField = "NOMBRE";
			CheckBoxList1.DataValueField = "CODIGO_GEN";
			CheckBoxList1.DataBind();
			//CheckBoxList1.Items.Insert(0, new ListItem("Seleccionar", "0"));


		}

		

		private void llenadodrowlistcategiria()
		{

			DropDownList2.DataSource = ObjgenDAO.Consultar("Select * from CATEGORIA");
			DropDownList2.DataTextField = "NOMBRE";
			DropDownList2.DataValueField = "CODIGO_CAT";
			DropDownList2.DataBind();
			DropDownList2.Items.Insert(0, new ListItem("Seleccionar", "0"));


		}

		protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

       

        protected void btnGuardar2_Click(object sender, EventArgs e)
        {

            LlenarBo();
           // int idHistoria;
          //  cmd2.Codigo_historia = cmd.agregarHistoria(objhistoriabo);

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

                        objhistoriabo.Foto = NombreArchivoPequenio;
                        //agrega a la base de datos
                        objhistoriabo.Codig_his = cmd.agregarHistoria(objhistoriabo);

                        string RutaImagenes = "~/recursos/fotos_portadasLibros/";
                        Bitmap ImagenEnBinario = new Bitmap(Fu_perfil.PostedFile.InputStream);
                        ObjetoImagen = objhistoriabo.RedimencionarImagen(ImagenEnBinario, 100);
                        switch (fileExtension)
                        {
                            case ".png":
                                ObjetoImagen.Save(Server.MapPath(RutaImagenes) + objhistoriabo.Codig_his + NombreArchivoPequenio, ImageFormat.Png);

                                break;
                            case ".jpg":
                                ObjetoImagen.Save(Server.MapPath(RutaImagenes) + objhistoriabo.Codig_his + NombreArchivoPequenio, ImageFormat.Jpeg);
                                break;
                            case ".jpeg":
                                ObjetoImagen.Save(Server.MapPath(RutaImagenes) + objhistoriabo.Codig_his + NombreArchivoPequenio, ImageFormat.Jpeg);
                                break;
                        }


                    }
                }

            }
            else
            {
                objhistoriabo.Foto = "";
                objhistoriabo.Codig_his = cmd.agregarHistoria(objhistoriabo);


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








            foreach (ListItem listacursos in CheckBoxList1.Items)
            {


                if (listacursos.Selected == true)
                {

                    string idgenero = listacursos.Value.ToString();
                    cmd2.Codigo_genero = Convert.ToInt32(idgenero);
                    cmd2.Codigo_historia = objhistoriabo.Codig_his;
                    cmd.agregarGeneroHistoria(cmd2);


                }
                
            }
        }
    }
}