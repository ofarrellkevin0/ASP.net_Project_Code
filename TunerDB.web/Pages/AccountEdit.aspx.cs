using System;
using TunerDB;

public partial class Editing : System.Web.UI.Page
{
    public TunerMasterPage MyMaster
    {
        get
        {
            return (TunerMasterPage)(this.Master);

        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        User user = (User)this.Session["User"];

        if (this.Session["User"] == null)
        {
            this.Response.Redirect("~/Pages/Index.aspx");
        }

        if (user.IsAdmin())
        {
            this.MyMaster.ShowAdminLinks();
        }

        if (this.Session["User"] != null)
        {
            MyMaster.ShowUsername(user.Username);
        }

        int id = Convert.ToInt32(this.Request.QueryString["Id"]);
        if (!this.IsPostBack)
        {
            item.loadRecord();
            item.SetControlValues();
        }

    }
}
