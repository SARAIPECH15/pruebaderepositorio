using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoWebPageMaster.BO;
using ProyectoWebPageMaster.DAO;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace ProyectoWebPageMaster.GUI
{
    public partial class EditarHistoria : System.Web.UI.Page
    {
        regis_dao ObjgenDAO = new regis_dao();
        crearhistorias_DAO objdaohis = new crearhistorias_DAO();
        HistoriasBO objbohis = new HistoriasBO();
        Genero_Historia objbogenhis = new Genero_Historia();
        string idhis;

        protected void Page_Load(object sender, EventArgs e)
        {
            idhis = Request.QueryString["id"];

            if (!IsPostBack)
            {
                if (Session["ID_US"] == null)
                {

                }
                else
                {
                    objbohis.Codig_his = Convert.ToInt32(idhis);
                    
                    objdaohis.busca_libro(objbohis);
                    txtprologo.InnerText = objbohis.Prologo;
                    txtTitulo.Text = objbohis.Nombre;
                    txtfotoportada.Text = objbohis.Foto;
                    string ruta = "~/recursos/fotos_portadasLibros/" + objbohis.Codig_his + objbohis.Foto;
                    Image1.ImageUrl = ruta;

                    DropDownList2.SelectedValue = objbohis.Codigo_cat.ToString();

                    objbogenhis.Codigo_historia = Convert.ToInt32(idhis);
                    objdaohis.busca_historiagenero(objbogenhis);
                    CheckBoxList1.SelectedValue=objbogenhis.Codigo_genero.ToString();


                }
            }


            if (!IsPostBack)
            {

                llenadoCheklistgenero();
                llenadodrowlistcategiria();
            }
        }

        protected void btnGuardar2_Click(object sender, EventArgs e)
        {
            llenarbo();
            if (txtfotoportada.Text != "")
            {
                string[] partes;
                partes = txtfotoportada.Text.Split('_');
                objbohis.Foto = '_' + partes[1];
            }

            if (Fu_perfil.HasFile)
            {
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
                        //agrego la nueva foto de perfil
                        objbohis.Foto = NombreArchivoPequenio;


                        string RutaImagenes = "~/recursos/fotos_portadasLibros/";
                        //borro la foto anterior
                        var file = Path.Combine(Server.MapPath(RutaImagenes), txtfotoportada.Text);
                        if (File.Exists(file))
                        {
                            File.Delete(file);
                        }



                        Bitmap ImagenEnBinario = new Bitmap(Fu_perfil.PostedFile.InputStream);
                        ObjetoImagen = objbohis.RedimencionarImagen(ImagenEnBinario, 100);
                        switch (fileExtension)
                        {
                            case ".png":
                                ObjetoImagen.Save(Server.MapPath(RutaImagenes) + objbohis.Codig_his + NombreArchivoPequenio, ImageFormat.Png);

                                break;
                            case ".jpg":
                                ObjetoImagen.Save(Server.MapPath(RutaImagenes) + objbohis.Codig_his + NombreArchivoPequenio, ImageFormat.Jpeg);
                                break;
                            case ".jpeg":
                                ObjetoImagen.Save(Server.MapPath(RutaImagenes) + objbohis.Codig_his + NombreArchivoPequenio, ImageFormat.Jpeg);
                                break;
                        }


                    }

                }
            }

            int valor = objdaohis.actualizarHistoria(objbohis);

            foreach (ListItem listacursos in CheckBoxList1.Items)
            {


                if (listacursos.Selected == true)
                {
                    llenarbo();
                    string idgenero = listacursos.Value.ToString();
                    objbogenhis.Codigo_genero = Convert.ToInt32(idgenero);
                   
                    objdaohis.actualizargenerohistoria(objbogenhis);


                }

            }
            string scriptjs = @"<script type='text/javascript'>
                            $.alert({
               title: 'Alert!',
                content: 'Datos actualizados correctamente!',
                });
                        </script>";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", scriptjs, false);


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

        private void llenarbo()
        {
            objbohis.Nombre = txtTitulo.Text;
            objbohis.Prologo = txtprologo.Value;
            objbohis.Foto = txtfotoportada.Text;
            objbohis.Codig_his =Convert.ToInt32 (idhis);
            objbohis.Codigo_cat = Convert.ToInt32(DropDownList2.SelectedValue);
            objbogenhis.Codigo_historia = Convert.ToInt32(idhis);
            objbogenhis.Codigo_genero =Convert.ToInt32 (CheckBoxList1.SelectedValue);

        }



        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}