<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Greeting.aspx.cs" Inherits="HelloName.Greeting" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <span>Enter your name:</span>
        <asp:TextBox ID="namePerson" runat="server"></asp:TextBox>
        <asp:Button ID="submitBtn" runat="server" Text="Submit" OnClick="submitBtn_Click" />
    </div>
        <p>
        <asp:Label ID="greetingLbl" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
