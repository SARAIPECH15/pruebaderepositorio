<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/administrador2.Master" AutoEventWireup="true" CodeBehind="aceptarhistorias.aspx.cs" Inherits="ProyectoWebPageMaster.GUI.aceptarhistorias" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<br />
	<br />
	<br />
	<br />
	<br />
	<br />


<br />

<h1>Galeria de Imagenes</h1>
	<!--paginadorrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrr-->
	
<asp:DataPager ID="DataPager1" runat="server" PagedControlID="lstfotos"  PageSize="6" OnPreRender="imagenes" >
<Fields>

<asp:NumericPagerField CurrentPageLabelCssClass="list-group-item active paginador" NumericButtonCssClass="list-group-item active paginador "/>


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

<div  class="ImageContainer hvr-underline-from-center hvr-shadow" style="cursor:default;">
	<asp:Image ID="ImgPhoto" runat="server" ImageUrl='<%#"~/recursos/fotos_portadasLibros/"+Eval("CODIG_HIS")+"_"+Eval("FOTO")%>' width="250px" heigth="150px" class="img-thumbnail"/>
<div class="caption contenedorlistview">
	
		
		<h3><%# Eval("NOMBRE")%></h3>
		<p><%# Eval("PROLOGO")%></p>


		<p><a href="detalles.aspx?CODIG_HIS=<%# Eval("CODIG_HIS")%>" class="btn btn-warning" role="button">Ver mas</a>
		</p>


</div>



</div>





</ItemTemplate>

	







</asp:ListView>











	









</asp:Content>