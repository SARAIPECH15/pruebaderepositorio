using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoWebPageMaster.DAO;
using ProyectoWebPageMaster.BO;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace ProyectoWebPageMaster.GUI
{
    public partial class EditarPerfil : System.Web.UI.Page
    {

        registro_boo objbo2 = new registro_boo();
        regis_dao objdao2 = new regis_dao();


        estadosDAO objestadosDAO = new estadosDAO();
        estadosBO objestadosbo = new estadosBO();
        PaisDAO objpaisDAO = new PaisDAO();




        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ID_US"] == null)
            {
                Response.Redirect("../GUI/1.aspx");

            }
            else
            {
                objbo2.Id = Convert.ToInt32(Session["ID_US"]);
                objdao2.busca_usuario(objbo2);
                string ruta = "~/recursos/fotos_usuarios/" + objbo2.Id + objbo2.Fotoperfil;
                //ruta = HttpUtility.HtmlDecode;
                imgperfilusuario.ImageUrl = ruta;
                txt_nombre.Text = objbo2.Nombre;
                txt_Apellidos.Text = objbo2.Apeliido;
                txt_Direccion.Text = objbo2.Direccion;
                Txt_email.Text = objbo2.Email;
                txt_password.Text = objbo2.Comtrasena;
                txt_Usuario.Text = objbo2.Usuario;
                txtFoto_usuario.Text = objbo2.Fotoperfil;
                // DropDownEstado.Text = objbo2.Cod_ciu;
                // DropDownPais.Text = objbo2.Cod_pais;
            }

            if (!IsPostBack)
            {
                llenadoDropDownPais();
            }

        }


        protected void llenarbo()
        {


            objbo2.Nombre = txt_nombre.Text;
            objbo2.Usuario = txt_Usuario.Text;
            objbo2.Email = Txt_email.Text;
            objbo2.Direccion = txt_Direccion.Text;
            objbo2.Comtrasena = txt_password.Text;
            objbo2.Apeliido = txt_Apellidos.Text;
            objbo2.Id = Convert.ToInt32(Session["ID_US"]);
            objbo2.Fotoperfil = txtFoto_usuario.Text;
            objbo2.Cod_ciu = Convert.ToInt32(DropDownEstado.SelectedValue);
            objbo2.Cod_pais = Convert.ToInt32(DropDownPais.SelectedValue);


        }

        protected void btnactualizar_Click(object sender, EventArgs e)
        {
            llenarbo();
            //agrego el id al bo
            objbo2.Id = Convert.ToInt32(Session["ID_US"]);
            if (txtFoto_usuario.Text != "")
            {
                string[] partes;
                partes = txtFoto_usuario.Text.Split('_');
                objbo2.Fotoperfil = '_' + partes[1];
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
                        objbo2.Fotoperfil = NombreArchivoPequenio;


                        string RutaImagenes = "~/recursos/fotos_usuarios/";
                        //borro la foto anterior
                        var file = Path.Combine(Server.MapPath(RutaImagenes), txtFoto_usuario.Text);
                        if (File.Exists(file))
                        {
                            File.Delete(file);
                        }



                        Bitmap ImagenEnBinario = new Bitmap(Fu_perfil.PostedFile.InputStream);
                        ObjetoImagen = objbo2.RedimencionarImagen(ImagenEnBinario, 100);
                        switch (fileExtension)
                        {
                            case ".png":
                                ObjetoImagen.Save(Server.MapPath(RutaImagenes) + objbo2.Id + NombreArchivoPequenio, ImageFormat.Png);

                                break;
                            case ".jpg":
                                ObjetoImagen.Save(Server.MapPath(RutaImagenes) + objbo2.Id + NombreArchivoPequenio, ImageFormat.Jpeg);
                                break;
                            case ".jpeg":
                                ObjetoImagen.Save(Server.MapPath(RutaImagenes) + objbo2.Id + NombreArchivoPequenio, ImageFormat.Jpeg);
                                break;
                        }


                    }

                }
            }
            int valor = objdao2.modificarusuario2(objbo2);
            string scriptjs = @"<script type='text/javascript'>
                            $.alert({
               title: 'Alert!',
                content: 'Datos actualizados correctamente!',
                });
                        </script>";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", scriptjs, false);
            LimpiarControles();
        }

        private void llenadoDropDownPais()
        {


            DropDownPais.DataSource = objpaisDAO.Consultar("Select * from PAIS");
            DropDownPais.DataTextField = "NOMBRE";
            DropDownPais.DataValueField = "COD_PAIS";
            DropDownPais.DataBind();
            DropDownPais.Items.Insert(0, new ListItem("Seleccionar", "0"));
            DropDownEstado.Items.Insert(0, new ListItem("Seleccionar", "0"));



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


      
        protected void DropDownPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            int usu = Convert.ToInt32(DropDownPais.SelectedValue);
            DropDownEstado.DataSource = objestadosDAO.Consultar("Select * from CIUDAD where COD_PAIS=" + usu);
            DropDownEstado.DataTextField = "NOMBRE";

            DropDownEstado.DataValueField = "COD_CIU";
            DropDownEstado.DataBind();
            DropDownEstado.Items.Insert(0, new ListItem("Seleccionar", "0"));
        }
    }
}