<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="OrderList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstOrderList" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute; height: 291px; width: 510px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 24px; top: 364px; position: absolute" Text="Add" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 103px; top: 363px; position: absolute" Text="Delete" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 25px; top: 519px; position: absolute"></asp:Label>
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 204px; top: 364px; position: absolute" Text="Edit" />
        <asp:Label ID="lblODEnter" runat="server" style="z-index: 1; left: 25px; top: 419px; position: absolute" Text="Enter a Order Description"></asp:Label>
        <asp:TextBox ID="txtOrderDescription" runat="server" style="z-index: 1; left: 205px; top: 419px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 23px; top: 460px; position: absolute" Text="Apply" />
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="z-index: 1; left: 96px; top: 460px; position: absolute" Text="Clear" />
    </form>
</body>
</html>
