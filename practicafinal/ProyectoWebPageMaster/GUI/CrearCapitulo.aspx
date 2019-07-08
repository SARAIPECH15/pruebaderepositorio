<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CrearCapitulo.aspx.cs" Inherits="ProyectoWebPageMaster.GUI.CrearCapitulo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="../recursos/css/bootstrap.css" rel="stylesheet" />
    <link href="../recursos/css/estilosCapitulo.css" rel="stylesheet" />
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
                     <asp:Button ID="Button3" runat="server" Text="Publicar" CssClass="btn btn-warning" />
                </div>
            </div>
            <br /><br />
            <hr />
            <div class="row">
                <div class="col-md-3"></div>
                <div class="col-md-6 text-center">
                   
                    <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server" placeholder="Ingrese nombre del Capítulo"></asp:TextBox>


                </div>
                <div class="col-md-3"></div>



            </div>

        </div>
        
    </form>
</body>
</html>
