using System;
using System.Web.UI.WebControls;
using TunerDB;

public partial class Controls_AdminRecordingsUserControl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void SelectAllRecordings()
    {
        this.gridview1.DataSource = 
        Global.TunerDB.RecordingRepository.DataTable(Global.TunerDB.RecordingRepository.SelectallRecordings());
        this.gridview1.DataBind();
    }

    protected void gridview1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int id = Convert.ToInt32(gridview1.DataKeys[e.RowIndex].Value);
        Global.TunerDB.RecordingRepository.DeleteRecording(id);
        User user = (User)this.Session["User"];
        SelectAllRecordings();
    }

    protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {
        int index = e.NewSelectedIndex;
        int Id = Convert.ToInt32(gridview1.DataKeys[index].Value);
        Recording item = Global.TunerDB.RecordingRepository.GetByID(Id);
        byte[] buffer = item.Data;

        this.Response.Clear();
        this.Response.ContentType = "Audio/wav";
        this.Response.AddHeader("Content-Disposition", "attachment; filename=" + item.RecordingName + ".wav");
        this.Response.Flush();
        this.Response.OutputStream.Write(buffer, 0, buffer.Length);
        this.Response.End();
    }
}