<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Najava.aspx.cs" Inherits="Lab2_Zad3.Najava" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 200px;
        }
        .auto-style2 {
            width: 400px;
        }
        .auto-style3 {
            width: 55%;
            height: 97px;
        }
        .auto-style4{
            margin-bottom:5px;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <table class="auto-style3">
                <tr class="auto-style4">
                    <td class="auto-style1">Корисник:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtKorisnik" runat="server" Width="196px"></asp:TextBox>
                    </td>
                </tr>
                <tr class="auto-style4">
                    <td class="auto-style1">Лозинка:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtLozinka" runat="server" Width="196px"></asp:TextBox>
                    </td>
                </tr>
                <tr class="auto-style4">
                    <td class="auto-style1" colspan="2">
                        <asp:Button ID="btnPodnesi" runat="server" Text="Поднеси" Width="140px" OnClick="btnPodnesi_Click" />
                    </td>
                </tr>
                <tr class="auto-style4">
                    <td class="auto-style1" colspan="2">
                        <asp:Label ID="lblObidi" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
