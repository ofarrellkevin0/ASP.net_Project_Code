<%@ Page Language="C#" MasterPageFile="~/MasterPages/Tuner.master" AutoEventWireup="true" CodeFile="Upload.aspx.cs" Inherits="Upload" %>
<%@ Register TagPrefix="uc" TagName="UploadUserControl" Src="~/Controls/UploadUserControl.ascx" %>

<asp:Content ID="Content2" ContentPlaceHolderID="maincontent" runat="Server">

    <uc:UploadUserControl ID ="item" runat="server" />

</asp:Content>