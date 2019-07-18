<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Site1.Master" AutoEventWireup="true" CodeBehind="1.aspx.cs" Inherits="ProyectoWebPageMaster.GUI._1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

	<link rel="icon" type="image/png" href="../images3/icons/favicon.ico"/>
<!--===============================================================================================-->

<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="../fonts3/font-awesome-4.7.0/css/font-awesome.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="../fonts3/iconic/css/material-design-iconic-font.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="../vendor3/animate/animate.css">
<!--===============================================================================================-->	
	<link rel="stylesheet" type="text/css" href="../vendor3/css-hamburgers/hamburgers.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="../vendor3/animsition/css/animsition.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="../vendor3/select2/select2.min.css">
<!--===============================================================================================-->	
	<link rel="stylesheet" type="text/css" href="../vendor3/daterangepicker/daterangepicker.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="../css3/util.css">
	<link rel="stylesheet" type="text/css" href="../css3/main.css">
    








</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	


		<div class="container-login100" style="background-image: url('../recursos/img/librohd.jpg');">
          
        <div><br /><br /><br /><br />
		<div class="wrap-login100 p-l-55 p-r-55 p-t-80 p-b-30">
                      
			<form class="login100-form validate-form">
				<span class="login100-form-title p-b-37">
					Iniciar sesión
				</span>

				<div class="wrap-input100 validate-input m-b-20" data-validate="Enter username or email">
					<input class="input100" type="text" name="username" placeholder="Usuario" id="txt_Usuario" runat="server">
					<span class="focus-input100"></span>
				</div>

				<div class="wrap-input100 validate-input m-b-25" data-validate = "Enter password">
					<input class="input100" type="password" name="pass" placeholder="Contraseña" id="txt_password" runat="server">
					<span class="focus-input100"></span>
				</div>

				<div class="container-login100-form-btn">
					
					<asp:Button ID="Btn_iniciar2" runat="server" Text="Iniciar Sesión" CssClass="login100-form-btn" OnClick="Btn_iniciar2_Click" />
				</div>

				<div class="text-center p-t-57 p-b-20">
					<span class="txt1">
						Or login with
					</span>
				</div>

				<div class="flex-c p-b-112">
					<a href="#" class="login100-social-item">
						<i class="fa fa-facebook-f"></i>
					</a>

					<a href="#" class="login100-social-item">
						<img src="../images3/icons/icon-google.png" alt="GOOGLE">
					</a>
				</div>

				<div class="text-center">
					<a href="#" class="txt2 hov1">
						Sign Up
					</a>
				</div>
			</form>

			
		</div>
            </div>
	</div>
	
	

	<div id="dropDownSelect1"></div>
	



<!--===============================================================================================-->
	<script src="../vendor3/animsition/js/animsition.min.js"></script>
<!--===============================================================================================-->
	<script src="../vendor3/bootstrap/js/popper.js"></script>

<!--===============================================================================================-->
	<script src="../vendor3/select2/select2.min.js"></script>
<!--===============================================================================================-->
	<script src="../vendor3/daterangepicker/moment.min.js"></script>
	<script src="../vendor3/daterangepicker/daterangepicker.js"></script>
<!--===============================================================================================-->
	<script src="../vendor3/countdowntime/countdowntime.js"></script>
<!--===============================================================================================-->
	<script src="js3/main.js"></script>








</asp:Content>
