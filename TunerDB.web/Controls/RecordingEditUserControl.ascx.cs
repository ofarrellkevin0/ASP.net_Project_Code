using System;

public partial class Controls_RecordingEditUserControl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        int id = Convert.ToInt32(this.Request.QueryString["Id"]);
        string RecordingName = this.RecordnameTextBox.Text;
        Global.TunerDB.RecordingRepository.UpdateRecordingName(id, RecordingName);
        this.Response.Redirect("~/Pages/MyRecordings.aspx");
    }

}