<%@ Control Language="C#" AutoEventWireup="true" CodeFile="InstrumentEditUserControl.ascx.cs" Inherits="Controls_InstrumentEditUserControl" %>

<!DOCTYPE html>

        <div class="row" style="margin-top: 10px;">
        <h1> Edit Instrument</h1>
        <p> This page allows user to edit an instrument previously made by the user and update it on the database.</p>
        </div>

   <div class="row" style="margin-top: 10px;"> 
   <div class="col-md-2"><asp:Label ID="GuitarnameLabel" AssociatedControlID="GuitarnameTextBox" runat="server">Guitar name:</asp:Label></div>
   <div class="col-md-2"><asp:TextBox ID="GuitarnameTextBox" runat="server"></asp:TextBox></div>
   <div class="col-md-2"><asp:RequiredFieldValidator ID="guitarnameRequiredFieldValidator" ControlToValidate="GuitarnameTextBox" runat="server"> Guitarname cannot be blank.</asp:RequiredFieldValidator></div>
   </div>
   <br />
   <asp:RegularExpressionValidator runat="server" ID="rexnumber1" ControlToValidate="GuitarnameTextBox" validationexpression="^[a-zA-Z1-9.]{3,6}$" errormessage="Name needs 3 characters minimum with Maximum 6. Numbers are allowed."/>
  
     <div class="row" style="margin-top: 10px;"> 
     <div class="col-md-2"><asp:Label ID="TypenameLabel" AssociatedControlID="TypeList" runat="server">Guitar type:</asp:Label></div>
    
             <div class="col-md-2"><asp:DropDownList runat="server" ID="TypeList" CssClass="btn btn-info dropdown-toggle">  
             <asp:ListItem Text="Guitar" Value="Guitar" Selected="True"></asp:ListItem>
             <asp:ListItem Text="Bass" Value="Bass"></asp:ListItem> </asp:DropDownList></div>

      <div class="col-md-2"> <asp:RequiredFieldValidator ID="TypenameRequiredFieldValidator" ControlToValidate="TypeList" runat="server"> Typename cannot be blank.</asp:RequiredFieldValidator> </div>
   </div>


     <div class="row" style="margin-top: 10px;">
        <div class="col-md-2"> <asp:Button ID="SubmitButton" runat="server" Text="Update" OnClick="SubmitButton_Click" CssClass="btn btn-info" /> </div>
        <div class="col-md-2"> <asp:Label ID="Label1" runat="server"> </asp:Label> </div>

         </div>

