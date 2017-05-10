<%@ Page Language="C#" MasterPageFile="~/MasterPages/Tuner.master" AutoEventWireup="true" CodeFile="AccountEdit.aspx.cs" Inherits="Editing" %>
<%@ Register TagPrefix="uc" TagName="AccountEditUserControl" Src="~/Controls/AccountEditUserControl.ascx" %>

<asp:Content ID="Content2" ContentPlaceHolderID="Maincontent" runat="Server">

    <uc:AccountEditUserControl ID ="item" runat="server" />

    </asp:Content>
