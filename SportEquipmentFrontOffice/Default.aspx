<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            </div>
        <p>
            <asp:Label ID="lblOrderNumber" runat="server" style="z-index: 1; left: 21px; top: 118px; position: absolute; height: 34px" Text="Order Number"></asp:Label>
        </p>
        <asp:Button ID="btnOk" runat="server" style="z-index: 1; left: 23px; top: 341px; position: absolute; width: 54px; height: 22px" Text="OK" />
        <asp:Label ID="lblOrderDatePlaced" runat="server" style="z-index: 1; left: 21px; top: 199px; position: absolute" Text="Order Date Placed"></asp:Label>
        <asp:Label ID="lblOrderDescription" runat="server" style="z-index: 1; left: 22px; top: 159px; position: absolute" Text="Order Description"></asp:Label>
        <asp:Label ID="lblOrderCompleted" runat="server" style="z-index: 1; left: 21px; top: 237px; position: absolute" Text="Order Completed"></asp:Label>
        <asp:Label ID="lblOrderPrice" runat="server" style="z-index: 1; left: 21px; top: 278px; position: absolute" Text="Order Price"></asp:Label>
        <asp:Button ID="btnOrderCancel" runat="server" style="z-index: 1; left: 102px; top: 338px; position: absolute" Text="Cancel" />
        <asp:TextBox ID="txtOrderDescription" runat="server" style="z-index: 1; left: 181px; top: 160px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtOrderDatePlaced" runat="server" style="z-index: 1; left: 182px; top: 201px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtOrderPrice" runat="server" style="z-index: 1; left: 177px; top: 277px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtOrderNumber" runat="server" style="z-index: 1; left: 181px; top: 116px; position: absolute"></asp:TextBox>
        <p>
            &nbsp;</p>
        <asp:TextBox ID="txtOrderCompleted" runat="server" style="z-index: 1; left: 179px; top: 236px; position: absolute; margin-top: 0px"></asp:TextBox>
    </form>
</body>
</html>
