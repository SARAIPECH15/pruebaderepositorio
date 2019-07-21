<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/administrador2.Master" AutoEventWireup="true" CodeBehind="detalles.aspx.cs" Inherits="ProyectoWebPageMaster.GUI.detalles" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

	
    



</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	 <link href="../recursos/css/estilosCapitulo.css" rel="stylesheet" />
 
	 <div class="container-fluid">
    <div class="row">
        <div class="col-md-1"></div>
        <div class="col-md-3">

           <div class="card" style="width: 18rem; height:30rem; ">
          
               <asp:Image ID="Image1" runat="server" src="../recursos/img/sinimagen.png" Height="360px" Width="286px"/><br />
             <div class="card-body">
              <br /><br />
                 
                 </div>
                  </div>



        </div>
        <div class="col-md-7">
			
            <div class="card card border-success">
           <h5 class="card-header">Detalles de la historia</h5>
             <div class="card-body">
          
                 <asp:Label ID="Label1" runat="server" Text="Título:"></asp:Label><br />
                 <asp:TextBox ID="txtTitulo" runat="server" Width="705px" CssClass="form-control"></asp:TextBox>
				  <asp:TextBox ID="TXT_ID" runat="server" Width="705px" CssClass="form-control"   ></asp:TextBox>
				  <asp:TextBox ID="TXT_AUTOR" runat="server" Width="705px" CssClass="form-control"   ></asp:TextBox><br /><br />
                 <hr />
			
                 <asp:Label ID="Label2" runat="server" Text="Descripción:"></asp:Label><br />
                 <textarea id="txtprologo" cols="130" rows="2" class="form-control" runat="server"></textarea><br /><br />
                 <hr />
				
                   
            </div>
   


        </div>
        <div class="col-md-1">  <asp:Button ID="btnGuardar2" runat="server" Text="Guardar" OnClick="btnGuardar2_Click" /></div>
    </div>
  
    </div>
    <br /><br />
	</div>
</asp:Content>
