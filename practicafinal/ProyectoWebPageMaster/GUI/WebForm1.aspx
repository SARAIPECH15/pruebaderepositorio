<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/administrador2.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ProyectoWebPageMaster.GUI.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

	<script src="../recursos/charts/Chart.bundle.js"></script>
	<script src="../recursos/charts/Chart.bundle.min.js"></script>
	<link href="../recursos/charts/Chart.css" rel="stylesheet" />
	<script src="../recursos/charts/Chart.js"></script>
	<link href="../recursos/charts/Chart.min.css" rel="stylesheet" />
	<script src="../recursos/charts/Chart.min.js"></script>

	 <script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>
    <script type="text/javascript">
     google.charts.load('current', {'packages':['corechart']});
      google.charts.setOnLoadCallback(drawChart);
			
      function drawChart() {
               
        var data = google.visualization.arrayToDataTable(<%=obtenerdatos3()%>);

		  var options = {
			  title: 'Estadistica',
			  backgroundColor: { fill: "Animation" },
			  is3D: true,
			  legend: { position: "labeled", textStyle: { color: "blue", fontSize: 14 } },
			  tooltip: { textStyle: { color: "blue" }, showColorcode: true }
			  




        };

        var chart = new google.visualization.PieChart(document.getElementById('piechart'));

        chart.draw(data, options);
      }
	
	
		google.charts.load('current', { 'packages': ['corechart'] });
		google.charts.setOnLoadCallback(drawChart1);
		function drawChart1() {

			var datos = new google.visualization.DataTable();
			datos.addColumn('date', 'año');
			datos.addColumn('number', 'java');
			datos.addColumn('number', 'phyton');  //valores y
			datos.addColumn('number', 'c#');
			datos.addColumn('number', 'JavaScript');
			
			/*data.addRows([
				[new Date(2015,5,6), 15, 2.8, 5.7, 3.6]
				[new Date(2016, 5, 6), 13, 4.4, 5.7, 7.6]   //valores x
				[new Date(2017, 5, 6), 14, 6.8, 5.7, 5.6]


			]);*/
			 datos.addRows(<%=obtenerdatos2()%>)

			var options = {
				title: 'Estadistica',

				legend: { position: "legend", textStyle: { color: "blue", fontSize: 14 } },

				hAxis: {

					tittle :"Fecha"
				},

				vAxis: {

					tittle: "Popularidad",
					minValue: 0,
					minValue: 20,
					format: '##,##%'


				},



	         };

			var chart = new google.visualization.LineChart(document.getElementById('Linechart'));
			var format = new google.visualization.NumberFormat({ pattern: '##,##%' });
			

			chart.draw(datos, options);
			format.format(datos, 1);
        }


	</script>
	
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<div class="row">
		<div class="col-md-2"></div>
		<div class="col-md-8">
  <div id="piechart" style="width: 900px; height: 500px;"></div>
			</div>
		<div class="col-md-2"></div>
		</div>
	<div class="row">
		<div class="col-md-2"></div>
		<div class="col-md-8">
  <div id="Linechart" style="width: 900px; height: 500px;"></div>
			</div>
		<div class="col-md-2"></div>

</div>

</asp:Content>
