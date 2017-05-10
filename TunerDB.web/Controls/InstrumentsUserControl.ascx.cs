using System;
using System.Web.UI.WebControls;

public partial class Controls_InstrumentsUserControl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void SelectAllInstruments()
    {
        this.gridview1.DataSource = Global.TunerDB.InstrumentRepository.DataTable(Global.TunerDB.InstrumentRepository.SelectAllInstruments());
        this.gridview1.DataBind();
    }

    protected void gridview1_RowDeleting1(object sender, GridViewDeleteEventArgs e)
    {
        int id = Convert.ToInt32(gridview1.DataKeys[e.RowIndex].Value);
        Global.TunerDB.InstrumentRepository.DeleteInstrument(id);
        SelectAllInstruments();
    }
}