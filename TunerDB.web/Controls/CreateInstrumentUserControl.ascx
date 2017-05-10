<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CreateInstrumentUserControl.ascx.cs" Inherits="Controls_CreateInstrumentUserControl" %>

<!DOCTYPE html>

        <div class="row" style="margin-top: 10px;">
        <h1> Create Instrument</h1>
        <p> This page allows the user to create an instrument, for the purposes of tuning the instrument later, and adding it to the database.</p>
        </div>
    <div class="row" style="margin-top: 10px;"> 
        <div class="col-md-2"><asp:Label ID="NameLabel" AssociatedControlID="NameTextBox" runat="server">Guitar Name:</asp:Label></div>
        <div class="col-md-2"><asp:TextBox ID="NameTextBox" MaxLength="6" runat="server"></asp:TextBox>  </div>
        <div class="col-md-2"><asp:RequiredFieldValidator ID="NameRequiredFieldValidator" ControlToValidate="NameTextBox" runat="server"> Name cannot be blank.</asp:RequiredFieldValidator> </div>
        </div>
        <br />
        <asp:RegularExpressionValidator runat="server" ID="rexnumber1" ControlToValidate="NameTextBox" validationexpression="^[a-zA-Z1-9.]{3,6}$" errormessage="Name needs 3 characters minimum with Maximum 6. Numbers are allowed."/>
        
   <div class="row" style="margin-top: 10px;">
        <div class="col-md-2"><asp:Label ID="TypeLabel" AssociatedControlID="TypeList" runat="server">Guitar Type:</asp:Label> </div>
         <div class="col-md-2"><asp:DropDownList runat="server" ID="TypeList" CssClass="btn btn-info dropdown-toggle">  

             <asp:ListItem Text="Guitar" Value="Guitar" Selected="True"></asp:ListItem>
             <asp:ListItem Text="Bass" Value="Bass"></asp:ListItem> </asp:DropDownList></div>

        <div class="col-md-2"><asp:RequiredFieldValidator ID="TypeRequiredFieldValidator" ControlToValidate="TypeList" runat="server"> Type cannot be blank.</asp:RequiredFieldValidator> </div>
    </div>
      

    <div class="row" style="margin-top: 10px;">
     <div class="col-md-2">   <asp:Button ID="SubmitButton" runat="server" Text="register" OnClick="SubmitButton_Click" CssClass ="btn btn-info" ></asp:Button> </div>
</div>
