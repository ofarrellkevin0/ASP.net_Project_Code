using System;
using System.Security.Cryptography;
using System.Text;
using TunerDB;

public partial class Controls_LoginUserControl : System.Web.UI.UserControl
{
    public User DataSource
    {
        get;
        set;
    }

    public void SetDataSourceValues()
    {

        this.DataSource = new User();
        this.DataSource.Username = this.UsernameTextBox.Text;

        String salt = "(+[>cn{72$J[&#VYkNVA>uLjcKRa]!LQLrZRl2S88xXKPRz ;Z@Nsc|~|Z=1jB!G";
        // byte array representation of that string
        byte[] encodedPassword = new UTF8Encoding().GetBytes(salt+this.PasswordTextBox.Text);

        // need MD5 to calculate the hash
        byte[] hash = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(encodedPassword);

        // string representation
        string encoded = BitConverter.ToString(hash)
           // without dashes
           .Replace("-", string.Empty)
           // make lowercase
           .ToLower();

        this.DataSource.Password = encoded;
    }

    public String UserStartPage
    {
        get;
        set;
    }
    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        this.SetDataSourceValues();
        try
        {
            User userA = Global.TunerDB.UserLogin(this.DataSource.Username, this.DataSource.Password);
            User userB = Global.TunerDB.LoginActive(this.DataSource.Username, this.DataSource.Password);
            bool a = userA != null;
            bool b = userB != null;
            if (a && b)
            {
                this.Page.Session["User"] = userA;
                this.Page.Response.Redirect(this.UserStartPage);
            }
            else if(a&&!b)
            {
                this.output.Text = "User account locked! Please contact administrator";
            }
            else
            {
                this.output.Text = "Username or Password is Incorrect";
            }
        }
        catch(NotImplementedException ex)
        {
            this.output.Text = "Failed!"+ex.Message;
        }
    }
}