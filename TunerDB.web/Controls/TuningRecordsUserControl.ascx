<%@ Control Language="C#" AutoEventWireup="true" CodeFile="TuningRecordsUserControl.ascx.cs" Inherits="Controls_TuningRecordUserControl" %>

<!DOCTYPE html>

<asp:GridView 
        DataKeyNames="ID"
        AutoGenerateColumns ="false"  
        ID="gridview1" 
        runat="server"
        CssClass="table table-striped" >
    
        <Columns>
            <asp:BoundField DataField="ID" HeaderText="User ID"             
            ControlStyle-CssClass="hidden-sm, hidden-xs" FooterStyle-CssClass="hidden-sm, hidden-xs" 
            ItemStyle-CssClass="hidden-sm, hidden-xs"    HeaderStyle-CssClass="hidden-sm, hidden-xs"/>

            <asp:BoundField DataField="Username" HeaderText="Username"/>
            <asp:BoundField DataField="Name" HeaderText="Name"/>

            <asp:BoundField DataField="Type" HeaderText="Type"
            ControlStyle-CssClass="hidden-sm, hidden-xs" FooterStyle-CssClass="hidden-sm, hidden-xs" 
            ItemStyle-CssClass="hidden-sm, hidden-xs"    HeaderStyle-CssClass="hidden-sm, hidden-xs"/>

            <asp:BoundField DataField="Date" HeaderText="TimeLogged"/>

        </Columns>
    </asp:GridView>
