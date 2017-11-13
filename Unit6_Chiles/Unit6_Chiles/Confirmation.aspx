<%@ Page Title="" Language="C#" MasterPageFile="~/Unit_6.Master" AutoEventWireup="true" CodeBehind="Confirmation.aspx.cs" Inherits="Unit5_Chiles.Confirmation" %>

<asp:Content ID="contentIndex" ContentPlaceHolderID="mainPlaceHolder" runat="server">

    <form id="form1" runat="server">

            <h2>Request Confirmation</h2>

            <h3>Please confirm your reservation request</h3>

            <div class="form-group">
                <label class="labelSpace">First Name: </label> <asp:Label ID="lblFirstName" runat="server"></asp:Label><br />
                <label class="labelSpace">Last Name: </label> <asp:Label ID="lblLastName" runat="server"></asp:Label><br />
                <label class="labelSpace">Email: </label> <asp:Label ID="lblEmail" runat="server"></asp:Label><br />
                <label class="labelSpace">Phone: </label> <asp:Label ID="lblPhone" runat="server"></asp:Label><br />
                <label class="labelSpace">Contact Method: </label> <asp:Label ID="lblContact" runat="server"></asp:Label><br />
            </div>

            <h3>Request Data</h3>

            <div class="form-group">
               <label class="labelSpace">Arrival Date: </label> <asp:Label ID="lblArrival" runat="server"></asp:Label><br />
               <label class="labelSpace">Departure Date: </label> <asp:Label ID="lblDeparture" runat="server"></asp:Label><br />
               <label class="labelSpace">No. of Days: </label> <asp:Label ID="lblDays" runat="server"></asp:Label><br />
               <label class="labelSpace">No. of People: </label> <asp:Label ID="lblPeople" runat="server"></asp:Label><br />
               <label class="labelSpace">Bed Type: </label> <asp:Label ID="lblBed" runat="server"></asp:Label><br />
               <label class="labelSpace">Special Requests: </label> <asp:Label ID="lblSpecial" runat="server"></asp:Label><br />
            </div>

            <div class="form-group">
                <asp:Button ID="btnConfirm" runat="server" Text="Confirm Request" CssClass ="btn btn-primary" OnClick="btnConfirm_Click" Width="138px"/>
                <asp:Button ID="btnModify" runat="server" Text="Modify Request" CssClass="btn btn-info" PostBackUrl ="~/index.aspx" Width="138px"/>
            </div>


            <div class = "form-group confirmationLabels">
                <asp:Label ID="lblConfirmation" runat="server" Text=""></asp:Label>
                <br />
                <asp:Label ID="lblConfirmation2" runat="server" Text=""></asp:Label>
            </div>

        </form>

</asp:Content>
