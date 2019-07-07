<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/administrador2.Master" AutoEventWireup="true" CodeBehind="ClasificacionABC.aspx.cs" Inherits="ProyectoWebPageMaster.GUI.ClasificacionABC" EnableEventValidation="false" %>
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
                  <h6 class="m-0 font-weight-bold text-primary">Clasificaciòn</h6>
                </div>
                <div class="card-body">
                
                    <asp:Label ID="Label1" runat="server" Text="Ingrese el tipo de Clasificaciòn:"></asp:Label><br /><br />
                    <asp:TextBox ID="txt_IDClas" Visible="false" runat="server"></asp:TextBox>
                    <asp:TextBox ID="txt_Clasificacion" OnLoad="txt_Clasificacion_Load" required="required"  runat="server"></asp:TextBox><br /><br><br />
                    <asp:Button ID="btn_AgregarClas" runat="server" Text="Agregar" CssClass="btn btn-outline-success" OnClick="btn_AgregarClas_Click" />&nbsp
                    <asp:Button ID="btn_ActualizarClas" runat="server" Text="Actualizar" CssClass="btn btn-outline-warning" OnClick="btn_ActualizarClas_Click"/>&nbsp
                    <asp:Button ID="btn_EliminarClas" runat="server" Text="Eliminar" CssClass="btn btn-outline-danger" OnClick="btn_EliminarClas_Click" />

                </div>
              </div>
   </div>
       </div>


    <div class="row">
        <div class="col-md-1">

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
                     <asp:GridView ID="dgv_Clasificacion" cssClass="table table-hover"  OnRowDataBound="dgv_Clasificacion_RowDataBound" OnSelectedIndexChanged="dgv_Clasificacion_SelectedIndexChanged" DisplayNull="" runat="server"></asp:GridView>
              </div>
     

    </div>
</div>
</asp:Content>
