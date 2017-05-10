<%@ Page Language="C#"  MasterPageFile="~/MasterPages/Tuner.master" AutoEventWireup="true" CodeFile="InstrumentEdit.aspx.cs" Inherits="InstrumentEdit" %>
<%@ Register TagPrefix="uc" TagName="InstrumentEditUserControl" Src="~/Controls/InstrumentEditUserControl.ascx" %>

<asp:Content ID="Content2" ContentPlaceHolderID="maincontent" runat="Server">
<uc:InstrumentEditUserControl ID ="item" runat="server" />
</asp:Content>