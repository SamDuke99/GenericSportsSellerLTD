<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnOrderLine.aspx.cs" Inherits="AnOrderLine" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblOrderLineNumber" runat="server" style="z-index: 1; left: 21px; top: 79px; position: absolute; height: 19px" Text="Order Line Number"></asp:Label>
        <asp:Label ID="lblOrderNumber" runat="server" style="z-index: 1; left: 22px; top: 119px; position: absolute" Text="Order Number"></asp:Label>
        <asp:Label ID="lblProductID" runat="server" style="z-index: 1; left: 24px; top: 159px; position: absolute" Text="Product ID"></asp:Label>
        <asp:TextBox ID="txtOrderLineNumber" runat="server" style="z-index: 1; left: 183px; top: 79px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtOrderNumber" runat="server" style="z-index: 1; left: 180px; top: 120px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtProductID" runat="server" style="z-index: 1; left: 181px; top: 160px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnOrderLineSubmit" runat="server" OnClick="btnOrderLineSubmit_Click" style="z-index: 1; left: 21px; top: 221px; position: absolute; height: 26px" Text="Submit" />
        <asp:Button ID="btnOrderLineCancel" runat="server" OnClick="btnOrderLineCancel_Click" style="z-index: 1; left: 103px; top: 222px; position: absolute" Text="Cancel" />
        <asp:Button ID="btnOrderLineFind" runat="server" OnClick="btnOrderLineFind_Click" style="z-index: 1; left: 342px; top: 80px; position: absolute" Text="Find" />
        <asp:Label ID="lblOrderLineError" runat="server" BorderStyle="None" style="z-index: 1; left: 204px; top: 224px; position: absolute"></asp:Label>
    </form>
</body>
</html>
