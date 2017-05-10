<%@ Page Language="C#" MasterPageFile="~/MasterPages/Tuner.master" AutoEventWireup="true" CodeFile="CreateInstrument.aspx.cs" Inherits="CreateInstrument" %>
<%@ Register TagPrefix="uc" TagName="CreateInstrumentUserControl" Src="~/Controls/CreateInstrumentUserControl.ascx" %>

<asp:Content ID="Content2" ContentPlaceHolderID="maincontent" runat="Server">

<uc:CreateInstrumentUserControl ID ="item" runat="server" />

    </asp:Content>



