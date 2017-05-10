using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace TunerDB.RepositoryComponents
{

	public class RepositioryBaseClass
	{
		public TunerDatabase RepositioryManager
		{ get; set; }

		public void ExecuteNonQuery(IDbCommand cmd)
		{
            try {
                if (this.RepositioryManager.OpenConnection() == true)
                {
                    this.RepositioryManager.SetCommandConnection(cmd);
                    cmd.ExecuteNonQuery();
                    this.RepositioryManager.CloseConnection();
                }
            }
            catch (Exception e)
            {
                throw (e);
            }
		}

		public DataTable DataTable(IDbCommand command)
		{
			String defaultTableName = "DataTable";
			return this.DataTable(command, defaultTableName);
		}

		public DataTable DataTable(IDbCommand command, String tableName)
		{
			MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
			DataTable dataTable = new DataTable(tableName);
			this.RepositioryManager.SetCommandConnection(command);
			dataAdapter.SelectCommand = (MySqlCommand)command;
			Exception exception = null;

			try
			{
				this.RepositioryManager.OpenConnection();
				try
				{
					dataAdapter.Fill(dataTable);
				}
				catch (Exception e)
				{
					exception = new Exception("Error filling Datatable<br/>" + Environment.NewLine +
						e.Message + "<br/>" + Environment.NewLine
						+ command.CommandText + Environment.NewLine);
					exception.Source = e.Message;
					throw (exception);
				}
			}
			catch (Exception e)
			{
				if (e == exception)
				{
					throw (e);
				}
				else
				{
					exception = new Exception("Error opening Connection<br/>" + Environment.NewLine +
						e.Message + "<br/>" + Environment.NewLine +
						command.CommandText + "<br/>" + Environment.NewLine);
					exception.Source = e.Message;
					throw (exception);
				}
			}
			return dataTable;
		}

		public DataRow OneDataRow(IDbCommand command)
		{
            try {
                DataTable dataTable = DataTable(command);
                if (dataTable.Rows.Count != 0)
                {
                    return dataTable.Rows[0];
                }
                return null;
            }
    
            catch (Exception e)
            {
                throw (e);
            }
		}
    
		public int Count(IDbCommand command)
		{
            try {
                int count = 0;
                if (this.RepositioryManager.OpenConnection() == true)
                {
                    this.RepositioryManager.SetCommandConnection(command);
                    count = Convert.ToInt32(command.ExecuteScalar());
                    this.RepositioryManager.CloseConnection();
                    return count;
                }
                else
                {
                    return count;
                }
            }
            catch (Exception e)
            {
                throw (e);
            }
		}
	}
}