using System;
using System.Web.Security;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.item.UserStartPage = "~/Pages/Tuner.aspx";
    }
}