using System;
using System.Web;
using System.Web.Security;
using TunerDB;

public partial class Pages_LogOut : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        User user = (User)this.Session["User"];
        if (this.Session["User"] == null)
        {
            this.Response.Redirect("~/Pages/Index.aspx");
        }
    }

    protected void Destroy(object sender, EventArgs e)
    {
            Session.Clear();
            Session.Abandon();
            Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(-1));
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetNoStore();
            Response.Cache.AppendCacheExtension("no-cache");
            try
            {
                Session.Abandon();
                FormsAuthentication.SignOut();
                Response.Cache.SetCacheability(HttpCacheability.NoCache);
                Response.Buffer = true;
                Response.ExpiresAbsolute = DateTime.Now.AddDays(-1d);
                Response.Expires = -1000;
                Response.CacheControl = "no-cache";
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        Response.Redirect("~/Pages/Index.aspx");
    }
}