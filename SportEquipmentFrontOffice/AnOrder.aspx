<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnOrder.aspx.cs" Inherits="AnOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Submit1 {
            z-index: 1;
            left: 30px;
            top: 425px;
            position: absolute;
        }
    </style>
</head>
<body>
   <form id="form1" runat="server">
        
        <p>
            <asp:Label ID="lblOrderNumber" runat="server" style="z-index: 1; left: 21px; top: 118px; position: absolute; height: 34px" Text="Order Number"></asp:Label>
        </p>
        <asp:Label ID="lblOrderDatePlaced" runat="server" style="z-index: 1; left: 21px; top: 199px; position: absolute" Text="Order Date Placed"></asp:Label>
        <asp:Label ID="lblOrderDescription" runat="server" style="z-index: 1; left: 22px; top: 159px; position: absolute" Text="Order Description"></asp:Label>
        <asp:Label ID="lblOrderPrice" runat="server" style="z-index: 1; left: 21px; top: 278px; position: absolute" Text="Order Price"></asp:Label>
        
        <asp:TextBox ID="txtOrderDescription" runat="server" style="z-index: 1; left: 181px; top: 160px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtOrderDatePlaced" runat="server" style="z-index: 1; left: 182px; top: 201px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtOrderPrice" runat="server" style="z-index: 1; left: 177px; top: 277px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtOrderNumber" runat="server" style="z-index: 1; left: 181px; top: 116px; position: absolute"></asp:TextBox>
        
        <asp:Label ID="lblOrderCustomerID" runat="server" style="z-index: 1; left: 20px; top: 320px; position: absolute" Text="Customr ID"></asp:Label>
        <asp:TextBox ID="txtOrderCustomerID" runat="server" style="z-index: 1; left: 175px; top: 315px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblOrderStaffID" runat="server" style="z-index: 1; left: 20px; top: 360px; position: absolute" Text="Staff ID"></asp:Label>
        <asp:TextBox ID="txtOrderStaffID" runat="server" style="z-index: 1; left: 175px; top: 355px; position: absolute"></asp:TextBox>
     
       <asp:Button ID="btnOrderCancel" runat="server" style="z-index: 1; left: 110px; top: 425px; position: absolute" Text="Cancel" OnClick="btnOrderCancel_Click" />
       <asp:Button ID="btnOrderSubmit" runat="server" style="z-index: 1; left: 19px; top: 424px; position: absolute" Text="Submit" OnClick="btnOrderSubmit_Click" />
         
        <asp:CheckBox ID="checkOrderCompleted" runat="server" style="z-index: 1; left: 179px; top: 237px; position: absolute; right: 435px;" />
         
        <asp:Label ID="lblOrderCompleted" runat="server" style="z-index: 1; left: 23px; top: 241px; position: absolute" Text="Order Completed"></asp:Label>
         
        <asp:Button ID="btnOrderNumberFind" runat="server" style="z-index: 1; left: 327px; top: 115px; position: absolute" Text="Find" OnClick="btnOrderNumberFind_Click" />
         
    </form>
  
  
    
</body>
</html>

