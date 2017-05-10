<%@ Control Language="C#" AutoEventWireup="true" CodeFile="RecordingEditUserControl.ascx.cs" Inherits="Controls_RecordingEditUserControl" %>

<!DOCTYPE html>

        <div class="row" style="margin-top: 10px;">
        <h1> Edit Recording</h1>
        <p> This page allows the user to edit the name of the recording and update the name in the database.</p>
        </div>
     
     <div class="row" style="margin-top: 10px;">    
     <div class="col-md-2"><asp:Label ID="RecordnameLabel" AssociatedControlID="RecordnameTextBox" runat="server">Recording Name</asp:Label></div>
     <div class="col-md-2"><asp:TextBox ID="RecordnameTextBox" runat="server"></asp:TextBox></div>
     <div class="col-md-2"><asp:RequiredFieldValidator ID="RecordnameRequiredFieldValidator" ControlToValidate="RecordnameTextBox" runat="server"> Recordingname cannot be blank.</asp:RequiredFieldValidator></div>
     </div>
     <br />
     <asp:RegularExpressionValidator runat="server" ID="rexnumber1" ControlToValidate="RecordnameTextBox" validationexpression="^[a-zA-Z1-9.]{6,20}$" errormessage="New Name needs 6 characters minimum with Maximum 20. Numbers are allowed."/>
     
        
        <div class="row" style="margin-top: 10px;"> 
        <div class="col-md-2"><asp:Button ID="SubmitButton" runat="server" Text="Update" OnClick="SubmitButton_Click" CssClass="btn btn-info" ></asp:Button> </div>
        </div>
