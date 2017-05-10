<%@ Page Language="C#" MasterPageFile="~/MasterPages/Tuner.master" AutoEventWireup="true" CodeFile="TuningRecords.aspx.cs" Inherits="Tuning_Records" %>
<%@ Register TagPrefix="uc" TagName="TuningRecordsUserControl" Src="~/Controls/TuningRecordsUserControl.ascx" %>

<asp:Content ID="Content2" ContentPlaceHolderID="maincontent" runat="Server">

        <uc:TuningRecordsUserControl ID ="item" runat="server" />

    </asp:Content>
