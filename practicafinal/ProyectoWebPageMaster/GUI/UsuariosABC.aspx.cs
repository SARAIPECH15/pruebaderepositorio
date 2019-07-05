using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing.Imaging;
using System.Drawing;
using ProyectoWebPageMaster.BO;
using ProyectoWebPageMaster.DAO;
using System.IO;

namespace ProyectoWebPageMaster.GUI
{
    public partial class UsuariosABC : System.Web.UI.Page
    {

        registro_boo objbo = new registro_boo();
        regis_dao objdao = new regis_dao();

        estadosDAO objestadosDAO = new estadosDAO();

        PaisDAO objpaisDAO = new PaisDAO();



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
            if (!IsPostBack)
            {
                llenadoDropDownTipousuario();
            }
            dgv_usuarios.DataSource = objdao.buscar_usuarios();
            dgv_usuarios.DataBind();

        }


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

            txtid.Text = "";
            txtFoto_usuario.Text = "";

        }

        protected void llenarbo()
        {


            objbo.Nombre = txt_nombre.Text;
            objbo.Usuario = txt_Usuario.Text;
            objbo.Email = Txt_email.Text;
            objbo.Direccion = txt_Direccion.Text;
            objbo.Comtrasena = txt_password.Text;
            objbo.Apeliido = txt_Apellidos.Text;
            objbo.Id_tipous =Convert.ToInt32(DropDownTipousuario.SelectedValue);

            objbo.Cod_ciu = Convert.ToInt32(DropDownEstado.SelectedValue);
            objbo.Cod_pais = Convert.ToInt32(DropDownPais.SelectedValue);


        }
        private void llenadoDropDownEstado()
        {

            DropDownEstado.DataSource = objestadosDAO.Consultar("Select * from CIUDAD");
            DropDownEstado.DataTextField = "NOMBRE";
            DropDownEstado.DataValueField = "COD_CIU";
            DropDownEstado.DataBind();
            DropDownEstado.Items.Insert(0, new ListItem("Seleccionar", "0"));


        }

        private void llenadoDropDownTipousuario()
        {

            DropDownTipousuario.DataSource = objestadosDAO.Consultar("Select * from TIPOUSUARIO");
            DropDownTipousuario.DataTextField = "NOMBRE";
            DropDownTipousuario.DataValueField = "ID_TIPOUSUARIO";
            DropDownTipousuario.DataBind();
            DropDownTipousuario.Items.Insert(0, new ListItem("Seleccionar", "0"));


        }



        protected void btnagregar_Click(object sender, EventArgs e)
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

                        string RutaImagenes = "~/recursos/fotos_usuarios/";
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

        protected void btnactualizar_Click(object sender, EventArgs e)
        {
            llenarbo();
            //agrego el id al bo
            objbo.Id = int.Parse(txtid.Text);
            if (txtFoto_usuario.Text != "")
            {
                string[] partes;
                partes = txtFoto_usuario.Text.Split('_');
                objbo.Fotoperfil = '_' + partes[1];
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
                        objbo.Fotoperfil = NombreArchivoPequenio;


                        string RutaImagenes = "~/recursos/fotos_usuarios/";
                        //borro la foto anterior
                        var file = Path.Combine(Server.MapPath(RutaImagenes), txtFoto_usuario.Text);
                        if (File.Exists(file))
                        {
                            File.Delete(file);
                        }



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
            int valor = objdao.modificarusuario(objbo);
            string scriptjs = @"<script type='text/javascript'>
                            $.alert({
               title: 'Alert!',
                content: 'Datos actualizados correctamente!',
                });
                        </script>";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", scriptjs, false);
            LimpiarControles();


            dgv_usuarios.DataSource = objdao.buscar_usuarios();
            dgv_usuarios.DataBind();
        }

        protected void btneliminar_Click(object sender, EventArgs e)
        {
            objbo.Id = int.Parse(txtid.Text);
            llenarbo();
            if (txtFoto_usuario.Text != "")
            {
                string RutaImagenes = "~/recursos/fotos_usuarios/";
                //borro la foto anterior
                var file = Path.Combine(Server.MapPath(RutaImagenes), txtFoto_usuario.Text);
                if (File.Exists(file))
                {
                    File.Delete(file);
                }
            }
            int valor = objdao.eliminarusuario(objbo);
            string scriptjs = @"<script type='text/javascript'>
                            $.alert({
               title: 'Mensaje del sistema!',
                type: 'blue',
                content: 'Datos eliminados correctamente!',
                 });
                        </script>";

            ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", scriptjs, false);
            LimpiarControles();
            dgv_usuarios.DataSource = objdao.buscar_usuarios();
            dgv_usuarios.DataBind();
        }



        protected void dgv_usuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtid.Text = dgv_usuarios.SelectedRow.Cells[0].Text;
            txtFoto_usuario.Text = "";
            if (dgv_usuarios.SelectedRow.Cells[1].Text.Trim() != "")
            {
                txtFoto_usuario.Text = dgv_usuarios.SelectedRow.Cells[0].Text + dgv_usuarios.SelectedRow.Cells[1].Text;
            }
            txt_Usuario.Text =HttpUtility.HtmlDecode( dgv_usuarios.SelectedRow.Cells[2].Text);
            txt_password.Attributes.Add("value", dgv_usuarios.SelectedRow.Cells[3].Text);
           
            txt_nombre.Text =HttpUtility.HtmlDecode( dgv_usuarios.SelectedRow.Cells[4].Text);
            txt_Apellidos.Text =HttpUtility.HtmlDecode( dgv_usuarios.SelectedRow.Cells[5].Text);
            txt_Direccion.Text =HttpUtility.HtmlDecode( dgv_usuarios.SelectedRow.Cells[6].Text);
            DropDownTipousuario.Text = dgv_usuarios.SelectedRow.Cells[7].Text;
            DropDownPais.Text = dgv_usuarios.SelectedRow.Cells[8].Text;
            DropDownEstado.Text = dgv_usuarios.SelectedRow.Cells[9].Text;
            Txt_email.Text =HttpUtility.HtmlDecode( dgv_usuarios.SelectedRow.Cells[10].Text);
           
           
            
          
            
           
           
          
           
        }

        protected void dgv_usuarios_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(dgv_usuarios, "Select$" + e.Row.RowIndex);
                e.Row.Attributes["style"] = "cursor:pointer";
            }
        }
    }
}