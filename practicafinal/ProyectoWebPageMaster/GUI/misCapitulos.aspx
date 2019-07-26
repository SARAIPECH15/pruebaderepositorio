<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Site1.Master" AutoEventWireup="true" CodeBehind="misCapitulos.aspx.cs" Inherits="ProyectoWebPageMaster.GUI.misCapitulos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../recursos/Estilos_MISHISTORIAS.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   



     <!--================Banner Area =================-->
        <section class="banner_area">
            <div class="container">
                <div class="banner_inner_text">
                    <h2>Mis Capitulos</h2>
                    <p>¡Tus capitulos escritos!</p>
                </div>
            </div>
        </section>
        <!--================End Banner Area =================-->
    <br /><br />


    <div class="container-fluid">

        <div class="row">
            <div class="col-md-1">
                <asp:Image ID="Image1" runat="server" ImageUrl="../recursos/img/cartoonhappy.png" Width="150px" Height="150px"/>
            </div>
            <div class="col-md-2">
                <br /><br />
                <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click"><img src="../recursos/img/plus.png" /> Crear Capítulo</asp:LinkButton>

         <!--      <a href="CrearCapitulo.aspx?id=<%%>"><img src="../recursos/img/plus.png" /> Crear nuevo capitulo</a> -->
               
            </div>
            <div class="col-md-9">

                <div class="row">
                    <asp:DataPager ID="DataPager1" runat="server" OnPreRender="DataPager1_PreRender" PagedControlID="lstcapitulos" PageSize="6">

                      <Fields>
                   <asp:NextPreviousPagerField ButtonType="Button"
                                                ShowFirstPageButton="True" 
                                                ShowNextPageButton="False" 
                                               
                                                ButtonCssClass="btn btn-sm btn-default"/>
                    
                    <asp:NextPreviousPagerField ButtonType="Button"
                                                ShowLastPageButton="True" 
                                                ShowPreviousPageButton="False" 
                                              
                                                ButtonCssClass="btn btn-sm btn-default"/>
             </Fields>
                        </asp:DataPager>
                </div>



                <asp:ListView ID="lstcapitulos" runat="server">
             
                <ItemTemplate>
                    <div class="imagecontainer">
                <div class="card bg-light mb-3 border-primary" style="max-width: 18rem;">
             <div class="card-header"><%# Eval ("NOMBRE") %></div>
             <div class="card-body">
              <h5 class="card-title">Número de capítulo: <%# Eval ("NUMERO") %></h5>
    <p class="card-text"><%# Eval ("FECHA_RZO") %></p>
            <a href="EditarCapitulo.aspx?idcap=<%# Eval("CODIGO_CAP") %>&idhis=<%# Eval ("CODIG_HIS") %>" ><img src="../recursos/img/edit.png"/></a>
                </div>
                </div>
            </div>
        </ItemTemplate>
               </asp:ListView>
         
        </div>

          <!--    <div class="col-md-2"></div> -->
           


    </div>
        </div>

</asp:Content>
