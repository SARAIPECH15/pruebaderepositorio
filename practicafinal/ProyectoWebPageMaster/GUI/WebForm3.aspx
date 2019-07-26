<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="ProyectoWebPageMaster.GUI.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<div class="card text-center">
  <div class="card-header">
    Featured
  </div>
  <div class="card-body">
    <h5 class="card-title">Historial</h5> 
    <p class="card-text"></p>


	  <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/recursos/ojo-abierto.png"  CssClass="btn-circle" Width="25px" Height="25px"/>
	  <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/recursos/pareja.png" CssClass="btn-circle" Width="25px" Height="25px"/>
	  <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/recursos/charlar.png" CssClass="btn-circle" Width="25px" Height="25px"/>
   

  </div>
  <div class="card-footer text-muted">
	 <a href="#" class="btn btn-primary">Ver más</a>
  </div>
</div>
</asp:Content>
