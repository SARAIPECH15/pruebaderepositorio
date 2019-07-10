<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CrearCapitulo.aspx.cs" Inherits="ProyectoWebPageMaster.GUI.CrearCapitulo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="../recursos/css/bootstrap.css" rel="stylesheet" />
    <link href="../recursos/css/estilosCapitulo.css" rel="stylesheet" />
    <script src="../recursos/js/jquery-3.2.1.min.js"></script>
    <script src="../recursos/js/jquery.richtext.js"></script>
    <link href="../recursos/css/richtext.min.css" rel="stylesheet" />
    <script src="../recursos/js/jquery.richtext.js"></script>
    <link href="../recursos/css/site.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css"/>

</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid">
            <br />
            <div class="row ">
                <br />
                <div class="col-md-2" >
                    <asp:Image ID="Image1" runat="server" />
                 
                  <a href="../GUI/crearHistorias.aspx" class="btn btn-danger btn-icon-split">
                    <span class="icon text-white-50">
                      <i class="fas fa-trash"></i>
                    </span>
                    <span class="text">Regresar</span>
                  </a>
                </div>
                <div class="col-md-10 nav justify-content-end">
                    <br /><br />
                    <asp:Button ID="Button1" runat="server" Text="Guardar" CssClass="btn btn-info" />&nbsp
                     <asp:Button ID="btnPublicar" runat="server" Text="Publicar" CssClass="btn btn-warning" data-toggle="modal" data-target="#modalLoginForm" />
                </div>
            </div>
            <br />
            <hr />
            <div class="row">
                <div class="col-md-3"></div>
                <div class="col-md-6 text-center">
                   
                    <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server" placeholder="Ingrese nombre del Capítulo"></asp:TextBox>


                </div>
                <div class="col-md-3"></div>



            </div>
            <div class="row">
                <div class="col-md-2"></div>
                <div class="col-md-8">
                    <br /><br />
                    <textarea id="txtAreacapitulo" cols="20" rows="2"></textarea>
                    <script>
                   $(document).ready(function() {
                     $('#txtAreacapitulo').richText();
                     });
                    </script>

                </div>
                <div class="col-md-2"></div>



            </div>
        </div>
        

        <!--modal para enviar al admi-->

            <div class="modal" tabindex="-1" role="dialog" id="modalLoginForm">
  <div class="modal-dialog" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <h5 class="modal-title">Felicidades!</h5>
        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
          <span aria-hidden="true">&times;</span>
        </button>
      </div>
      <div class="modal-body">
        <p>Tu capítulo fue enviado para aprobar.</p>
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-secondary" data-dismiss="modal">Cerrar</button>
        <button type="button" class="btn btn-primary">Aceptar</button>
      </div>
    </div>
  </div>
</div>



    </form>
</body>
</html>
