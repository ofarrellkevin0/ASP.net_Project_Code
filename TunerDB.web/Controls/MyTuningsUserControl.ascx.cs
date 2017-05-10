using System;

public partial class Controls_MyTuningsUserControl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void SelectTunings(int id)
    {
        this.gridview1.DataSource = Global.TunerDB.InstrumentTunerRepository.DataTable(Global.TunerDB.InstrumentTunerRepository.SelectTuningRecords(id));
        this.gridview1.DataBind();
    }

}