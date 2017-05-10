<%@ Page Language="C#" MasterPageFile="~/MasterPages/Tuner.master" AutoEventWireup="true" CodeFile="RecordingEdit.aspx.cs" Inherits="RecordingName" %>
<%@ Register TagPrefix="uc" TagName="RecordingEditUserControl" Src="~/Controls/RecordingEditUserControl.ascx" %>

<asp:Content ID="Content2" ContentPlaceHolderID="maincontent" runat="Server">

    <uc:RecordingEditUserControl ID ="item" runat="server" />

</asp:Content>