<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/administrador2.Master" AutoEventWireup="true" CodeBehind="Aceptarcapitulo.aspx.cs" Inherits="ProyectoWebPageMaster.GUI.Aceptarcapitulo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	<link href="../recursos/Estilos_MISHISTORIAS.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

	    <br /><br />

    

    <div class="container-fluid">

    <div class="row">


        <div class="col-md-2">

        </div>
    <div class="col-md-8">      
        
        <div class="row">
          <div class="col-md-6">            
            <asp:DataPager ID="DataPager1" runat="server" PagedControlID="lstfotos"  PageSize="6" OnPreRender="imagenes" >
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
       </div>
 <!--   <div class="col-md-8">


      <!---  <div class="card">
    <div class="card-header">
    Todas mis Historias
    </div>--->

       <asp:ListView ID="lstfotos" runat="server" GroupItemCount="1" OnSelectedIndexChanged="lstfotos_SelectedIndexChanged1">
              <ItemTemplate>

                <div class="imagecontainer">                                      
                          
                         <div class="caption contenedorlistview"">
                                      <h3 class="card-title"><%# Eval("NOMBRE") %></h3>  
                                     <h3 class="card-title"><%# Eval("NUMERO") %></h3> 
                             <h3 class="card-title"><%# Eval("AUTOR") %></h3> 
							 
                                   
                             <br />
							 <a href="destalles_CAP_GUI.aspx?CODIGO_CAP=<%# Eval("CODIGO_CAP")%>" class="btn btn-warning" role="button"">Ver más</a>
                  
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
