<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Site1.Master" AutoEventWireup="true" CodeBehind="misHistorias.aspx.cs" Inherits="ProyectoWebPageMaster.GUI.misHistorias" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../recursos/estilos_mishistorias.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <!--================Banner Area =================-->
        <section class="banner_area">
            <div class="container">
                <div class="banner_inner_text">
                    <h2>Mis Historias</h2>
                    <p>¡Tus historias escritas!</p>
                </div>
            </div>
        </section>
        <!--================End Banner Area =================-->
    <br /><br />

    
    <div class="container-fluid">


    <div class="row">


        <div class="col-md-2">

        </div>
    <div class="col-md-8">      
        
        <div class="row">
           <div class="col-md-6">            
             <asp:DataPager ID="DataPager1" runat="server" PagedControlID="lstfotos" PageSize="3">
             <Fields>
                   <asp:NextPreviousPagerField ButtonType="Button"
                                                ShowFirstPageButton="True" 
                                                ShowNextPageButton="False" 
                                                PreviousPageText="&#9668;" 
                                                FirstPageText="&#9668;&#9668;"
                                                ButtonCssClass="btn btn-sm btn-default"/>
                    
                    <asp:NextPreviousPagerField ButtonType="Button"
                                                ShowLastPageButton="True" 
                                                ShowPreviousPageButton="False" 
                                                NextPageText="&#9658;" 
                                                LastPageText="&#9658;&#9658;"
                                                ButtonCssClass="btn btn-sm btn-default"/>
             </Fields>
         </asp:DataPager>
           </div>
       </div>
 <!--   <div class="col-md-8">--->


      <!---  <div class="card">
    <div class="card-header">
    Todas mis Historias
    </div>--->

         <asp:ListView ID="lstfotos" runat="server" GroupItemCount="1">
              <ItemTemplate>

                <div class="imagecontainer">                                      
                            <asp:Image ID="Image1" runat="server" Width="250px" Height="150px" CssClass="card-img" ImageUrl='<%#"~/recursos/fotos_portadasLibros/"+Eval("CODIG_HIS") + Eval("FOTO") %>' />        
                         <div class="caption contenedorlistview"">
                                      <h3 class="card-title"><%# Eval("NOMBRE") %></h3>  
                                    
                             <br />
                                      <p class="card-text"><%# Eval("PROLOGO") %></p>
                             <br />
                             <a href="#">Continuar escribiendo</a>
                             </div>
                    </div>
                  </ItemTemplate>
             </asp:ListView>
              
                    
        
        <div class="col-md-2"></div>
    </div>
        </div>
 
        </div>

    <br /><br />

</asp:Content>
