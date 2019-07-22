﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/administrador2.Master" AutoEventWireup="true" CodeBehind="Estadisticas_Libros_Admin_GUI.aspx.cs" Inherits="ProyectoWebPageMaster.GUI.Estadisticas_Libros_Admin_GUI" %>




<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<!--Load the AJAX API-->
 <script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>
    <script type="text/javascript">
		google.charts.load('current', { 'packages': ['corechart'] });
		google.charts.setOnLoadCallback(drawChart);

		function drawChart() {

			var data = google.visualization.arrayToDataTable([
				['Task', 'Hours per Day'],
				['Work', 11],
				['Eat', 2],
				['Commute', 2],
				['Watch TV', 2],
				['Sleep', 7]
			]);

			var options = {
				title: 'My Daily Activities'
			};

			var chart = new google.visualization.PieChart(document.getElementById('piechart'));

			chart.draw(data, options);
		}
    </script>






</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	    <!--Div that will hold the pie chart-->
 <div id="piechart" style="width: 900px; height: 500px;"></div>

</asp:Content>
