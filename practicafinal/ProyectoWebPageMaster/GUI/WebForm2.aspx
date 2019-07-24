<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/administrador2.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="ProyectoWebPageMaster.GUI.WebForm2" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">


	<script src="../recursos/charts/Chart.bundle.js"></script>
	<script src="../recursos/charts/Chart.bundle.min.js"></script>

	<link href="../recursos/charts/Chart.css" rel="stylesheet" />




	<script src="../recursos/charts/Chart.js"></script>
	<link href="../recursos/charts/Chart.min.css" rel="stylesheet" />

	<script src="../recursos/charts/Chart.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



	<asp:Chart runat="server" ID="Graficas">
		<series><asp:Series Name="Serie"></asp:Series></series>
		<chartareas><asp:ChartArea Name="ChartArea"></asp:ChartArea></chartareas>
	</asp:Chart>



















</asp:Content>
