<%@ Page Language="C#"  MasterPageFile="~/MasterPages/Tuner.master" AutoEventWireup="true" CodeFile="MyTunings.aspx.cs" Inherits="Pages_MyTunings" %>
<%@ Register TagPrefix="uc" TagName="MyTuningsUserControl" Src="~/Controls/MyTuningsUserControl.ascx" %>

<asp:Content ID="Content2" ContentPlaceHolderID="maincontent" Runat="Server">

    <uc:MyTuningsUserControl ID ="item" runat="server" />

</asp:Content>
