<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DynamicLoadWebUserControl.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" 
        onselectedindexchanged="DropDownList1_SelectedIndexChanged">
        <asp:ListItem>control 1</asp:ListItem>
        <asp:ListItem>control 2</asp:ListItem>
    </asp:DropDownList>
    <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="true" 
        onselectedindexchanged="DropDownList2_SelectedIndexChanged">
        <asp:ListItem>control 3</asp:ListItem>
        <asp:ListItem>control 4</asp:ListItem>
    </asp:DropDownList>
    <asp:Panel ID="Panel1" runat="server">
    </asp:Panel>
    <asp:Button ID="Button1" runat="server" Text="Button" />
    </form>
</body>
</html>
