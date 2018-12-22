<%@ Page Title="Crear Libro" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Crear.aspx.cs" Inherits="ClienteNube.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Ingresar un nuevo libro</h3>
    <h5>
        Se ingresara un nuevo libro a la libreria.
    </h5>
    <asp:Table ID="TableEjemplares" runat="server" Width="565px">
        <asp:TableRow>
            <asp:TableCell><asp:Label ID="EjemplarID" runat="server" Text="EjemplarId"></asp:Label></asp:TableCell>
            <asp:TableCell><asp:TextBox ID="TextEjemplarId" runat="server" ></asp:TextBox></asp:TableCell>
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
        <asp:Button  CssClass="boton_crear" ID="Button1" runat="server" OnClick="Button1_Click" Text="Crear" Width="89px" />
    
    <br />
    
    <br />
    <br />

</asp:Content>
