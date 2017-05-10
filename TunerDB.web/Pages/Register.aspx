<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Site.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Default3" %>
<%@ Register TagPrefix="uc" TagName="RegisterUserControl" Src="~/Controls/RegisterUserControl.ascx" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    
    <uc:RegisterUserControl ID ="item" runat="server" />

</asp:Content>

