<%@ Page Title="Inicio" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="ClienteNube.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Libros Disponibles</h3>
    <p>Se encontrara los libros disponibles de la libreria GRUPO 4.</p>
<p>.<asp:Table ID="TableEjemplares" runat="server" Width="565px">
        <asp:TableRow>
            <asp:TableCell>EjemplarID</asp:TableCell>
            <asp:TableCell>Editora</asp:TableCell>
            <asp:TableCell>Titulo</asp:TableCell>
            <asp:TableCell>Fecha de Publicacion</asp:TableCell>
            <asp:TableCell>Costo</asp:TableCell>
            <asp:TableCell>Precio de venta</asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</p>
</asp:Content>
