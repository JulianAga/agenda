<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IngresarArticulo.aspx.cs" Inherits="Agenda.Site.IngresarArticulo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            
            <table>
                <tr>
                    <td>Apellido y Nombre :
            <asp:TextBox runat="server" ID="ApellidoYNombre" />
                        Género :
            <asp:TextBox runat="server" ID="Genero"/>
                        País :
            <asp:TextBox runat="server" ID="Pais" />
                    </td>
                    </tr>

                    <tr>
                        <td>Localidad :
            <asp:TextBox runat="server" ID="Localidad" />
                            Contacto Interno :
            <asp:TextBox runat="server" ID="CI" />
                            Organización :
            <asp:TextBox runat="server" ID="Org"/>
                        </td>
                    </tr>
                <tr>
                    <td>Área :
            <asp:TextBox runat="server" ID="Area"/>
                        Activo :
            <asp:TextBox runat="server" ID="activo"/>
                        Dirección :
            <asp:TextBox runat="server" ID="direccion"/>
                        </td>
                    </tr>
                <tr>
                    <td>
                        Teléfono Fijo
                          <asp:TextBox runat="server" ID="tel" />
                        Celular
            <asp:TextBox runat="server" ID="cel" />
                       E-mail :
            <asp:TextBox runat="server" ID="email" />

                        Skype
               <asp:TextBox runat="server" ID="skype"/>

                        <asp:Button ID="BtnFilter" OnClick="btnGuardar" Text="guardar" class="btn btn-success btn-xs" runat="server" />
                        <asp:Button ID="BtnSalir" OnClick="btnSalir"  Text="salir" class="btn btn-primary btn-xs" runat="server" />


                    </td>
                </tr>
           </table>
        </div>
    </form>
</body>
</html>
