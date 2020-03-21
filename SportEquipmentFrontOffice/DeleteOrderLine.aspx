<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteOrderLine.aspx.cs" Inherits="DeleteOrderLine" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 253px">
    <form id="form1" runat="server">
        <p>
            Are you sure you want to delete this record?</p>
        <div>
        </div>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 10px; top: 72px; position: absolute" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 83px; top: 73px; position: absolute" Text="No" />
    </form>
</body>
</html>
