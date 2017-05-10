using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace TunerDB.RepositoryComponents
{
	public class RecordingRepository : RepositioryBaseClass
	{

		public Recording GetByID(int ID)
		{
			string spName = "downloadrecording";
			MySqlCommand cmd = new MySqlCommand();

			cmd.CommandText = spName;
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add(new MySqlParameter("@ID_", ID));
			DataRow datarow = this.OneDataRow(cmd);
			Recording recording = new Recording();

			recording.ID = ID;
			recording.UserID = Convert.ToInt32(datarow[1]);
			recording.RecordingName = Convert.ToString(datarow["RecordingName"]);
            recording.Data = (Byte[])datarow["Data"];
			recording.TimeStamp = Convert.ToDateTime(datarow["TimeStamp"]);

			return recording;
        }

		public void Create(Recording item)
		{
			string spName = "insertrecordings";
			MySqlCommand command = new MySqlCommand();

			command.CommandText = spName;
			command.CommandType = CommandType.StoredProcedure;

			MySqlParameter fileNameParameter = new MySqlParameter("?RecordingName_", MySqlDbType.VarChar, 45);
			MySqlParameter fileSizeParameter = new MySqlParameter("?Users_ID_", MySqlDbType.Int32, 10);
			MySqlParameter fileContentParameter = new MySqlParameter("?Data_", MySqlDbType.LongBlob, item.Data.Length);

			fileNameParameter.Value = item.RecordingName;
			fileSizeParameter.Value = item.UserID;
			fileContentParameter.Value = item.Data;

			command.Parameters.Add(fileNameParameter);
			command.Parameters.Add(fileSizeParameter);
			command.Parameters.Add(fileContentParameter);

			this.ExecuteNonQuery(command);
        }

        public void DeleteRecording(int ID)
        {
            string spName = "deleterecording";
            MySqlCommand command = new MySqlCommand();
            command.CommandText = spName;
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new MySqlParameter("@ID_", ID));
            ExecuteNonQuery(command);
        }

        public void UpdateRecordingName(int ID, string RecordingName)
        {
            string spName = "updaterecordingname";
            MySqlCommand command = new MySqlCommand();
            command.CommandText = spName;
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new MySqlParameter("@RecordingName_", RecordingName));
            command.Parameters.Add(new MySqlParameter("@ID_", ID));
            ExecuteNonQuery(command);
        } 

        public MySqlCommand SelectallRecordings()
        {
            string spName = "selectallrecordings";
            MySqlCommand command = new MySqlCommand();
            command.CommandText = spName;
            command.CommandType = CommandType.StoredProcedure;
            return command;
        }

        public MySqlCommand SelectRecording(int ID)
        {
                string spName = "selectrecording";
                MySqlCommand command = new MySqlCommand();
                command.CommandText = spName;
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new MySqlParameter("@Users_ID_", ID));
                return command;
        }

    }


}
