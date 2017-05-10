using System;

public partial class Controls_TuningRecordUserControl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void SelectTuningRecords()
    {
        this.gridview1.DataSource = Global.TunerDB.InstrumentRepository.DataTable(Global.TunerDB.InstrumentRepository.TuningRecords());
        this.gridview1.DataBind();
    }

}