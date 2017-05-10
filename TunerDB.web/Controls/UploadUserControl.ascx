<%@ Control Language="C#" AutoEventWireup="true" CodeFile="UploadUserControl.ascx.cs" Inherits="Controls_UploadUserControl" %>

<!DOCTYPE html>

    <div class="row" style="margin-top: 10px;">
        <h1>Upload</h1>
        <p> This page allows user to upload small clips of recordings to the database.</p>
        </div>

        <div class="row" style="margin-top: 10px">
        <asp:FileUpload ID="fileupload" runat="server" />
        </div>

        <div class="row" style="margin-top: 15px">
        <asp:Button ID="uploading" runat ="server" OnClick ="uploading_Click" Text ="Upload"  CssClass="btn btn-info"  />
        </div>

    <div class="row" style="margin-top: 10px;">
    <asp:Label runat="server" ID ="extentions" Text=""></asp:Label>
    </div>
