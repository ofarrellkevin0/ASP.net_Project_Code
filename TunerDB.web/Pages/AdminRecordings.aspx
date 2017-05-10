<%@ Page Language="C#" MasterPageFile="~/MasterPages/Tuner.master" AutoEventWireup="true" CodeFile="AdminRecordings.aspx.cs" Inherits="Default2" %>
<%@ Register TagPrefix="uc" TagName="AdminRecordingsUserControl" Src="~/Controls/AdminRecordingsUserControl.ascx" %>

<asp:Content ID="Content2" ContentPlaceHolderID="maincontent" runat="Server">

     <uc:AdminRecordingsUserControl ID ="item" runat="server" />

</asp:Content>
