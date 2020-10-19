<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Agenda.Site.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <table width="100%">
                <tr>
                    <td>Apellido y Nombre :
            <asp:TextBox runat="server" />
                        País :
            <asp:TextBox runat="server" />
                        Localidad :
            <asp:TextBox runat="server" />
                    </td>

                </tr>
                <tr>
                    <td>Fecha Ingreso Desde :
            <asp:TextBox runat="server" />
                        Fecha Ingreso Hasta :
            <asp:TextBox runat="server" />
                        Contacto interno :
            <asp:TextBox runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>Organización :
            <asp:TextBox runat="server" />
                        Área :
            <asp:TextBox runat="server" />
                        Activo :
            <asp:TextBox runat="server" ID="activo" />



                        <asp:Button ID="BtnFilter" Text="Buscar" class="btn btn-success btn-xs" runat="server" />
                        <asp:Button ID="BtnContact" Text="Nuevo Contacto" class="btn btn-primary btn-xs" runat="server" />


                    </td>
                </tr>
            </table>

            <asp:GridView ID="GridViewConsulta" runat="server" Text="Texto" AutoGenerateColumns="true" RowStyle-HorizontalAlign="Center"
                         HeaderStyle-CssClass ="TextoConsulta" Width="100%" GridLines="Horizontal" OnRowCommand="GridViewConsulta_RowCommand">
                <Columns>
                    <asp:ButtonField ButtonType="Image" ImageUrl="Images/zoom.png" CommandName="Accion1" />
                    <asp:ButtonField ButtonType="Image" ImageUrl="Images/edit.png" CommandName="Accion2" />
                </Columns>
            </asp:GridView>



        </div>
    </form>
</body>
</html>
