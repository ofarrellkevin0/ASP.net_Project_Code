<%@ Page Language="C#" MasterPageFile="~/MasterPages/Tuner.master" AutoEventWireup="true" CodeFile="Record.aspx.cs" Inherits="FFT_HTML_Record" %>
<%@ Register TagPrefix="uc" TagName="RecordUserControl" Src="~/Controls/RecordUserControl.ascx" %>

<asp:Content ID="Content2" ContentPlaceHolderID="maincontent" runat="Server">

    <uc:RecordUserControl ID = "item" runat = "server" />
    
    <script language="javascript" type="text/javascript" src="../Scripts/Recording.js"></script>
    <script language="javascript" type="text/javascript" src="../Libraries/p5.min.js"></script>
    <script language="javascript" type="text/javascript" src="../Libraries/p5.dom.js"></script>
    <script language="javascript" type="text/javascript" src="../Libraries/p5.sound.js"></script>

</asp:Content>