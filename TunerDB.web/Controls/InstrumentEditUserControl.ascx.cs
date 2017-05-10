using System;

public partial class Controls_InstrumentEditUserControl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        int id = Convert.ToInt32(this.Request.QueryString["Id"]);
        string guitarname = GuitarnameTextBox.Text;
        string guitartype = TypeList.Text;
        Global.TunerDB.InstrumentRepository.UpdateInstrument(id, guitarname, guitartype);
        this.Response.Redirect("~/Pages/MyInstruments.aspx");
    }

}