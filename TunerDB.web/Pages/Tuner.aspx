<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Tuner.master" AutoEventWireup="true" CodeFile="Tuner.aspx.cs" Inherits="Default2" %>
<%@ Register TagPrefix="uc" TagName="TunerUserControl" Src="~/Controls/TunerUserControl.ascx" %>

<asp:Content ID="Content2" ContentPlaceHolderID="maincontent" Runat="Server">

    <uc:TunerUserControl ID ="item" runat="server" />


<button Type="button" id = "C_Button" class="btn-sm btn-info" Style="position:absolute; margin-top: 70px; margin-left:230px;"> C Note</button>
<button Type="button" id = "Db_Button" class="btn-sm btn-info" Style="position:absolute; margin-top: 70px; margin-left:300px;"> Db Note</button>
<button Type="button" id = "D_Button" class="btn-sm btn-info" Style="position:absolute; margin-top: 110px; margin-left:230px;"> D Note </button>
<button Type="button" id = "Eb_Button" class="btn-sm btn-info" Style="position:absolute; margin-top: 110px; margin-left:300px;"> Eb Note </button>
<button Type="button" id = "E_Button" class="btn-sm btn-info" Style="position:absolute; margin-top: 150px; margin-left:230px;"> E Note </button>
<button Type="button" id = "F_Button" class="btn-sm btn-info" Style="position:absolute; margin-top: 190px; margin-left:230px;"> F Note </button>
<button Type="button" id = "Gb_Button" class="btn-sm btn-info" Style="position:absolute; margin-top: 150px; margin-left:300px;"> Gb Note </button>
<button Type="button" id = "G_Button" class="btn-sm btn-info" Style="position:absolute; margin-top: 230px; margin-left:230px;"> G Note </button>
<button Type="button" id = "Ab_Button" class="btn-sm btn-info" Style="position:absolute; margin-top: 190px; margin-left:300px;"> Ab Note </button>
<button Type="button" id = "A_Button" class="btn-sm btn-info" Style="position:absolute; margin-top: 270px; margin-left:230px;"> A Note </button>
<button Type="button" id = "Bb_Button" class="btn-sm btn-info" Style="position:absolute; margin-top: 230px; margin-left:300px;"> Bb Note </button>
<button Type="button" id = "B_Button" class="btn-sm btn-info" Style="position:absolute; margin-top: 270px; margin-left:300px;"> B Note </button>
        
<script language="javascript" type="text/javascript" src="../Libraries/p5.min.js"></script>
<script language="javascript" type="text/javascript" src="../Libraries/p5.sound.js"></script>
<script language="javascript" type="text/javascript" src="../Scripts/Tuner.js"></script>

</asp:Content>

