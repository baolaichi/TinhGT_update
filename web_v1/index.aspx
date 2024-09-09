<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="web_v1.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>TÍNH GIAI THỪA</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1 style="color:darkgoldenrod">Chương Trình Tính Giai Thừa</h1>
        <h4>Hãy nhập một số để tính giai thừa</h4>
        
        <asp:Label ID="Label1" runat="server" Height="20" Width="200" Text="Nhập số:"></asp:Label>
        <asp:TextBox ID="txt_number" runat="server" Height="28" Width="100"></asp:TextBox>
        <asp:Button ID="btn_calculate" Height="33px" Width="118px" runat="server" Text="Tính giai thừa" OnClick="btn_calculate_Click" />

        <br /><br />
        <asp:Label ID="lbl_result" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>

