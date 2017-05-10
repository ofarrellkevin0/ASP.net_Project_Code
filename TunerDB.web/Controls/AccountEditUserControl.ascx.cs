using System;
using TunerDB;

public partial class Controls_AccountEditUserControl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void loadRecord()
    {
        User user = new User();
        int id = Convert.ToInt32(this.Request.QueryString["Id"]);
        this.DataSource = Global.TunerDB.UserRepository.GetByUserID(id);
    }

    public User DataSource
    {
        get;
        set;
    }

    public void SetControlValues()
    {
        if (this.DataSource != null)
        {
            this.FirstnameTextBox.Text = this.DataSource.Firstname;
            this.LastnameTextBox.Text = this.DataSource.Lastname;
            this.UsernameTextBox.Text = this.DataSource.Username;
            this.EmailTextBox.Text = this.DataSource.Email;
            this.PrivilegeTextBox.Text = this.DataSource.Privilege.ToString();
            this.IsActiveCheckBox.Checked = this.DataSource.IsActive;
        }
    }

    public void SetDataSourceValues()
    {
        this.DataSource = new User();
        int id = Convert.ToInt32(this.Request.QueryString["Id"]);

        this.DataSource.ID = id;


        this.DataSource.Firstname = this.FirstnameTextBox.Text;
        this.DataSource.Lastname = this.LastnameTextBox.Text;
        this.DataSource.Username = this.UsernameTextBox.Text;
        this.DataSource.Email = this.EmailTextBox.Text;
        this.DataSource.Privilege = int.Parse(this.PrivilegeTextBox.Text);
        this.DataSource.IsActive = (this.IsActiveCheckBox.Checked);

    }

    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        this.SetDataSourceValues();

        try
        {
            Global.TunerDB.UserRepository.Update(this.DataSource);
            this.Response.Redirect("~/Pages/Accounts.aspx");
        }
        catch (Exception)
        {

        }
    }
}
