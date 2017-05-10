using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace TunerDB.RepositoryComponents
{
    public class UserRepository : RepositioryBaseClass
    {
        public object Accounts { get; private set; }
        public string UserStartPage { get; private set; }

        public void Create(User user)
        {
            string spName = "userregister";
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = spName;
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new MySqlParameter("@Firstname_", user.Firstname));
            cmd.Parameters.Add(new MySqlParameter("@Lastname_", user.Lastname));
            cmd.Parameters.Add(new MySqlParameter("@Username_", user.Username));
            cmd.Parameters.Add(new MySqlParameter("@Userpass_", user.Password));
            cmd.Parameters.Add(new MySqlParameter("@Email_", user.Email));
            this.ExecuteNonQuery(cmd);
        }

        public bool IsEmailUnique(User user)
        {
            string spName = "checkemail";
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = spName;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("@Email_", user.Email));

            int count = this.Count(cmd);
            return count == 0;
        }

        public bool IsUsernameUnique(string value)
        {
            string spName = "checkusername";
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = spName;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("@Username_", value));

            int count = this.Count(cmd);
            return count == 0;
        }

        public User GetByUserID(int ID)
        {
            string spName = "getuserbyID";
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = spName;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("@ID_", ID));
            DataRow datarow = this.OneDataRow(cmd);
            User item = null;

            if (datarow != null)
            {
                item = new User();

                item.Firstname = Convert.ToString(datarow["Firstname"]);
                item.Lastname = Convert.ToString(datarow["Lastname"]);
                item.Username = Convert.ToString(datarow["Username"]);
                item.Password = Convert.ToString(datarow["Userpass"]);
                item.Email = Convert.ToString(datarow["Email"]);
                item.Privilege = Convert.ToInt32(datarow["PrivilegeLevel"]);
                item.ID = Convert.ToInt32(datarow["ID"]);
                item.IsActive = Convert.ToBoolean(datarow["IsActive"]);
            }
            return item;

        }

        public User Login(String Username, String Password)
        {
            string spName = "userlogin";
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = spName;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("@Username_", Username));
            cmd.Parameters.Add(new MySqlParameter("@Password_", Password));
            DataRow datarow = this.OneDataRow(cmd);
            User item = null;
            if (datarow != null)
            {
                item = new User();
                item.Firstname = Convert.ToString(datarow["Firstname"]);
                item.Lastname = Convert.ToString(datarow["Lastname"]);
                item.Username = Convert.ToString(datarow["Username"]);
                item.Password = Convert.ToString(datarow["Userpass"]);
                item.Email = Convert.ToString(datarow["Email"]);
                item.Privilege = Convert.ToInt32(datarow["PrivilegeLevel"]);
                item.ID = Convert.ToInt32(datarow["ID"]);
                item.IsActive = Convert.ToBoolean(datarow["IsActive"]);
            }
            return item;
        }

        public User LoginActive(String Username, String Password)
        {
            User user = new User();
            string spName = "userlogin2";
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = spName;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("@Username_", Username));
            cmd.Parameters.Add(new MySqlParameter("@Password_", Password));

            DataRow datarow = this.OneDataRow(cmd);
            User item = default(User);
            if (datarow != null)
            {
                item = new User();
                item.Firstname = Convert.ToString(datarow["Firstname"]);
                item.Lastname = Convert.ToString(datarow["Lastname"]);
                item.Username = Convert.ToString(datarow["Username"]);
                item.Password = Convert.ToString(datarow["Userpass"]);
                item.Email = Convert.ToString(datarow["Email"]);
                item.Privilege = Convert.ToInt32(datarow["PrivilegeLevel"]);
                item.ID = Convert.ToInt32(datarow["ID"]);
                item.IsActive = Convert.ToBoolean(datarow["IsActive"]);
            }
            return item;
        }

        public void  Update(User user)
        {
            string spName = "updaterecords";
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = spName;
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new MySqlParameter("@Id_", user.ID));
            cmd.Parameters.Add(new MySqlParameter("@Firstname_", user.Firstname));
            cmd.Parameters.Add(new MySqlParameter("@Lastname_", user.Lastname));
            cmd.Parameters.Add(new MySqlParameter("@Username_", user.Username));
            cmd.Parameters.Add(new MySqlParameter("@Userpass_", user.Password));
            cmd.Parameters.Add(new MySqlParameter("@Email_", user.Email));
            cmd.Parameters.Add(new MySqlParameter("@PrivilegeLevel_", user.Privilege));
            cmd.Parameters.Add(new MySqlParameter("@IsActive_", user.IsActive));
            this.ExecuteNonQuery(cmd);
        }

        public void DeleteUserbyID(int ID)
        {
            string spName = "deleteuserbyID";
            MySqlCommand command = new MySqlCommand();
            command.CommandText = spName;
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new MySqlParameter("@ID_", ID));
            ExecuteNonQuery(command);
        }

        public MySqlCommand SelectAllUsers()
        {
            string spName = "selectallusers";
            MySqlCommand command = new MySqlCommand();
            command.CommandText = spName;
            command.CommandType = CommandType.StoredProcedure;
            return command;
        }

        public bool IsUsernameUnique(User user)
        {
            return IsUsernameUnique(user.Username);
        }
    }
}
