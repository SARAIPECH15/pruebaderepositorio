<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Site1.Master" AutoEventWireup="true" CodeBehind="abcGenero.aspx.cs" Inherits="ProyectoWebPageMaster.GUI.abcESTATUS" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="col-md-12 colorform">
        
            <br /><br /><br /><br />
            	<div class="row">
	         <div class="col-md-5"></div>
             <div class="col-md-2">

                   <!-- normal -->
    <div class="ih-item circle effect1"><a href="#">
        <div class="spinner"></div>
        <div class="img"><img src="../recursos/img/fotos_perfil/perfil.jpg" alt="img"></div>
        <div class="info">
          <div class="info-back">
            <h3>Sarai Pech</h3>
            <p>sarita@gmail.com</p>
          </div>
        </div></a></div>
    <!-- end normal -->
         

             </div>
             <div class="col-md-5"></div>
                    </div>

	</div>
    <br />
    <div class="col-md-12">


        <ul class="nav nav-tabs" id="myTab" role="tablist">
  <li class="nav-item">
    <a class="nav-link active" id="home-tab" data-toggle="tab" href="#home" role="tab" aria-controls="home" aria-selected="true">General
    </a>
  </li>
  <li class="nav-item">
    <a class="nav-link" id="profile-tab" data-toggle="tab" href="#profile" role="tab" aria-controls="profile" aria-selected="false">Conversaciones</a>
  </li>
  <li class="nav-item">
    <a class="nav-link" id="contact-tab" data-toggle="tab" href="#contact" role="tab" aria-controls="contact" aria-selected="false">Estadisticas</a>
  </li>
<li class="pull-right"> <button type="button" class="btn btn-outline-primary">Editar Perfil</button>
 </li> 

</ul>

  </div>
	<div>

 <nav class="navbar-default navbar-side"  role="navigation">
            <div class="sidebar-collapse">
                <ul class="nav" id="main-menu"  style="height:460PX" >
                 


                    <li class="active-link">
                        <a href="index.html" ><i class="fa fa-desktop "></i>Dashboard <span class="badge">Included</span></a>
                    </li>
                   

                    <li>
                        <a href="ui.html"><i class="fa fa-table "></i>UI Elements  <span class="badge">Included</span></a>
                    </li>
                    <li>
                        <a href="blank.html"><i class="fa fa-edit "></i>Blank Page  <span class="badge">Included</span></a>
                    </li>


                    <li>
                        <a href="#"><i class="fa fa-qrcode "></i>My Link One</a>
                    </li>
                    <li>
                        <a href="#"><i class="fa fa-bar-chart-o"></i>My Link Two</a>
                    </li>

                    <li>
                        <a href="#"><i class="fa fa-edit "></i>My Link Three </a>
                    </li>
                    <li>
                        <a href="#"><i class="fa fa-table "></i>My Link Four</a>
                    </li>
                     <li>
                        <a href="#"><i class="fa fa-edit "></i>My Link Five </a>
                    </li>
                    
                </ul>
                            </div>

        </nav>

		</div>
        <!-- /. NAV SIDE  -->
        <div id="page-wrapper" >
            <div id="page-inner">
                <div class="row">
                    <div class="col-lg-12">
                     <h2>ADMIN DASHBOARD</h2>   
                    </div>
                </div>              
                 <!-- /. ROW  -->
                  <hr />
                <div class="row">
                    <div class="col-lg-12 ">
                        <div class="alert alert-info">
                             <strong>Welcome Jhon Doe ! </strong> You Have No pending Task For Today.
                        </div>
                       
                    </div>
                    </div>

				<hr>
				 <div class="row">
					<div class="col-lg-6 col-md-6">
						<h5>Ingresa Los datos</h5>
					
					<div class="form-group">
                            <label>Nombre Género</label>
                        <asp:TextBox ID="txt_Genero" CssClass="form-control" runat="server"></asp:TextBox>
                         <asp:TextBox ID="txt_CODIGO_GEN" Visible="false" CssClass="form-control" runat="server"></asp:TextBox>
                            <p class="help-block">Porfavor  escribe aquí.</p>



                        </div>
						<br />
                        <asp:Button ID="btn_AgregarGen" CssClass="btn btn-outline-primary" runat="server" Text="Agregar" OnClick="btn_AgregarGen_Click"/>
                         <asp:Button ID="btn_ModificarGen" CssClass="btn btn-outline-primary" runat="server" Text="Modificar" OnClick="btn_ModificarGen_Click"/>
                         <asp:Button ID="btn_EliminarGen" CssClass="btn btn-outline-primary" runat="server" Text="Eliminar" OnClick="btn_EliminarGen_Click"/>
                        <br >
                        <br>
                       
                      


                    </div>
                     <asp:GridView ID="dgv_Genero" CssClass="table table-hover" OnRowDataBound="dgv_Genero_RowDataBound" 
                      OnSelectedIndexChanged="dgv_Genero_SelectedIndexChanged" NullDisplay="" runat="server"></asp:GridView>





					
                    
                </div>
                <!-- /. ROW  -->
                <hr>



				</div>































				 </div>
                 
	  
	<script src="../recursos/js/jquery-1.10.2.js"></script>
      <!-- BOOTSTRAP SCRIPTS -->
    <script src="../recursos/js/bootstrap.min.js"></script>
      <!-- CUSTOM SCRIPTS -->
    <script src="../recursos/js/custom.js"></script>
	 <link href='http://fonts.googleapis.com/css?family=Open+Sans' rel='stylesheet' type='text/css' />



	








</asp:Content>
