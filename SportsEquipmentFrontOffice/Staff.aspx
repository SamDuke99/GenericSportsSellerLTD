<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Staff.aspx.cs" Inherits="AddStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Staff ID"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtStaffId" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
&nbsp;
        <asp:Label ID="lblError" runat="server" BorderColor="Red" ForeColor="Red"></asp:Label>
        <br />
        <br />
        Full Name&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtFullname" runat="server"></asp:TextBox>
        <br />
        <br />
        Position&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtPosition" runat="server"></asp:TextBox>
        <br />
        <br />
        Department&nbsp;&nbsp;
        <asp:TextBox ID="txtDepartment" runat="server"></asp:TextBox>
        <br />
        <br />
        Password&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
        <br />
        <br />
        Hire Date&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtHireDate" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:CheckBox ID="chkActive" runat="server" Text="Active" />
        <br />
        <br />
        <br />
        <asp:Button ID="BtnOK" runat="server" Text="OK" Height="26px" OnClick="btnOK_click" Width="65px" />
&nbsp;
        <asp:Button ID="BtnCancel" runat="server" Text="Cancel" Height="27px" Width="65px" />
    </form>
</body>
</html>
