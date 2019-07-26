<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/administrador2.Master" AutoEventWireup="true" CodeBehind="aceptarhistorias.aspx.cs" Inherits="ProyectoWebPageMaster.GUI.aceptarhistorias" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	  <link href="../recursos/Estilos_MISHISTORIAS.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



<br />

<center><h1>Historias</h1></center>
	<!--paginadorrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrr-->
	<div class=" row">
	<div class="col-md-2"></div>
	
		<div class="col-md-8">
<asp:DataPager ID="DataPager1" runat="server" PagedControlID="lstfotos"  PageSize="6" OnPreRender="imagenes" >
<Fields>
  <asp:NextPreviousPagerField ButtonType="Button"
                                                ShowFirstPageButton="True" 
                                                ShowNextPageButton="False" 
                                               
                                                ButtonCssClass="btn btn-sm btn-default"/>
                    
                    <asp:NextPreviousPagerField ButtonType="Button"
                                                ShowLastPageButton="True" 
                                                ShowPreviousPageButton="False" 
                                              
                                                ButtonCssClass="btn btn-sm btn-default"/>

</Fields>

</asp:DataPager>

	<br />
	<br />
	<br />
	
<!--lissssssssssssssssssssssssssssssstview ojo el gruipitem=inidica maximo columnas y el pagesize escuantos elemttos tendra-->
<asp:ListView ID="lstfotos" runat="server"  GroupItemCount="3" OnSelectedIndexChanged="lstfotos_SelectedIndexChanged">
<LayoutTemplate>

			<asp:PlaceHolder ID="groupPlaceholder" runat="server">
			</asp:PlaceHolder>
</LayoutTemplate>

	<GroupTemplate>
			<div>

				<asp:PlaceHolder ID="itemPlaceholder" runat="server">

				</asp:PlaceHolder>

</div>


			
</GroupTemplate>

		
<ItemTemplate>

<div  class="ImageContainer">
	<asp:Image ID="Image1" runat="server" ImageUrl='<%#"~/recursos/fotos_portadasLibros/"+Eval("CODIG_HIS")+Eval("FOTO")%>' width="250px" heigth="150px" CssClass="card-img"/>
 <div class="caption contenedorlistview"">
		
		<h3  class="card-title"><%# Eval("NOMBRE")%></h3>
		<p class="card-text"><%# Eval("PROLOGO")%></p>


		<p><a href="detalles_HIS.aspx?CODIG_HIS=<%# Eval("CODIG_HIS")%>" class="btn btn-warning" role="button">Ver mas</a>
		</p>


</div>



</div>





</ItemTemplate>

	







</asp:ListView>



</div>

<div class="col-md-2"></div>
</div>







	









</asp:Content>