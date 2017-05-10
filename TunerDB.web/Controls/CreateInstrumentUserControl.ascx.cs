using System;
using TunerDB;

public partial class Controls_CreateInstrumentUserControl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        User user = (User)this.Session["User"];
        int id = user.ID;
        string Name = this.NameTextBox.Text;
        string Type = this.TypeList.SelectedItem.Text;
        Global.TunerDB.InstrumentRepository.CreateInstrument(Name, Type, id);
        this.Response.Redirect("~/Pages/Tuner.aspx");
    }
}