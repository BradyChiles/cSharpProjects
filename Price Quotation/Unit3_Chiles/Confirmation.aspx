<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Confirmation.aspx.cs" Inherits="Unit3_Chiles.Confirmation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Quotation Confirmation</title>
     <meta name="viewport" content="width=device-width, inital-scale=1" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/main.css" rel="stylesheet" />
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</head>
<body>
    <div class="container">
        <header>
            <h1>Quotation Confirmation</h1>
        </header>
    
        <form id="form1" runat="server">
            <div class = "form-group">
                <asp:Label ID="lblSalesPrice" runat="server" Text="Sales Price:"></asp:Label>
            </div>
            <div class = "form-group">
                <asp:Label ID="lblDiscountAmount" runat="server" Text="Discount Amount:"></asp:Label>
             </div>
            <div class = "form-group">
                <asp:Label ID="lblTotalPrice" runat="server" Text="Total Price:"></asp:Label>
            </div>
            <div class = "form-group">
                <asp:Button ID="btnReturn" runat="server" Text="Return" 
                   CssClass="btn" BackColor="#339933" ForeColor="White"
                    PostBackUrl="~/Index.aspx"/>
            </div>
        </form>
    </div>
</body>
</html>
