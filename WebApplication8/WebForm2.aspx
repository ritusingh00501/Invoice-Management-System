<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication8.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Invoice Page</title>
    <style type="text/css">
        .auto-style1 {
            height: 29px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <!-- Your HTML elements for invoice input -->
            <!-- Example: -->
            <asp:TextBox ID="txtCustomerName" runat="server" placeholder="Customer Name"></asp:TextBox>
            <asp:TextBox ID="txtItemName" runat="server" placeholder="Item Name"></asp:TextBox>
            <asp:TextBox ID="txtQuantity" runat="server" placeholder="Quantity"></asp:TextBox>
            <asp:TextBox ID="txtPrice" runat="server" placeholder="Price"></asp:TextBox>
            <asp:Button ID="btnAddItem" runat="server" Text="Add Item" OnClick="btnAddItem_Click" CssClass="auto-style1" />
            <!--<asp:GridView ID="gvItems" runat="server">
               <!-- Define GridView columns here 
            </asp:GridView>-->
            <asp:Button ID="btnGenerateInvoice" runat="server" Text="Generate Invoice" OnClick="btnGenerateInvoice_Click" />
        </div>
    </form>
</body>
</html>



