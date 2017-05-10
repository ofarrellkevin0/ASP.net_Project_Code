<%@ Control Language="C#" AutoEventWireup="true" CodeFile="LoginUserControl.ascx.cs" Inherits="Controls_LoginUserControl" %>

    <h2>Login User</h2>
    <div class="row">
    <div class="col-md-8">
    <section id="loginForm">
    <div class="form-horizontal">

        <div class="form-group">
        <div class="col-md-10">
        <asp:Label ID="UsernameLabel" AssociatedControlID="UsernameTextBox" runat="server">Username</asp:Label>
        <asp:TextBox ID="UsernameTextBox" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="UsernameRequiredFieldValidator" ControlToValidate="UsernameTextBox" runat="server"> Username cannot be blank.</asp:RequiredFieldValidator>
        <br />
        <asp:RegularExpressionValidator runat="server" ID="rexletter3" ControlToValidate="UsernameTextBox" validationexpression="^[a-zA-Z1-9.]{4,15}$" errormessage="Letters and numbers only. Minimum 4 and Maximum 15 letters"/>
        </div>
        </div>
 
        <div class="form-group">
        <div class="col-md-10">
        <asp:Label ID="PasswordLabel" AssociatedControlID="PasswordTextBox" runat="server">Password</asp:Label>
        <asp:TextBox ID="PasswordTextBox" TextMode="Password" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="PasswordRequiredFieldValidator" ControlToValidate="PasswordTextBox" runat="server"> Password cannot be blank.</asp:RequiredFieldValidator>
        </div>
        </div>

   <div class="form-group">
   <div class="col-md-10">
        <asp:Button ID="SubmitButton" runat="server" Text="login" OnClick="SubmitButton_Click" CssClass="btn btn-primary" ></asp:Button>
   </div>
   </div>
   </div>
   </section>
   </div>
   </div>
<asp:Label ID="output" runat="server"></asp:Label>