<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Lab1_2.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div><asp:Label ID="lblVreme1" runat="server" Font-Names="Arial" ForeColor="Navy" Text="Kонтрола за приказ на време" Font-Size="Medium"></asp:Label></div>
        <br />
        <div><asp:Label ID="lblVreme2" runat="server" Font-Names="Arial" ForeColor="Navy" Text="Kонтрола за приказ на време при клик на Button" Font-Size="Medium"></asp:Label></div>
        <br />
        <div>
            <asp:Button ID="btnVreme1" runat="server" Height="26px" Text="Button" Font-Names="Arial" Font-Size="Medium" ForeColor="Navy" OnClick="btnVreme1_Click"/>
            <br />
            <br />
            <asp:HyperLink ID="hlSledno" runat="server" NavigateUrl="~/Default2.aspx">Next Page</asp:HyperLink>
        </div>

    </form>
</body>
</html>
