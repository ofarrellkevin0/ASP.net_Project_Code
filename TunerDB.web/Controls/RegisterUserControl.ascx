<%@ Control Language="C#" AutoEventWireup="true" CodeFile="RegisterUserControl.ascx.cs" Inherits="Controls_RegisterUserControl" %>

    <div class="row">
    <div class="col-md-8">
    <section id="loginForm">
    <div class="form-horizontal">

     <h2>Create a New Account</h2>

     <div class="form-group">
       <asp:Label ID="FirstnameLabel" AssociatedControlID="FirstnameTextBox" runat="server" CssClass="col-md-2 control-label">Firstname</asp:Label>
     <div class="col-md-10">
       <asp:TextBox ID="FirstnameTextBox" runat="server" CssClass="form-control"></asp:TextBox>
       <asp:RequiredFieldValidator ID="FirstnameRequiredFieldValidator" ControlToValidate="FirstnameTextBox" runat="server"> Firstname cannot be blank.</asp:RequiredFieldValidator>
       <br />
       <asp:RegularExpressionValidator runat="server" ID="rexletter1" ControlToValidate="FirstnameTextBox" validationexpression="^[a-zA-Z.]{4,15}$" errormessage="Letters only with Minimum 4 and Maximum 15 letters"/>
     </div>
     </div>
     
     <div class="form-group">
       <asp:Label ID="LastnameLabel" AssociatedControlID="LastnameTextBox" runat="server" CssClass="col-md-2 control-label">Lastname</asp:Label>
     <div class="col-md-10">  
       <asp:TextBox ID="LastnameTextBox" runat="server" CssClass="form-control"></asp:TextBox>
       <asp:RequiredFieldValidator ID="LastnameRequiredFieldValidator" ControlToValidate="LastnameTextBox" runat="server"> Lastname cannot be blank.</asp:RequiredFieldValidator>
       <br />
       <asp:RegularExpressionValidator runat="server" ID="rexletter2" ControlToValidate="LastnameTextBox" validationexpression="^[a-zA-Z'.]{4,20}$" errormessage="Letters only with character ' allowed. Minimum 4 and Maximum 20 letters"/>
     </div>
     </div>
     
     <div class="form-group">
       <asp:Label ID="UsernameLabel" AssociatedControlID="UsernameTextBox" runat="server" CssClass="col-md-2 control-label">Username</asp:Label>
     <div class="col-md-10">  
       <asp:TextBox ID="UsernameTextBox" runat="server" CssClass="form-control" ></asp:TextBox>
       <asp:RequiredFieldValidator ID="UsernameRequiredFieldValidator" ControlToValidate="UsernameTextBox" runat="server"> Username cannot be blank.</asp:RequiredFieldValidator>
       <br />
       <asp:RegularExpressionValidator runat="server" ID="rexletter3" ControlToValidate="UsernameTextBox" validationexpression="^[a-zA-Z1-9.]{4,15}$" errormessage="Letters and numbers only. Minimum 4 and Maximum 15 letters"/>
     </div>
     </div>

     <div class="form-group">
       <asp:Label ID="EmailLabel" AssociatedControlID="EmailTextBox" runat="server" CssClass="col-md-2 control-label">Email</asp:Label>
     <div class="col-md-10">
       <asp:TextBox ID="EmailTextBox" TextMode="Email" runat="server" CssClass="form-control"></asp:TextBox>
       <asp:RequiredFieldValidator ID="EmailRequiredFieldValidator" ControlToValidate="EmailTextBox" runat="server"> Email cannot be blank.</asp:RequiredFieldValidator>
     </div>
     </div>

     <div class="form-group">
       <asp:Label ID="PasswordLabel" AssociatedControlID="PasswordTextBox" runat="server" CssClass="col-md-2 control-label">Password</asp:Label>
     <div class="col-md-10">
       <asp:TextBox ID="PasswordTextBox" TextMode="Password" runat="server" CssClass="form-control" ></asp:TextBox>
       <asp:RequiredFieldValidator ID="PasswordRequiredFieldValidator" ControlToValidate="PasswordTextBox" runat="server"></asp:RequiredFieldValidator>
       <br />
       <asp:RegularExpressionValidator runat="server" ID="rexnumber1" ControlToValidate="PasswordTextBox" validationexpression="^[a-zA-Z1-9'!@$&.]{6,20}$" errormessage="Password needs 6 characters minimum with Maximum 20. characters ' ! @ $ & are allowed"/>
     </div>
     </div>

     <div class="form-group">
        <asp:Label runat="server" AssociatedControlID="ConfirmPassword" CssClass="col-md-2 control-label">Confirm</asp:Label>
     <div class="col-md-10">
        <asp:TextBox runat="server" ID="ConfirmPassword" TextMode="Password" CssClass="form-control" />
        <asp:RequiredFieldValidator runat="server" ControlToValidate="ConfirmPassword" Display="Dynamic" ErrorMessage="The confirm password field is required." />
        <br />
        <asp:CompareValidator runat="server" ControlToCompare="PasswordTextBox" ControlToValidate="ConfirmPassword"  Display="Dynamic" ErrorMessage="passwords don't match." />
        <br />
     <asp:Label ID="IsValid" runat="server"></asp:Label>
     <br />
     </div>
     </div>

     <div class="form-group">
     <div class="col-md-10 col-sm-push-2">
        <asp:Button ID="SubmitButton" runat="server" Text="register" OnClick="SubmitButton_Click" CssClass="btn btn-primary" ></asp:Button>
     </div>
     </div>

     </div>
     </section>
     </div>
     </div>


<asp:Label ID="output" runat="server"></asp:Label>