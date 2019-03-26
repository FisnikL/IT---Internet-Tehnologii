<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default3.aspx.cs" Inherits="Lab1_2.Default3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>

<body>
    <form id="form1" runat="server">
        <table style="width: 100%; text-align:center">
            <tr>
                <td>
                    Лозинка:</td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="txtLozinka" runat="server" TextMode="Password"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    Порака:</td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="txtPoraka" runat="server" ReadOnly="True" Rows="5" TextMode="MultiLine" OnTextChanged="txtPoraka_TextChanged" AutoPostBack="True"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnProveri" runat="server" Text="ПРОВЕРИ" onClick="btnProveri_Click"/></td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnPrvaStrana" runat="server" Text="ПРВА СТРАНА" Enabled="False"/></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lbl" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
