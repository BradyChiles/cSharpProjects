<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Unit3_Chiles.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Price Quotation</title>
    <meta name="viewport" content="width=device-width, inital-scale=1" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/main.css" rel="stylesheet" />
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</head>
<body style="height: 256px">
    <div class ="container">
        <header>
            <h1>Price Quotation</h1>
        </header>
        
        <form id="form1" runat="server">
             <asp:Label ID="lblCalcConfirmError" runat="server"></asp:Label>
            <div class = "form-group">
                <label for="salesPrice" id="lblSalesPrice">Sales Price</label>
                <asp:RequiredFieldValidator ID="reqFieldSales" runat="server" ErrorMessage="Required"
                     ControlToValidate="txtSalesPrice" CssClass="text-danger">
                </asp:RequiredFieldValidator>
                <asp:TextBox ID="txtSalesPrice" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="Discount" id="lblDiscountPercent">Discount Percent</label>
                <asp:RequiredFieldValidator ID="reqFieldDiscountPercent" runat="server" ErrorMessage="Required"
                     ControlToValidate="txtDiscountPercent" CssClass="text-danger">
                </asp:RequiredFieldValidator>
                 <asp:TextBox ID="txtDiscountPercent" runat="server" CssClass="form-control"></asp:TextBox>
               <asp:Label ID="lblDiscountAmount" runat="server" Text="Discount Amount:"></asp:Label>
            </div>
            <div class="form-group">
                <asp:Label ID="lblTotalPrice" runat="server" Text="Total Price:"></asp:Label>
            </div>
           <div class="form-group">
               <asp:Button ID="btnCalculate" runat="server" Text="Calculate" 
                   CssClass="btn btn-primary" OnClick="btnCalculate_Click"/>
               <asp:Button ID="btnConfirm" runat="server" Text="Confirm" 
                   CssClass="btn" OnClick="btnConfirm_Click" BackColor="#339933" ForeColor="White"/>
            </div>
            <div class="form-group">
                <label id="lblCalcConfirmReminder">Be sure to click the Calculate button before you confirm.</label>
            </div>
        </form>
    </div>
</body>
</html>

