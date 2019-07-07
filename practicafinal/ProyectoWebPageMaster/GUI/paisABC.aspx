<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/administrador2.Master" AutoEventWireup="true" CodeBehind="paisABC.aspx.cs" Inherits="ProyectoWebPageMaster.GUI.paisABC" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">




      <br />
    <!-- Basic Card Example -->
    <div class="row text-center">
        <div class="col-md-2">

        </div>
      <div class="col-md-7 ">

              <div class="card shadow mb-4">
                <div class="card-header py-3">
                  <h6 class="m-0 font-weight-bold text-primary">Tipo de usuario</h6>
                </div>
                <div class="card-body">
                
                     <asp:textbox runat="server" visible="false" id="txtidpais"></asp:textbox>


                    <asp:Label ID="Label1" runat="server" Text="Ingrese el País:"></asp:Label><br /><br />
                    <asp:TextBox ID="txtpais" OnLoad="txtpais_Load" required="required" runat="server"></asp:TextBox><br /><br><br />
                    <asp:Button ID="btnagregar" runat="server" Text="Agregar" CssClass="btn btn-outline-success" OnClick="btnagregar_Click" />&nbsp
                    <asp:Button ID="btnactualizar" runat="server" Text="Actualizar" CssClass="btn btn-outline-warning" OnClick="btnactualizar_Click" />&nbsp
                    <asp:Button ID="btneliminar" runat="server" Text="Eliminar" CssClass="btn btn-outline-danger" OnClick="btneliminar_Click" />

                </div>
              </div>
   </div>
       </div>


    <div class="row">
        <div class="col-md-1">

        </div>


    <div class="col-md-9 text-center">

        <!-- Collapsable Card Example -->
              <div class="card shadow mb-4">
                <!-- Card Header - Accordion -->
                <a href="#collapseCardExample" class="d-block card-header py-3" data-toggle="collapse" role="button" aria-expanded="true" aria-controls="collapseCardExample">
                  <h6 class="m-0 font-weight-bold text-primary">Paises agregados:</h6>
                </a>
                <!-- Card Content - Collapse -->
                <div class="collapse show" id="collapseCardExample">
                  <div class="card-body">
                
                      <asp:GridView ID="gridpais" runat="server" OnRowDataBound="gridpais_RowDataBound" OnSelectedIndexChanged="gridpais_SelectedIndexChanged"></asp:GridView>



                  </div>
                </div>
              </div>


    </div>
</div>











</asp:Content>
