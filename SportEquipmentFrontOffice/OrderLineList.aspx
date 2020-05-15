<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderLineList.aspx.cs" Inherits="OrderLineList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstOrderLineList" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute; height: 267px; width: 478px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 25px; top: 340px; position: absolute" Text="Add" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 81px; top: 342px; position: absolute" Text="Delete" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 164px; top: 343px; position: absolute" Text="Edit" />
        <asp:Label ID="lblEnterOrderNumber" runat="server" style="z-index: 1; left: 23px; top: 379px; position: absolute" Text="Enter A Order Line Number"></asp:Label>
        <asp:TextBox ID="txtOrderLineNumber" runat="server" style="z-index: 1; left: 239px; top: 384px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 21px; top: 419px; position: absolute; right: 1497px" Text="Apply" />
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="z-index: 1; left: 101px; top: 420px; position: absolute" Text="Clear" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 24px; top: 465px; position: absolute"></asp:Label>
    </form>
</body>
</html>
