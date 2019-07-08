<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Site1.Master" AutoEventWireup="true" CodeBehind="crearHistorias.aspx.cs" Inherits="ProyectoWebPageMaster.GUI.crearHistorias" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link href="../recursos/css/estilosCapitulo.css" rel="stylesheet" />
    <script src="http://code.jquery.com/jquery-1.10.2.min.js" type="text/javascript"></script>
    <script type="text/javascript">
          function ImagePreview(input) {
            if (input.files && input.files[0]) {
                var reader = new FileReader();
                reader.onload = function (e) {
                    $('#<%=Image1.ClientID%>').prop('src', e.target.result)
                        .width(286)
                        .height(360);
                };
                reader.readAsDataURL(input.files[0]);
                }
            }

    </script>





     <!--================Banner Area =================-->
        <section class="banner_area">
            <div class="container">
                <div class="banner_inner_text">
                    <h2>Crear Historias</h2>
                    <p>Empieza a ser un escritor!</p>
                </div>
            </div>
        </section>
        <!--================End Banner Area =================-->
    <br /><br />
    <div class="container-fluid">
    <div class="row">
        <div class="col-md-1"></div>
        <div class="col-md-3">

           <div class="card" style="width: 18rem; height:30rem; ">
          
               <asp:Image ID="Image1" runat="server" src="../recursos/img/sinimagen.png" Height="360px" Width="286px"/><br />
             <div class="card-body">
              <div class="custom-file">
      <asp:FileUpload CssClass="custom-file-input" ID="Fu_perfil" runat="server" onchange="ImagePreview(this); "  Visible="true"></asp:FileUpload> <asp:Label ID="Label10" runat="server" Text="Foto de portada:" for="customFile"   CssClass="custom-file-label"  data-browse="Examinar"></asp:Label>
                    </div><br /><br />
                 
                 </div>
                  </div>

        </div>
        <div class="col-md-7">

            <div class="card card border-success">
           <h5 class="card-header">Detalles de la historia</h5>
             <div class="card-body">
          
                 <asp:Label ID="Label1" runat="server" Text="Título:"></asp:Label><br />
                 <asp:TextBox ID="txtTitulo" runat="server" Width="705px" CssClass="form-control"></asp:TextBox><br /><br />
                 <hr />
                 <asp:Label ID="Label2" runat="server" Text="Descripción:"></asp:Label><br />
                 <textarea id="TextArea1" cols="130" rows="2" class="form-control"></textarea><br /><br />
                 <hr />
                 <asp:Label ID="Label3" runat="server" Text="Genero:"></asp:Label>&nbsp
                 <asp:DropDownList ID="DropDownList1" runat="server" ></asp:DropDownList><br /><br />
                 <hr />
                 <asp:Label ID="Label4" runat="server" Text="Categoría:"></asp:Label>&nbsp
                 <asp:DropDownList ID="DropDownList2" runat="server" ></asp:DropDownList><br />
                 <hr /><br />
                 <div class="my-2"></div>
                  <a href="../GUI/CrearCapitulo.aspx" class="btn btn-success btn-icon-split">
                    <span class="icon text-white-50">
                      <i class="fas fa-check"></i>
                    </span>
                    <span class="text">Siguiente paso</span>
                  </a>
            </div>
          </div>


        </div>
        <div class="col-md-1"></div>
    </div>
  
    </div>
    <br /><br />
</asp:Content>
