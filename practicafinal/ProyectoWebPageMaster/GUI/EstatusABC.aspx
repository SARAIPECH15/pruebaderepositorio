<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/administrador2.Master" AutoEventWireup="true" CodeBehind="EstatusABC.aspx.cs" Inherits="ProyectoWebPageMaster.GUI.EstatusABC" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
      <br />
    <!-- Basic Card Example -->
    <div class="row text-center">
        <div class="col-md-2">

        </div>
      <div class="col-md-7 ">

              <div class="card shadow mb-4">
                <div class="card-header py-3">
                  <h6 class="m-0 font-weight-bold text-primary">Estatus</h6>
                </div>
                <div class="card-body">
                
                    <asp:Label ID="Label1" runat="server" Text="Ingrese el tipo de Estatus:"></asp:Label><br /><br />
                    <asp:TextBox ID="txt_IDEst" Visible="false" runat="server"></asp:TextBox>
                    <asp:TextBox ID="txt_Est" runat="server"></asp:TextBox><br /><br><br />
                    <asp:Button ID="btn_AgregarEst" runat="server" Text="Agregar" CssClass="btn btn-outline-success" OnClick="btn_AgregarEst_Click" />&nbsp
                    <asp:Button ID="btn_ActualizarEst" runat="server" Text="Actualizar" CssClass="btn btn-outline-warning" OnClick="btn_ActualizarEst_Click" />&nbsp
                    <asp:Button ID="btn_EliminarEst" runat="server" Text="Eliminar" CssClass="btn btn-outline-danger" OnClick="btn_EliminarEst_Click" />

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
                     <asp:GridView ID="dgv_Estatus"  cssClass="table table-hover" OnRowDataBound="dgv_Estatus_RowDataBound" OnSelectedIndexChanged="dgv_Estatus_SelectedIndexChanged" DisplayNull="" runat="server"></asp:GridView>
              </div>
     

    </div>
</div>

</asp:Content>
