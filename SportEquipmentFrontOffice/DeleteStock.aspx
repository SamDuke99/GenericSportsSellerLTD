<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteStock.aspx.cs" Inherits="DeleteStock" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Are you sure you want to delete this record?"></asp:Label>
            <br />
        </div>
        <asp:Button ID="BtnNo" runat="server" style="z-index: 1; 
             left: 90px; 
             top: 50px; 
             position: absolute; height: 26px;" Text="No" OnClick="BtnNo_Click" />
        <asp:Button ID="BtnYes" runat="server" style="z-index: 1; 
             left: 50px; 
             top: 50px; 
             position: absolute; height: 26px;" Text="Yes" OnClick="BtnYes_Click" />
    </form>
</body>
</html>
