<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AccountEditUserControl.ascx.cs" Inherits="Controls_AccountEditUserControl" %>

<!DOCTYPE html>

<div class="row" style="margin-top: 10px;">
        <h1> Edit Account</h1>
        <p> This page allows the user to edit an account. Email, Firstname, Lastname, username and deactactivating privileges and accounts can be done here by an admin of the system.</p>
        </div>

       <div class="row" style="margin-top: 10px;">
       <div class="col-md-2"><asp:Label ID="FirstnameLabel" AssociatedControlID="FirstnameTextBox" runat="server">Firstname</asp:Label></div>
       <div class="col-md-2"><asp:TextBox ID="FirstnameTextBox" runat="server"></asp:TextBox></div>
       <div class="col-md-2"><asp:RequiredFieldValidator ID="FirstnameRequiredFieldValidator" ControlToValidate="FirstnameTextBox" runat="server"> Firstname cannot be blank.</asp:RequiredFieldValidator></div>
       </div>
       <asp:RegularExpressionValidator runat="server" ID="rexletter1" ControlToValidate="FirstnameTextBox" validationexpression="^[a-zA-Z.]{4,15}$" errormessage="Letters only with Minimum 4 and Maximum 15 letters"/>

       <div class="row" style="margin-top: 10px;">
       <div class="col-md-2"><asp:Label ID="LastnameLabel" AssociatedControlID="LastnameTextBox" runat="server">Lastname</asp:Label></div>
       <div class="col-md-2"><asp:TextBox ID="LastnameTextBox" runat="server"></asp:TextBox></div>
       <div class="col-md-2"><asp:RequiredFieldValidator ID="LastnameRequiredFieldValidator" ControlToValidate="LastnameTextBox" runat="server"> Lastname cannot be blank.</asp:RequiredFieldValidator></div>
       </div>
       <asp:RegularExpressionValidator runat="server" ID="rexletter2" ControlToValidate="LastnameTextBox" validationexpression="^[a-zA-Z'.]{4,20}$" errormessage="Letters only with character ' allowed. Minimum 4 and Maximum 20 letters"/>
    
       <div class="row" style="margin-top: 10px;">
       <div class="col-md-2"><asp:Label ID="UsernameLabel" AssociatedControlID="UsernameTextBox" runat="server">Username</asp:Label></div>
       <div class="col-md-2"><asp:TextBox ID="UsernameTextBox" runat="server" OnChange="CheckUserName(this)" ></asp:TextBox></div>
       <div class="col-md-2"><asp:RequiredFieldValidator ID="UsernameRequiredFieldValidator" ControlToValidate="UsernameTextBox" runat="server"> Username cannot be blank.</asp:RequiredFieldValidator></div>
       </div>
       <asp:RegularExpressionValidator runat="server" ID="rexletter3" ControlToValidate="UsernameTextBox" validationexpression="^[a-zA-Z1-9.]{4,15}$" errormessage="Letters and numbers only. Minimum 4 and Maximum 15 letters"/>
       
       <div class="row" style="margin-top: 10px;">
       <div class="col-md-2"><asp:Label ID="EmailLabel" AssociatedControlID="EmailTextBox" runat="server">Email</asp:Label></div>
       <div class="col-md-2"><asp:TextBox ID="EmailTextBox" TextMode="Email" runat="server"></asp:TextBox></div>
       <div class="col-md-2"><asp:RequiredFieldValidator ID="EmailRequiredFieldValidator" ControlToValidate="EmailTextBox" runat="server"> Email cannot be blank.</asp:RequiredFieldValidator></div>
       </div>
       

       <div class="row" style="margin-top: 25px;">
       <div class="col-md-2"><asp:Label ID="PrivilegeLabel" AssociatedControlID="PrivilegeTextBox" runat="server">Privilege</asp:Label></div>
       <div class="col-md-2"><asp:TextBox ID="PrivilegeTextBox" runat="server"></asp:TextBox></div>
       <div class="col-md-2"><asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="PrivilegeTextBox" runat="server"> Privilege cannot be blank.</asp:RequiredFieldValidator></div>
       </div>
       <asp:RegularExpressionValidator runat="server" ID="rexnum1" ControlToValidate="PrivilegeTextBox" validationexpression="^[1-2.]{1}$" errormessage="number 1 or 2 only"/>
      
       <div class="row" style="margin-top: 10px;">
       <div class="col-md-2" style="margin-top: 10px;"><asp:Label ID="IsActiveLabel" AssociatedControlID="IsActiveCheckBox" runat="server">IsActive</asp:Label></div>
       <div class="col-md-2" style="margin-top: 10px;"><asp:checkbox ID="IsActiveCheckBox" runat="server"></asp:checkbox></div>
       </div>
        
        <div class="row" style="margin-top: 10px;">
        <div class="col-md-2" style="margin-top: 10px;"><asp:Button ID="SubmitButton" runat="server" Text="Update" OnClick="SubmitButton_Click" CssClass="btn btn-info"></asp:Button></div>
        </div>

        <div class="row" style="margin-top: 10px;">
        <div class="col-md-2" style="margin-top: 10px;"><asp:Label ID="ValidEmail" AssociatedControlID="EmailTextBox" runat="server"></asp:Label></div>
        </div>

        <div class="row" style="margin-top: 10px;">
        <div class="col-md-2" style="margin-top: 10px;"><asp:Label ID="ValidUsername" AssociatedControlID="UsernameTextBox" runat="server"></asp:Label></div>
        </div>
