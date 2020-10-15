<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Agenda.Site._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <html xmlns="http://www.w3.org/1999/xhtml">


    <body>

        <link href="Login.css" rel="stylesheet" type="text/css" />

        <form action="/" method="post">

            <div class="container">
                Apellido y Nombre :
            <input type="text" name="name" value="" />
                País :
            <input type="text" name="name" value="" />
                Localidad :
            <input type="text" name="name" value="" />


                Fecha Ingreso Desde :
            <input type="text" name="name" value="" />
                Fecha Ingreso Hasta :
            <input type="text" name="name" value="" />
                Contacto interno :
            <input type="text" name="name" value="" />
                Organización :
            <input type="text" name="name" value="" />
                Área :
            <input type="text" name="name" value="" />
                Activo :
            <input type="text" name="name" value="" />


                <br />

                <asp:Button ID="BtnFilter" OnClick="BtnFilter_Click" Text="Buscar" class="btn btn-success btn-xs" runat="server" />
                <asp:Button Text="Nuevo Contacto" class="btn btn-primary btn-xs" runat="server" />

            </div>
        </form>

        <br />



        <asp:Table ID="myTable" runat="server" Width="100%">
            <asp:TableRow>

                <asp:TableCell> Apellido y Nombre </asp:TableCell>
                <asp:TableCell> Genero </asp:TableCell>
                <asp:TableCell> País </asp:TableCell>
                <asp:TableCell> Localidad </asp:TableCell>
                <asp:TableCell> Contacto Interno </asp:TableCell>
                <asp:TableCell> Organización </asp:TableCell>
                <asp:TableCell> Área </asp:TableCell>
                <asp:TableCell> Fecha Ingreso </asp:TableCell>
                <asp:TableCell> Activo </asp:TableCell>
                <asp:TableCell> Dirección </asp:TableCell>
                <asp:TableCell> Telefono Interno </asp:TableCell>
                <asp:TableCell> Telefono Celular </asp:TableCell>
                <asp:TableCell> Email </asp:TableCell>
                <asp:TableCell> Cuenta de Skype </asp:TableCell>
                <asp:TableCell> Acciones </asp:TableCell>


            </asp:TableRow>

        </asp:Table>


    </body>

</html>
</asp:Content>

