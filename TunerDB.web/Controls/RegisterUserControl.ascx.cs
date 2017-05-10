using System;
using TunerDB;
using System.IO;
using System.Text;
using System.Security.Cryptography;

public partial class Controls_RegisterUserControl : System.Web.UI.UserControl
{

    public User DataSource
    {
        get;
        set;
    }

    public void SetDataSourceValues()
    {
        this.DataSource = new User();
        this.DataSource.Firstname = this.FirstnameTextBox.Text;
        this.DataSource.Lastname = this.LastnameTextBox.Text;
        this.DataSource.Username = this.UsernameTextBox.Text;
        this.DataSource.Email = this.EmailTextBox.Text;

        String salt = "(+[>cn{72$J[&#VYkNVA>uLjcKRa]!LQLrZRl2S88xXKPRz ;Z@Nsc|~|Z=1jB!G";
        // byte array representation of that string
        byte[] encodedPassword = new UTF8Encoding().GetBytes(salt + this.PasswordTextBox.Text);
        
        // need MD5 to calculate the hash
        byte[] hash = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(encodedPassword);

        // string representation (similar to UNIX format)
        string encoded = BitConverter.ToString(hash)
           // without dashes
           .Replace("-", string.Empty)
           // make lowercase
           .ToLower();

        this.DataSource.Password = encoded;
        //this.DataSource.HashPassword(this.PasswordTextBox.Text);
    }


    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        this.SetDataSourceValues();
        bool valid1 = this.ValidateEmail();
		bool valid2 = this.ValidateUsername();
		if (valid1 && valid2)
        {
			try
            {
				Global.TunerDB.UserRepository.Create(this.DataSource);
                this.Response.Redirect("~/Pages/Index.aspx");
            }
            catch (IOException ex)
            {

                this.output.Text = "Failed!" + ex.Message;

            }
        }
    }

	private bool ValidateEmail()
	{
		bool result = true;
		bool isvalidemail;
		isvalidemail = Global.TunerDB.UserRepository.IsEmailUnique(this.DataSource);

		if (!isvalidemail)
		{
			this.IsValid.Text = "Email or Username is already registered";
			result = false;
		}
		return result; 
	}

    private bool ValidateUsername() {
		bool result = true;
		bool isvalidusername;
		isvalidusername = Global.TunerDB.UserRepository.IsUsernameUnique(this.DataSource);

		if (!isvalidusername)
		{
			this.IsValid.Text = "Email or Username is already registered";
			result = false;
		}
		 return result; 
	}
}