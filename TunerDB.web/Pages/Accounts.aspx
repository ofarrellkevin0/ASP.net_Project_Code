<%@ Page Language="C#" MasterPageFile="~/MasterPages/Tuner.master" AutoEventWireup="true" CodeFile="Accounts.aspx.cs" Inherits="Accounts" %>
<%@ Register TagPrefix="uc" TagName="AccountsUserControl" Src="~/Controls/AccountsUserControl.ascx" %>


<asp:Content ID="Content2" ContentPlaceHolderID="maincontent" runat="Server">

        <uc:AccountsUserControl ID ="item" runat="server" />

    </asp:Content>
