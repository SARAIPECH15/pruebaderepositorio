<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/administrador2.Master" AutoEventWireup="true" CodeBehind="UsuariosABC.aspx.cs" Inherits="ProyectoWebPageMaster.GUI.UsuariosABC" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">



         <script>
          function cambiar_nombre() {
              var fileName = $("#<%=Fu_perfil.ClientID%>").val();
            $("#<%=Fu_perfil.ClientID%>").next('.custom-file-label').html(fileName);





          }
	   </script>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <div class="row text-center">


        <div class="col-md-3">


        </div>

         <div class="col-md-7 ">

              <div class="card shadow mb-4">
                <div class="card-header py-3">
                  <h6 class="m-0 font-weight-bold text-primary">Agregar Usuarios</h6>
                </div>
                <div class="card-body">
                <asp:textbox runat="server" visible="false" id="txtid"></asp:textbox><br />
        <asp:textbox runat="server" visible="false" id="txtFoto_usuario"></asp:textbox>

                    <asp:Label ID="Label1" runat="server" Text="Ingrese foto de perfil:"></asp:Label><br />
                    <div class="custom-file">
                    <asp:FileUpload CssClass="custom-file-input" ID="Fu_perfil" runat="server" onchange="javascript:cambiar_nombre()"  Visible="true">  </asp:FileUpload>
                      <asp:Label ID="Label10" runat="server" Text="Foto de perfil:" for="customFile"   CssClass="custom-file-label"  data-browse="Examinar"></asp:Label>
                    </div><br /><br />
                    <div class="row">
                    <div class="col-md-6">
                          <asp:Label ID="Label4" runat="server" Text="Ingrese Nombre(s):"></asp:Label><br />
                    <asp:TextBox ID="txt_nombre" runat="server"></asp:TextBox><br />

                    <asp:Label ID="Label5" runat="server" Text="Ingrese Apellidos:"></asp:Label><br />
                    <asp:TextBox ID="txt_Apellidos" runat="server"></asp:TextBox><br />

                    <asp:Label ID="Label6" runat="server" Text="Ingrese dirección:"></asp:Label><br />
                    <asp:TextBox ID="txt_Direccion" runat="server"></asp:TextBox><br />
                        <asp:Label ID="Label9" runat="server" Text="Ingrese su Email:"></asp:Label><br />
                        <asp:TextBox ID="Txt_email" runat="server" TextMode="Email" PlaceHolder="ejemplo@hotmail.com"></asp:TextBox><br />
                    <asp:Label ID="Label7" runat="server" Text="Ingrese Pais:"></asp:Label><br />
                    <asp:DropDownList ID="DropDownPais" runat="server" OnSelectedIndexChanged="seleccionarpais" AutoPostBack="true"></asp:DropDownList><br />

                        <asp:Label ID="Label8" runat="server" Text="Ingrese Estado:"></asp:Label><br />

                        <asp:DropDownList ID="DropDownEstado" runat="server"></asp:DropDownList><br />
                        <asp:Label ID="Label11" runat="server" Text="Ingrese Tipo de Usuario"></asp:Label><br />
                        <asp:DropDownList ID="DropDownTipousuario" runat="server"></asp:DropDownList><br />
                    <asp:Label ID="Label2" runat="server" Text="Ingrese nombre de Usuario:"></asp:Label><br />
                    <asp:TextBox ID="txt_Usuario" runat="server"></asp:TextBox><br />
                    <asp:Label ID="Label3" runat="server" Text="Ingrese la contraseña:"></asp:Label><br />
                    <asp:TextBox ID="txt_password" runat="server" TextMode="Password"></asp:TextBox><br /><br />


                    </div>&nbsp
                  <div class="col-md-5 text-center">
                      <br /><br /><br />
                      <asp:Image ID="Image1" runat="server" src="../img/paradrop.png"/>

                  </div></div>
                    <asp:Button ID="btnagregar" runat="server" Text="Agregar" CssClass="btn btn-outline-success" align="center" OnClick="btnagregar_Click" />&nbsp
                    <asp:Button ID="btnactualizar" runat="server" Text="Actualizar" CssClass="btn btn-outline-warning" OnClick="btnactualizar_Click" />&nbsp
                    <asp:Button ID="btneliminar" runat="server" Text="Eliminar" CssClass="btn btn-outline-danger" OnClick="btneliminar_Click" />

                </div>
              </div>
   </div>

    </div>



    
    <div class="row">
        <div class="col-md-2">

        </div>


    <div class="col-md-12">

        <!-- Collapsable Card Example -->
              <div class="card shadow mb-4">
                <!-- Card Header - Accordion -->
                <a href="#collapseCardExample" class="d-block card-header py-3" data-toggle="collapse" role="button" aria-expanded="true" aria-controls="collapseCardExample">
                  <h6 class="m-0 font-weight-bold text-primary">Tipos de usuarios agregados:</h6>
                </a>
                <!-- Card Content - Collapse -->
                <div class="collapse show" id="collapseCardExample">
                  <div class="card-body">
                   

                      <asp:GridView ID="dgv_usuarios" runat="server"  nullDisplayText="" OnRowDataBound="dgv_usuarios_RowDataBound" OnSelectedIndexChanged="dgv_usuarios_SelectedIndexChanged"></asp:GridView>

                  </div>
                </div>
              </div>


    </div>
</div>








</asp:Content>
