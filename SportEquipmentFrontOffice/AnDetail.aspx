<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnDetail.aspx.cs" Inherits="AnDetail" %>

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
        <asp:Label ID="lblProductID" runat="server" style="z-index: 1; 
                  left: 21px; 
                  top: 118px; 
                  position: absolute; 
                  height: 20px" Text="Product ID">
        </asp:Label>
        </p>
        <asp:Label ID="lblGender" runat="server" style="z-index: 1; 
                  left: 21px; 
                  top: 145px; 
                  position: absolute; 
                  height: 20px" Text="Gender">
        </asp:Label>
        <asp:Label ID="lblSize" runat="server" style="z-index: 1; 
                  left: 21px; 
                  top: 170px; 
                  position: absolute; 
                  height: 20px" Text="Size">
        </asp:Label>
        <asp:Label ID="lblColour" runat="server" style="z-index: 1; 
                  left: 21px; 
                  top: 195px; 
                  position: absolute; 
                  height: 20px" Text="Colour">
        </asp:Label>
        <asp:Label ID="lblBrand" runat="server" style="z-index: 1; 
                  left: 21px; 
                  top: 220px; 
                  position: absolute; 
                  height: 20px" Text="Brand">
        </asp:Label>


        <asp:TextBox ID="txtProductID" runat="server" style="z-index: 1; 
             left: 160px; 
             top: 120px; 
             position: absolute">
        </asp:TextBox>
        <asp:TextBox ID="txtGender" runat="server" style="z-index: 1; 
             left: 160px; 
             top: 145px; 
             position: absolute">
        </asp:TextBox>
        <asp:TextBox ID="txtSize" runat="server" style="z-index: 1; 
             left: 160px; 
             top: 170px; 
             position: absolute">
        </asp:TextBox>
        <asp:TextBox ID="txtColour" runat="server" style="z-index: 1; 
             left: 160px; 
             top: 195px; 
             position: absolute">
        </asp:TextBox>
        <asp:TextBox ID="txtBrand" runat="server" style="z-index: 1; 
             left: 160px; 
             top: 220px; 
             position: absolute">
        </asp:TextBox>
        

        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; 
            left: 160px; 
            top: 250px; 
            position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
       <asp:Button ID="btnUpdateSubmit" runat="server" style="z-index: 1; 
            left: 90px; 
            top: 250px; 
            position: absolute" Text="Submit" OnClick="btnUpdateSubmit_Click" />
        
        <asp:Label ID="lblError" runat="server" style="z-index: 1; 
            left: 20px; 
            top: 300px; 
            position: absolute">
        </asp:Label>
    </form>
</body>
</html>
