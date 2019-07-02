<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Site1.Master" AutoEventWireup="true" CodeBehind="REGISTRO.aspx.cs" Inherits="ProyectoWebPageMaster.GUI.REGISTRO" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.6.3/css/all.css" />
<script>
		function cambiar_nombre() {
			var fileName = $("#<%=Fu_perfil.ClientID%>").val();
	        $("#<%=Fu_perfil.ClientID%>").next('.custom-file-label').html(fileName);





		}
	</script>







    <link href="../recursos/Estilos_Login.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="card">
        <div class="card-body formulario">
            <div >
        <h1 class="card-title">Registrate</h1>
                <div class="card-text">
                     <div class="contenedor">
            <div class="input-contenedor">
                <i class="fas fa-user-circle icon"></i>
                <asp:TextBox ID="txt_nombre" placeholder="Nombre" runat="server"></asp:TextBox>
            </div>

             <div class="input-contenedor">
                <i class="fas fa-user-circle icon"></i>
                <asp:TextBox ID="txt_Apellidos" placeholder="Apellidos" runat="server"></asp:TextBox>
            </div>

             <div class="input-contenedor">
                <i class="fas fa-user-circle icon"></i>
                <asp:TextBox ID="txt_Usuario" placeholder="Nombre de Usuario" runat="server"></asp:TextBox>
            </div>

						 
             <div class="input-contenedor">
             <i class="fas fa-map-marker-alt icon"></i>
                <asp:TextBox ID="Txt_email" placeholder="Example@gmail.com" runat="server"></asp:TextBox>
            </div>
						 			 
        
				 <asp:DropDownList ID="DropDownPais" runat="server"></asp:DropDownList>
				 <asp:DropDownList ID="DropDownEstado" runat="server"></asp:DropDownList>
             <div class="input-contenedor">
             <i class="fas fa-map-marker-alt icon"></i>
                <asp:TextBox ID="txt_Direccion" placeholder="Ingrese su dirección" runat="server"></asp:TextBox>
            </div>


             <div class="input-contenedor">
              <i class="fas fa-lock icon"></i>
                <asp:TextBox ID="txt_password" TextMode="Password" placeholder="Ingrese su contraseña" runat="server"></asp:TextBox>
            </div>

                   <div class="custom-file">
					        
					   <asp:FileUpload CssClass="custom-file-input" ID="Fu_perfil" runat="server" onchange="javascript:cambiar_nombre()"  Visible="true">  </asp:FileUpload>
					  <asp:Label ID="Label5" runat="server" Text="Foto de perfil:" for="customFile"   CssClass="custom-file-label"  data-browse="Examinar"></asp:Label>
						  
				  
          
				  
				</div>




                         <br />
            <asp:Button ID="btn_registrate" Width="100%" runat="server" Text="Registrate" CssClass="btn btn-outline-dark" OnClick="btn_registrate_Click" />
            <p>Al registrarte, aceptas nuestras Condiciones de uso y Política de privacidad.</p>
            <p>¿Ya tienes una cuenta? <a href="login.aspx">Inciar Sesión</a></p>
        </div>
    </div>
               </div>
       
        </div>
        </div>
  
    


</asp:Content>
