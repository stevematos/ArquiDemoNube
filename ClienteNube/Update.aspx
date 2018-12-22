<%@ Page Title="Modificar Libro" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Update.aspx.cs" Inherits="ClienteNube.Update" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <div>
        <asp:Label ID="Label1" runat="server" Text="Seleccionar"></asp:Label>
        <asp:DropDownList ID="ComboBoxLibros" runat="server" Height="38px" Width="191px">
            <asp:ListItem></asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Seleccionar" OnClick="Button1_Click" />
        <br />
        <br />
        <asp:Table ID="TableEjemplares" runat="server" Width="558px" Height="26px">
        <asp:TableRow>
            <asp:TableCell>EjemplarID</asp:TableCell>
            <asp:TableCell>Editora</asp:TableCell>
            <asp:TableCell>Titulo</asp:TableCell>
            <asp:TableCell>Fecha de Publicacion</asp:TableCell>
            <asp:TableCell>Costo</asp:TableCell>
            <asp:TableCell>Precio de venta</asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    </div>
    <br />
    <asp:Button CssClass="boton_crear" ID="Button2" runat="server" Text="Confirmar" OnClick="Button2_Click" />
    <br />
    <asp:Table ID="EjemplarUpdate" runat="server" Width="565px">
        <asp:TableRow>
            <asp:TableCell><asp:Label ID="EjemplarID" runat="server" Text="EjemplarId"></asp:Label></asp:TableCell>
            <asp:TableCell><asp:TextBox ID="TextEjemplarId" runat="server" Enabled="False" ></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell><asp:Label ID="Label2" runat="server" Text="Editora"></asp:Label></asp:TableCell>
            <asp:TableCell><asp:DropDownList ID="ComboBoxEditoraId" runat="server" ></asp:DropDownList></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell><asp:Label ID="Label3" runat="server" Text="Titulo"></asp:Label></asp:TableCell>
            <asp:TableCell><asp:TextBox ID="TextTitulo" runat="server" ></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell><asp:Label ID="Label4" runat="server" Text="Fecha de Publicacion"></asp:Label></asp:TableCell>
            <asp:TableCell><asp:TextBox ID="TextFechaPublicacion" runat="server" ></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell><asp:Label ID="Label5" runat="server" Text="Costo"></asp:Label></asp:TableCell>
            <asp:TableCell><asp:TextBox ID="TextCosto" runat="server" ></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell><asp:Label ID="Label6" runat="server" Text="Precio de venta"></asp:Label></asp:TableCell>
            <asp:TableCell>    <asp:TextBox ID="TextPrecioVenta" runat="server" ></asp:TextBox></asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    <br />
    <asp:Button CssClass="boton_crear" ID="Button4" runat="server" Text="Modificar" Height="26px" OnClick="Button4_Click" />
    

    

</asp:Content>
