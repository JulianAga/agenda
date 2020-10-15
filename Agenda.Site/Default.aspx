<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Agenda.Site._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

        <link href="Login.css" rel="stylesheet" type="text/css" />

    <asp:Table ID="Tableasd" runat="server" Width="100%">

        <asp:TableRow>
            
             <asp:TableCell> Apellido y Nombre :
            <input type="text" name="name" value="" /></asp:TableCell>
             <asp:TableCell>País :
            <input type="text" name="name" value="" /></asp:TableCell>
            <asp:TableCell>Localidad :
            <input type="text" name="name" value="" /></asp:TableCell>

        </asp:TableRow>
        <asp:TableRow>

            <asp:TableCell>Fecha Ingreso Desde :
            <input type="text" name="name" value="" /></asp:TableCell>
             <asp:TableCell>Fecha Ingreso Hasta :
            <input type="text" name="name" value="" /></asp:TableCell>
            <asp:TableCell>Contacto interno :
            <input type="text" name="name" value="" /></asp:TableCell>

        </asp:TableRow>


        <asp:TableRow>
            <asp:TableCell>Organización :
            <input type="text" name="name" value="" /></asp:TableCell>
           <asp:TableCell>Área :
            <input type="text" name="name" value="" /></asp:TableCell>

           <asp:TableCell>Activo :
            <input type="text" name="name" value="" /></asp:TableCell>
        </asp:TableRow>
    </asp:Table>


    <br />
    <div class="container">
        <div align="right">
        <asp:Button Text="Buscar" class="btn btn-success btn-xs" runat="server" />
        <asp:Button Text="Nuevo Contacto" class="btn btn-primary btn-xs" runat="server" />
        </div>

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


    </div>

</asp:Content>
