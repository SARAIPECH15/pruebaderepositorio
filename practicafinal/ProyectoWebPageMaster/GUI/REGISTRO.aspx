<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Site1.Master" AutoEventWireup="true" CodeBehind="REGISTRO.aspx.cs" Inherits="ProyectoWebPageMaster.GUI.REGISTRO" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.6.3/css/all.css" />

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
    

<script>
		function cambiar_nombre() {
			var fileName = $("#<%=Fu_perfil.ClientID%>").val();
	        $("#<%=Fu_perfil.ClientID%>").next('.custom-file-label').html(fileName);
		}
	</script>
    <style>
       .paddincito{
           margin-top:75px;
       }
       .centro{
           text-align:center;
       }
    </style>

 <!---   <link href="../recursos/Estilos_Login.css" rel="stylesheet" />--->
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   
    	<div class="container-login100" style="background-image: url('../recursos/img/librohd.jpg');">
            <div class="wrap-login100 p-l-55 p-r-55 p-t-80 p-b-30 paddincito">
        <h1 class="card-title centro">Registrate</h1>
                <div class="card-text">
                     <div class="contenedor">
            <div class="input-contenedor">
                <div class="wrap-input100 validate-input m-b-20" >
					<input class="input100" type="text" name="nombre" placeholder="Nombre" id="txt_nombre" runat="server">
					<span class="focus-input100"></span>
				</div>                 
            </div>

             <div class="input-contenedor">
                <div class="wrap-input100 validate-input m-b-20">
					<input class="input100" type="text" name="apellidos" placeholder="Usuario" id="txt_Apellidos" runat="server">
					<span class="focus-input100"></span>
				</div>     
            </div>

             <div class="input-contenedor">             
                 <div class="wrap-input100 validate-input m-b-20">
					<input class="input100" type="text" name="username" placeholder="Usuario" id="txt_Usuario" runat="server">
					<span class="focus-input100"></span>
				</div>               
            </div>

						 
             <div class="input-contenedor">
             <div class="wrap-input100 validate-input m-b-20" data-validate="Enter username or email">
					<input class="input100" type="text" name="Email" placeholder="Example@gmail.com" id="Txt_email" runat="server">
					<span class="focus-input100"></span>
				</div>              
            </div>        
				 <asp:DropDownList ID="DropDownPais" runat="server"></asp:DropDownList>
				 <asp:DropDownList ID="DropDownEstado" runat="server"></asp:DropDownList>
             <div class="input-contenedor">
            <div class="wrap-input100 validate-input m-b-20" >
					<input class="input100" type="text" name="Direccion" required="required" placeholder="Ingrese su dirección" id="txt_Direccion" runat="server">
					<span class="focus-input100"></span>
				</div>     
               
            </div>
             <div class="input-contenedor">
             <div class="wrap-input100 validate-input m-b-25" data-validate = "Enter password">
					<input class="input100" type="password" name="pass" placeholder="Contraseña" id="txt_password" runat="server">
					<span class="focus-input100"></span>             
            </div>

                   <div class="custom-file">
					        
					   <asp:FileUpload CssClass="custom-file-input" ID="Fu_perfil" runat="server" onchange="javascript:cambiar_nombre()"  Visible="true">  </asp:FileUpload>
					  <asp:Label ID="Label5" runat="server" Text="Foto de perfil:" for="customFile"   CssClass="custom-file-label"  data-browse="Examinar"></asp:Label>
						 				  
				</div>




                         <br />
            <asp:Button ID="btn_registrate" Width="100%" runat="server" Text="Registrate" CssClass="btn btn-outline-dark" OnClick="btn_registrate_Click" />
            <p>Al registrarte, aceptas nuestras Condiciones de uso y Política de privacidad.</p>          
        </div>
    </div>
               </div>
       </div>
      </div>

  
    
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
