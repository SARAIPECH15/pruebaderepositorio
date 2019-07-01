<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/administrador2.Master" AutoEventWireup="true" CodeBehind="UsuariosABC.aspx.cs" Inherits="ProyectoWebPageMaster.GUI.UsuariosABC" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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
                
                    <asp:Label ID="Label1" runat="server" Text="Ingrese foto de perfil:"></asp:Label><br />
                    <div class="custom-file">
                    <input type="file" class="custom-file-input" id="customFile">
                    <label class="custom-file-label" for="customFile">Choose file</label>
                    </div><br /><br />
                    <div class="row">
                    <div class="col-md-6">
                          <asp:Label ID="Label4" runat="server" Text="Ingrese Nombre(s):"></asp:Label><br />
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />

                    <asp:Label ID="Label5" runat="server" Text="Ingrese Apellidos:"></asp:Label><br />
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br />

                    <asp:Label ID="Label6" runat="server" Text="Ingrese dirección:"></asp:Label><br />
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox><br />

                    <asp:Label ID="Label7" runat="server" Text="Ingrese Pais:"></asp:Label><br />
                    <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList><br />

                    <asp:Label ID="Label2" runat="server" Text="Ingrese nombre de Usuario:"></asp:Label><br />
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
                    <asp:Label ID="Label3" runat="server" Text="Ingrese la contraseña:"></asp:Label><br />
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br /><br />


                    </div>&nbsp
                  <div class="col-md-5 text-center">
                      <br /><br /><br />
                      <asp:Image ID="Image1" runat="server" src="../img/paradrop.png"/>

                  </div></div>
                    <asp:Button ID="Button1" runat="server" Text="Agregar" CssClass="btn btn-outline-success" align="center" />&nbsp
                    <asp:Button ID="Button2" runat="server" Text="Actualizar" CssClass="btn btn-outline-warning" />&nbsp
                    <asp:Button ID="Button3" runat="server" Text="Eliminar" CssClass="btn btn-outline-danger" />

                </div>
              </div>
   </div>

    </div>



    
    <div class="row">
        <div class="col-md-2">

        </div>


    <div class="col-md-9">

        <!-- Collapsable Card Example -->
              <div class="card shadow mb-4">
                <!-- Card Header - Accordion -->
                <a href="#collapseCardExample" class="d-block card-header py-3" data-toggle="collapse" role="button" aria-expanded="true" aria-controls="collapseCardExample">
                  <h6 class="m-0 font-weight-bold text-primary">Tipos de usuarios agregados:</h6>
                </a>
                <!-- Card Content - Collapse -->
                <div class="collapse show" id="collapseCardExample">
                  <div class="card-body">
                    This is a collapsable card example using Bootstrap's built in collapse functionality. <strong>Click on the card header</strong> to see the card body collapse and expand!
                  </div>
                </div>
              </div>


    </div>
</div>








</asp:Content>
