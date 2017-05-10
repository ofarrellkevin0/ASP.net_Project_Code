using System;
using System.Web.UI.WebControls;
using TunerDB;

public partial class Controls_AccountsUserControl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public User DataSource
    {
        get;
        set;
    }

    public void SelectAllUsers()
    {
        this.gridview1.DataSource = Global.TunerDB.UserRepository.DataTable(Global.TunerDB.UserRepository.SelectAllUsers());
        this.gridview1.DataBind();
    }

    protected void gridview1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int id = Convert.ToInt32(gridview1.DataKeys[e.RowIndex].Value);
        Global.TunerDB.UserRepository.DeleteUserbyID(id);
        SelectAllUsers();
    }

    protected void gridview1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        int index = e.NewEditIndex;
        int Id = Convert.ToInt32(gridview1.DataKeys[index].Value);
        this.Response.Redirect("~/Pages/AccountEdit.aspx?Id=" + Id);
    }
}