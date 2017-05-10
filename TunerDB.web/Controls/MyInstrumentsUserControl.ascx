<%@ Control Language="C#" AutoEventWireup="true" CodeFile="MyInstrumentsUserControl.ascx.cs" Inherits="Controls_MyInstrumentsUserControl" %>

<!DOCTYPE html>

   <asp:GridView DataKeyNames="ID" ID="gridview1" 
       AutoGenerateColumns ="false" 
       OnRowEditing="gridview1_RowEditing"
        OnRowDeleting="gridview1_RowDeleting"  
       runat="server"
       CssClass="table table-striped"                    
       >

               <Columns>
            <asp:CommandField ButtonType="Button"  ShowEditButton="true" HeaderText="Edit" ControlStyle-CssClass="btn btn-warning btn-xs" />
            <asp:CommandField ButtonType ="Button" ShowDeleteButton="true" HeaderText="Delete" ControlStyle-CssClass="btn btn-danger btn-xs"/>
            <asp:BoundField DataField="Name" HeaderText="Name" />

            <asp:BoundField DataField="Type"     HeaderText="Type" 
            ControlStyle-CssClass="hidden-sm, hidden-xs" FooterStyle-CssClass="hidden-sm, hidden-xs" 
            ItemStyle-CssClass="hidden-sm, hidden-xs"    HeaderStyle-CssClass="hidden-sm, hidden-xs" />

            <asp:BoundField DataField="LastTuned"     HeaderText="Last Tuned" 
            ControlStyle-CssClass="hidden-sm, hidden-xs" FooterStyle-CssClass="hidden-sm, hidden-xs" 
            ItemStyle-CssClass="hidden-sm, hidden-xs"    HeaderStyle-CssClass="hidden-sm, hidden-xs" />

        </Columns>
    </asp:GridView>

