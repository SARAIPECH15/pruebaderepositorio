<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Site1.Master" AutoEventWireup="true" CodeBehind="EditarPerfil.aspx.cs" Inherits="ProyectoWebPageMaster.GUI.EditarPerfil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    
     <!--================Banner Area =================-->
        <section class="banner_area">
            <div class="container">
                <div class="banner_inner_text">
                    <h2>Editar Perfil</h2>
                    <p>modifica tus datos!</p>
                </div>
            </div>
        </section>
        <!--================End Banner Area =================-->
    <br /><br />

    <div class="container-fluid">
        <div class="row">
            <div class="col-md-1"></div>
            <div class="col-md-3">
                

                <asp:Image ID="Image1" runat="server" />  


                  <div class="col-md-2">

                   <!-- normal -->
    <div class="ih-item circle effect1"><a href="#">
        <div class="spinner"></div>
        <div class="img">  <asp:Image ID="imgperfilusuario" runat="server"  /></div>
        <div class="info">
          <div class="info-back">
             
   <!--         <h3>Sarai Pech</h3>  -->
    <!--        <p>sarita@gmail.com</p>           -->
          </div>
        </div></a></div>
    <!-- end normal -->
     <!--  <img src="../recursos/img/fotos_perfil/perfil.jpg" alt="img">  -->
               
             </div>

                <br /><br />
             <div class="custom-file">
                    <asp:FileUpload CssClass="custom-file-input" ID="Fu_perfil" runat="server" onchange="javascript:cambiar_nombre()"  Visible="true">  </asp:FileUpload>
                      <asp:Label ID="Label10" runat="server" Text="Foto de perfil:" for="customFile"   CssClass="custom-file-label"  data-browse="Examinar"></asp:Label>
                    </div>
                </div>
            <div class="col-md-6">

                <div class="card border-info">
            <h5 class="card-header">Mis datos</h5>
            <div class="card-body">
                <asp:Label ID="Label1" runat="server" Text="Nombre:"></asp:Label>&nbsp
                <asp:TextBox ID="txt_nombre" runat="server" CssClass="form-control" placeholder="Nombre"></asp:TextBox><br />
                <asp:Label ID="Label2" runat="server" Text="Apellido:"></asp:Label>
                <asp:TextBox ID="txt_Apellidos" runat="server" CssClass="form-control"></asp:TextBox><br />
                <asp:Label ID="Label7" runat="server" Text="País:"></asp:Label>
                <asp:DropDownList ID="DropDownPais" runat="server"></asp:DropDownList>&nbsp&nbsp
                <asp:Label ID="Label8" runat="server" Text="Estado:"></asp:Label>
                <asp:DropDownList ID="DropDownEstado" runat="server"></asp:DropDownList><br />
                <asp:Label ID="Label3" runat="server" Text="Dirección:"></asp:Label>
                <asp:TextBox ID="txt_Direccion" runat="server" CssClass="form-control"></asp:TextBox><br />

                <asp:Label ID="Label4" runat="server" Text="Email:"></asp:Label>
                <asp:TextBox ID="Txt_email" runat="server" CssClass="form-control"></asp:TextBox><br />
                <asp:Label ID="Label5" runat="server" Text="Usuario:"></asp:Label>
                <asp:TextBox ID="txt_Usuario" runat="server" CssClass="form-control"></asp:TextBox><br />
                <asp:Label ID="Label6" runat="server" Text="Contraseña:"></asp:Label>
                <asp:TextBox ID="txt_password" runat="server" CssClass="form-control"></asp:TextBox><br />
                <br />
                <asp:Button ID="Button1" runat="server" Text="Guardar" CssClass="btn btn-warning" />
         </div>
            </div>

            </div>
            <div class="col-md-2"></div>
        </div>

    </div>


    <br /><br />





</asp:Content>
