<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Agenda.Site._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    <!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

    

            <table>
                <tr>
                    <td>Apellido y Nombre :
            <asp:TextBox runat="server" />
                        País :
            <asp:TextBox runat="server" />
                        Localidad :
            <asp:TextBox runat="server" />
                    </td>

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

              

                        <asp:Button ID="BtnFilter" OnClick="BtnFilter_Click" Text="Buscar" class="btn btn-success btn-xs" runat="server" />
                        <asp:Button Text="Nuevo Contacto" class="btn btn-primary btn-xs" runat="server" />


                    </td>
                </tr>
           </table>
       


    <br >
            <asp:GridView runat="server" CssClass="table" Height="285px" Width="430px">

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
      

    <br>
       <p>
            

                 
        
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

                   

       </p>
    



</asp:Content>

