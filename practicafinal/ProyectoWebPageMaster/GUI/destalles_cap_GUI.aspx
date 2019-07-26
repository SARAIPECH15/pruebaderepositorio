<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/administrador2.Master" AutoEventWireup="true" CodeBehind="destalles_cap_GUI.aspx.cs" Inherits="ProyectoWebPageMaster.GUI.destalles_cap_GUIaspx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

	
    



</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	 <link href="../recursos/css/estilosCapitulo.css" rel="stylesheet" />
 
	 <div class="container-fluid">
    <div class="row">
        <div class="col-md-1"></div>
        <div class="col-md-3">
        </div>
        <div class="col-md-7">
			
            <div class="card text-center">
           <h5 class="card-header">Detalles del capitulo</h5>
             <div class="card-body">
          
                 <asp:Label ID="Label1" runat="server" Text="Historia:"></asp:Label><br />
                 <asp:TextBox ID="txtTitulo" runat="server" Width="705px" CssClass="form-control" ReadOnly="True"></asp:TextBox>
				  <asp:Label ID="Label3" runat="server" Text="Capitulo:"></asp:Label><br />
				     <asp:TextBox ID="txt_nombre" runat="server" Width="705px" CssClass="form-control" ReadOnly="True"></asp:TextBox>
				  <asp:Label ID="Label4" runat="server" Text="Numero:"></asp:Label><br />
				     <asp:TextBox ID="Txt_numero" runat="server" Width="705px" CssClass="form-control" ReadOnly="True"></asp:TextBox>
				 
				  <asp:TextBox ID="TXT_ID_cap" runat="server" Width="705px" CssClass="form-control"  visible="false" ReadOnly="True"></asp:TextBox>
				  <asp:Label ID="Label5" runat="server" Text="Autor:"></asp:Label><br />

				  <asp:TextBox ID="TXT_QUIEN" runat="server" Width="705px" CssClass="form-control" ReadOnly="True"></asp:TextBox>
				 <br /><br />
                 <hr />
			
                 <asp:Label ID="Label2" runat="server" Text="Descripción:"></asp:Label><br />
                 <textarea id="txtcontenido" cols="130" rows="2" class="form-control" runat="server"></textarea><br /><br />
                 <hr />
				
                   
            </div>
   


        </div>
			<div class="card-footer text-muted">  <asp:Button ID="Button1" runat="server" Text="Guardar" OnClick="btnGuardar2_Click"  CssClass="btn-primary"/></div>
   
    </div>
  
    </div>
    <br /><br />
	</div>
</asp:Content>
