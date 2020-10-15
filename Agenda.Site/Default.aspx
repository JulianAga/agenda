<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Agenda.Site._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

  
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
    <html xmlns="http://www.w3.org/1999/xhtml">
    <head>
        <link href="Login.css" rel="stylesheet" type="text/css" />
        <title></title>
    </head>
    <body>
        <div class="content">

         <form id="form1" method="post" action="/">

            <table width="100%" id="asd" runat="server">
                  
                <tr>
                    <td>Apellido y Nombre :
            <input type="" name="name" value="" />
                        País :
            <input type="" name="name" value="" />
                        Localidad :
            <input type="" name="name" value="" />
                        Fecha Ingreso Desde :
            <input type="" name="name" value="" />
                        Fecha Ingreso Hasta :
            <input type="" name="name" value="" />
                        Contacto interno :
            <input type="" name="name" value="" />
                        Organización :
            <input type="" name="name" value="" />
                        Área :
            <input type="" name="name" value="" />
                        Activo :
            <input type="" name="name" value="" />

                        <input type="submit" name="name" value="enviar" />

                        <asp:Button ID="BtnFilter" OnClick="BtnFilter_Click" Text="Buscar" class="btn btn-success btn-xs" runat="server" />
                        <asp:Button Text="Nuevo Contacto" class="btn btn-primary btn-xs" runat="server" />
                    </td>
                </tr>
            </table>
          </form>
          </div>
        <br />
        <div class="content">
        
            <asp:Table ID="myTable" runat="server" BorderWidth="1px" Width="100%">
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
        <footer>
            <asp:GridView runat="server" CssClass="table">

                <Columns>

                    <asp:TemplateField HeaderText="Agenda">

                        <ItemTemplate>
                            <asp:Label ID="Label1" Text="Nombre" runat="server" />
                        </ItemTemplate>
                        <EditItemTemplate>
                        </EditItemTemplate>

                    </asp:TemplateField>

                </Columns>

            </asp:GridView>
            </footer>
    </body>

</html>
</asp:Content>

