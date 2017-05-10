<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Site.master" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Default2" %>
<%@ Register TagPrefix="uc" TagName="LoginUserControl" Src="~/Controls/LoginUserControl.ascx" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">

    <uc:LoginUserControl ID ="item" runat="server" />

</asp:Content>

