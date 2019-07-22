<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Site1.Master" AutoEventWireup="true" CodeBehind="misHistorias.aspx.cs" Inherits="ProyectoWebPageMaster.GUI.misHistorias" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <!--================Banner Area =================-->
        <section class="banner_area">
            <div class="container">
                <div class="banner_inner_text">
                    <h2>Mis Historias</h2>
                    <p>tus historias escritas!</p>
                </div>
            </div>
        </section>
        <!--================End Banner Area =================-->
    <br /><br />

<<<<<<< HEAD
    
    <div class="container-fluid">
=======
>>>>>>> c4eeede2b5858aff69654a4f293cef640f2d45d4


    <div class="row">


        <div class="col-md-2"></div>
    <div class="col-md-8">


        <div class="card">
    <div class="card-header">
    Todas mis Historias
    </div>
     <div class="card-body text-center">
   

         <asp:ListView ID="lstfotos" runat="server" GroupItemCount="1">

               <ItemTemplate>

                   <div class="card mb-3" style="max-width: 540px;">
          
             
                  <div class="row no-gutters">
                  <div class="col-md-4">
                  <asp:Image ID="Image1" runat="server" Width="190px" Height="240px" CssClass="card-img" ImageUrl='<%#"~/recursos/fotos_portadasLibros/"+Eval("CODIG_HIS") + Eval("FOTO") %>' />
            <!--     <img src="..." class="card-img" alt="...">  -->
                      
                  </div>
                  <div class="col-md-8">
                  <div class="card-body">

                <h5 class="card-title"><%# Eval("NOMBRE") %></h5>  
                  <p class="card-text"><%# Eval("PROLOGO") %></p>
                  <p class="card-text"><small class="text-muted">Last updated 3 mins ago</small></p>
                 </div>
                </div>
               </div>
              </div>
                
    </div>

                   


                </ItemTemplate>





         </asp:ListView>









    </div>
    </div>










    </div>
        <div class="col-md-2"></div>
    </div>
<<<<<<< HEAD
        </div>
 
        </div>
=======



>>>>>>> c4eeede2b5858aff69654a4f293cef640f2d45d4

    <br /><br />

</asp:Content>
