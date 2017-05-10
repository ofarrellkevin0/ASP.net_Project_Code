<%@ Page Title="Contact" Language="C#" MasterPageFile="~/MasterPages/Site.Master" AutoEventWireup="true" CodeFile="Contact.aspx.cs" Inherits="Contact" %>
<%@ Register TagPrefix="uc" TagName="ContactUserControl" Src="~/Controls/ContactUserControl.ascx" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <uc:ContactUserControl ID ="item" runat="server" />

</asp:Content>
