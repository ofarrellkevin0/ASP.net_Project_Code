using System;
using System.Web.UI.WebControls;
using TunerDB;

public partial class Controls_MyInstrumentsUserControl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void SelectInstruments(int ID)
    {
        User user = (User)this.Session["User"];
        this.gridview1.DataSource = Global.TunerDB.InstrumentRepository.DataTable(Global.TunerDB.InstrumentRepository.SelectInstrument(ID, user));
        this.gridview1.DataBind();
    }

    protected void gridview1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int id = Convert.ToInt32(gridview1.DataKeys[e.RowIndex].Value);
        Global.TunerDB.InstrumentRepository.DeleteInstrument(id);
        User user = (User)this.Session["User"];
        int ID = user.ID;
        SelectInstruments(ID);
    }

    protected void gridview1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        int index = e.NewEditIndex;
        int Id = Convert.ToInt32(gridview1.DataKeys[index].Value);
        this.Response.Redirect("~/Pages/InstrumentEdit.aspx?Id=" + Id);
    }

}