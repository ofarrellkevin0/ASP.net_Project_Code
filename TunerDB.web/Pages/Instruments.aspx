<%@ Page Language="C#" MasterPageFile="~/MasterPages/Tuner.master" AutoEventWireup="true" CodeFile="Instruments.aspx.cs" Inherits="AllInstruments" %>
<%@ Register TagPrefix="uc" TagName="InstrumentsUserControl" Src="~/Controls/InstrumentsUserControl.ascx" %>

<asp:Content ID="Content2" ContentPlaceHolderID="maincontent" runat="Server">

    <uc:InstrumentsUserControl ID ="item" runat="server" />

    </asp:Content>