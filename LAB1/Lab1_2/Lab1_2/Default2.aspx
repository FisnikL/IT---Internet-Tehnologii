<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default2.aspx.cs" Inherits="Lab1_2.Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" >
        <table class="auto-style1" style="text-align:center">
            <tr>
                <td><asp:Panel ID="pnlPanela1" runat="server" BackColor="#FFFF99" Font-Names="Courier New" Font-Bold="True">
                    <asp:TextBox ID="txtOperand1" runat="server" EnableViewState="False"></asp:TextBox>
                    <asp:TextBox ID="txtOperand2" runat="server" AutoPostBack="True" OnTextChanged="txtOperand2_TextChanged"></asp:TextBox>
                    <asp:Button ID="btnSoberi" runat="server" Text="Soberi" OnClick="btnSoberi_Click" /><br /><br />
                    <asp:Label ID="result" runat="server" Text="Result:" EnableViewState="False"></asp:Label>
                    <asp:Label ID="lblRezultat" runat="server" Text=" "></asp:Label></asp:Panel>
                </td>
            </tr>
            <tr>
                <td><asp:CheckBox ID="chbVidlivo" runat="server" Text="Видливо" OnCheckedChanged="chbVidlivo_CheckedChanged" Checked="true" AutoPostBack="True"/></td>
            </tr>
        </table>
    </form>
</body>
</html>
