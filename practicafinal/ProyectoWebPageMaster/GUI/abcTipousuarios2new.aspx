<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/administrador.Master" AutoEventWireup="true" CodeBehind="abcTipousuarios2new.aspx.cs" Inherits="ProyectoWebPageMaster.GUI.abcTipousuarios2new" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">  

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br /><br />
    <div class="row text-center">
        <div class="col-md-7">
            <div class="card text-white bg-info mb-3" style="max-width: 18rem;">
                <div class="card-header">Tipo de Usuarios</div>
                <div class="card-body">
                    <h5 class="card-title">Rellene los campos correctamente:</h5>
                    <asp:Label ID="Label1" runat="server" Text="Ingrese tipo de Usuario:"></asp:Label><br />
                    <asp:TextBox ID="txttipo" runat="server" CssClass="btn btn-danger"></asp:TextBox>
                    <br /><br />
                    <asp:Button ID="Button1" runat="server" Text="Agregar" CssClass="btn btn-danger" />&nbsp
                    <asp:Button ID="Button2" runat="server" Text="Modificar" />&nbsp
                    <asp:Button ID="Button3" runat="server" Text="Eliminar" />
                </div>
            </div>
        </div>
        </div>

</asp:Content>
