<%@ Page Language="C#" MasterPageFile="~/MasterPages/Tuner.master" AutoEventWireup="true" CodeFile="MyInstruments.aspx.cs" Inherits="Create_Instrument" %>
<%@ Register TagPrefix="uc" TagName="MyInstrumentsUserControl" Src="~/Controls/MyInstrumentsUserControl.ascx" %>

<asp:Content ID="Content2" ContentPlaceHolderID="maincontent" runat="Server">

        <uc:MyInstrumentsUserControl ID ="item" runat="server" />

</asp:Content>