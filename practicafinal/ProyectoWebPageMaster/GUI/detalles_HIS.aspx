<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/administrador2.Master" AutoEventWireup="true" CodeBehind="detalles_HIS.aspx.cs" Inherits="ProyectoWebPageMaster.GUI.detalles" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

	    <link href="../recursos/Estilos_MISHISTORIAS.css" rel="stylesheet" />
    



</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	 <link href="../recursos/css/estilosCapitulo.css" rel="stylesheet" />
 
	 <div class="container-fluid">
    <div class="row">
        <div class="col-md-1"></div>
        <div class="col-md-3">

           <div class="ih-item square colored effect1 left_and_right"  style="width:200px; height:200px; ">
          
               <asp:Image ID="Image1" runat="server"  Height="200px" Width="200px"/><br />
             <div class="card-body">
              <br /><br />
                 
                 </div>
                  </div>



        </div>
        <div class="col-md-7">
			
            <div class="card text-center">
           <h5 class="card-header">Detalles de la historia</h5>
             <div class="card-body">
          
                 <asp:Label ID="Label1" runat="server" Text="Título:"></asp:Label><br />
                 <asp:TextBox ID="txtTitulo" runat="server" Width="705px" CssClass="form-control"  ReadOnly="True"></asp:TextBox>
				  <asp:TextBox ID="TXT_ID" runat="server" Width="705px" CssClass="form-control" visible="false" ReadOnly="True"></asp:TextBox>
				      <asp:Label ID="Label" runat="server" Text="Autor:"></asp:Label><br />
				  <asp:TextBox ID="TXT_AUTOR" runat="server" Width="705px" CssClass="form-control"   ReadOnly="True"></asp:TextBox><br /><br />
                 <hr />
			
                 <asp:Label ID="Label2" runat="server" Text="Descripción:"></asp:Label><br />
                 <textarea id="txtprologo" cols="130" rows="2" class="form-control" runat="server" contenteditable="false"></textarea><br /><br />
                 <hr />
				
                   
            </div>
   


        </div>
			<div class="card-footer text-muted">
  <div class="col-md-1">  <asp:Button ID="btnGuardar2" runat="server" Text="Guardar" OnClick="btnGuardar2_Click"  CssClass="btn-primary"/></div>
  </div>
        
    </div>
  
    </div>
    <br /><br />
	</div>
</asp:Content>
