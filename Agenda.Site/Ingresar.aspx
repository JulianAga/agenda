<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ingresar.aspx.cs" Inherits="Agenda.Site.Ingresar" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Login.css" rel="stylesheet" type="text/css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="FormaLogin">
        <div class="LeftFormaLogin">
        </div>
        <div class="CenterFormaLogin">
            <div class="cPosRel" style="width: 370px; height: 90px; margin: 34px auto 0px auto; text-align:justify;">
                <span class="TextoBienvenido">Bienvenido al sistema de EDSA</span>
                <br />
             
      <asp:Login ID="IDControlLogin" runat="server" OnAuthenticate="AutenticarLogin" LoginButtonText="Ingresar" PasswordLabelText="Contraseña:" 
                RememberMeText="Recordarme la proxima vez." TitleText="Log In Test" UserNameLabelText="Usuario:" >
            </asp:Login>

         
                    </div>
             
            <asp:Label ID="lblMensaje" CssClass="cFL" runat="server" ForeColor="#996600"></asp:Label>
        </div>
        <div class="RightFormaLogin">
        </div>
    </div>
    </form>
</body>
</html>
