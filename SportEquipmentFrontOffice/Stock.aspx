<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Stock.aspx.cs" Inherits="Stock" %>

<!DOCTYPE html>
<script runat="server">
</script>


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
        <asp:Label ID="lblProductId" runat="server" style="z-index: 1; 
                  left: 21px; 
                  top: 118px; 
                  position: absolute; 
                  height: 20px" Text="Product ID">
        </asp:Label>
        </p>
        <asp:Label ID="lblProductDetails" runat="server" style="z-index: 1; 
                  left: 21px; 
                  top: 145px; 
                  position: absolute; 
                  height: 20px" Text="Product Details">
        </asp:Label>
        <asp:Label ID="lblPrice" runat="server" style="z-index: 1; 
                  left: 21px; 
                  top: 170px; 
                  position: absolute; 
                  height: 20px" Text="Price">
        </asp:Label>
        <asp:Label ID="lblDateAcquired" runat="server" style="z-index: 1; 
                  left: 21px; 
                  top: 195px; 
                  position: absolute; 
                  height: 20px" Text="Date Acquired">
        </asp:Label>
        <asp:Label ID="lblInStock" runat="server" style="z-index: 1; 
                  left: 21px; 
                  top: 220px; 
                  position: absolute; 
                  height: 20px" Text="In Stock">
        </asp:Label>


        <asp:TextBox ID="txtProductId" runat="server" style="z-index: 1; 
             left: 160px; 
             top: 120px; 
             position: absolute">
        </asp:TextBox>
        <asp:TextBox ID="txtProductDetails" runat="server" style="z-index: 1; 
             left: 160px; 
             top: 145px; 
             position: absolute">
        </asp:TextBox>
        <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; 
             left: 160px; 
             top: 170px; 
             position: absolute">
        </asp:TextBox>
        <asp:TextBox ID="txtDateAcquired" runat="server" style="z-index: 1; 
             left: 160px; 
             top: 195px; 
             position: absolute">
        </asp:TextBox>
        <asp:TextBox ID="txtInStock" runat="server" style="z-index: 1; 
             left: 160px; 
             top: 220px; 
             position: absolute">
        </asp:TextBox>
        
        <asp:Button ID="BtnCancel" runat="server" style="z-index: 1; 
             left: 160px; 
             top: 250px; 
             position: absolute; height: 26px;" Text="Cancel" OnClick="BtnCancel_Click" />
        <asp:Button ID="BtnSubmit" runat="server" style="z-index: 1; 
             left: 100px; 
             top: 250px; 
             position: absolute; height: 26px;" Text="Submit" OnClick="BtnSubmit_Click" />

        <asp:Label ID="lblError" runat="server" style="z-index: 1; 
            left: 20px; 
            top: 300px; 
            position: absolute">
        </asp:Label>
    </form>
</body>
</html>
