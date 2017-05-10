using System;
using System.Diagnostics;
using System.IO;
using MySql.Data.MySqlClient;
using System.Data;

namespace TunerDB.RepositoryComponents
{
    public class RepositioryManagerClass
	{
        public RepositioryManagerClass(string server, string database, string uid, string password)
		{
			Initialize(server, database, uid, password);
		}

		protected void Initialize(string server, string database, string uid, string password)
		{
			this.server = server;
			this.database = database;
			this.uid = uid;
			this.password = password;
			this.Initialize();
		}
		protected void Initialize()
		{
			String connectionString = "SERVER=" + server + ";" + 
                "DATABASE=" + database + ";" + "UID=" + uid + ";"
                + "PASSWORD=" + password + ";";

			Initialize(connectionString);
		}
		protected void Initialize(String connectionString)
		{
            try {
                connection = new MySqlConnection(connectionString);
            }
            catch (Exception e)
            {
                throw (e);
            }
		}

		public bool OpenConnection()
		{
			if(this.connection.State == ConnectionState.Open)
				return true;
			try
			{
				connection.Open();
				return true;
			}
			catch(MySqlException ex)
			{
				switch(ex.Number)
				{
					case 0:
						Console.WriteLine("Cannot connect to server.  Contact administrator");
						break;

					case 1045:
						Console.WriteLine("Invalid username/password, please try again");
						break;
				}
				return false;
			}
		}
		public bool CloseConnection()
		{
			if(this.connection.State == ConnectionState.Closed)
				return true;
			try
			{
				connection.Close();
				return true;
			}
			catch(MySqlException ex)
			{
				Console.WriteLine(ex.Message);
				return false;
			}
		}
		public void SetCommandConnection(IDbCommand sqlCommand)
		{
			sqlCommand.Connection = this.connection;
		}
		public void Backup()
		{
			try
			{
				DateTime Time = DateTime.Now;
				int year = Time.Year;
				int month = Time.Month;
				int day = Time.Day;
				int hour = Time.Hour;
				int minute = Time.Minute;
				int second = Time.Second;
				int millisecond = Time.Millisecond;

				//Save file to C:\ with the current date as a filename
				string path;
				path = "C:\\" + year + "-" + month + "-" + day + "-" + hour + "-" + minute + "-" + second + "-" + millisecond + ".sql";
				StreamWriter file = new StreamWriter(path);


				ProcessStartInfo psi = new ProcessStartInfo();
				psi.FileName = "mysqldump";
				psi.RedirectStandardInput = false;
				psi.RedirectStandardOutput = true;
				psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}", uid, password, server, database);
				psi.UseShellExecute = false;

				Process process = Process.Start(psi);

				string output;
				output = process.StandardOutput.ReadToEnd();
				file.WriteLine(output);
				process.WaitForExit();
				file.Close();
				process.Close();
			}
			catch(IOException)
			{
				Console.WriteLine("Error , unable to backup!");
			}
		}
		public void Restore()
		{
			try
			{
				//Read file from C:\
				string path;
				path = "C:\\MySqlBackup.sql";
				StreamReader file = new StreamReader(path);
				string input = file.ReadToEnd();
				file.Close();


				ProcessStartInfo psi = new ProcessStartInfo();
				psi.FileName = "mysql";
				psi.RedirectStandardInput = true;
				psi.RedirectStandardOutput = false;
				psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}", uid, password, server, database);
				psi.UseShellExecute = false;


				Process process = Process.Start(psi);
				process.StandardInput.WriteLine(input);
				process.StandardInput.Close();
				process.WaitForExit();
				process.Close();
			}
			catch(IOException)
			{
				Console.WriteLine("Error , unable to Restore!");
			}
		}

		private MySqlConnection connection;
		private string server;
		private string database;
		private string uid;
		private string password;
}
}
