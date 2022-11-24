<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="waAgenda.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="width: 481px">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lEmailLogin" runat="server" Font-Bold="True" Font-Size="20px" Text="E-mail"></asp:Label>
            <br />
            <asp:TextBox ID="txbEmail" runat="server" Font-Size="16pt" Height="20px" Width="400px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lSenhaLogin" runat="server" Font-Bold="True" Font-Size="20px" Text="Senha"></asp:Label>
            <br />
            <asp:TextBox ID="txbSenha" runat="server" Font-Size="16px" Height="20px" TextMode="Password" ToolTip="Digite sua senha" Width="270px"></asp:TextBox>
&nbsp;
            <asp:Button ID="btLogar" runat="server" Font-Bold="True" Font-Size="18px" Height="26px" OnClick="btLogar_Click" Text="Logar" Width="120px" />
            <br />
            <br />
    <asp:Label ID="lMsg" runat="server" Font-Bold="True" Font-Size="X-Large"></asp:Label>
        </div>
    </form>
</body>
</html>
