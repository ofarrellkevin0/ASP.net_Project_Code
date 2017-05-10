<%@ Page Language="C#" MasterPageFile="~/MasterPages/Tuner.master" AutoEventWireup="true" CodeFile="MyRecordings.aspx.cs" Inherits="MyRecordings" %>
<%@ Register TagPrefix="uc" TagName="MyRecordingsUserControl" Src="~/Controls/MyRecordingsUserControl.ascx" %>

<asp:Content ID="Content2" ContentPlaceHolderID="maincontent" runat="Server">
    
    <uc:MyRecordingsUserControl ID ="item" runat="server" />

    </asp:Content>
