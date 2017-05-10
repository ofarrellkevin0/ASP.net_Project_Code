using MySql.Data.MySqlClient;
using System.Data;

namespace TunerDB.RepositoryComponents
{
    public class InstrumentRepository : RepositioryBaseClass
    {
        public void CreateInstrument (string name, string type, int id)
        {
                string spName = "createinstrument";
                MySqlCommand command = new MySqlCommand();
                command.CommandText = spName;
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new MySqlParameter("@Users_ID_", id));
                command.Parameters.Add(new MySqlParameter("@Name_", name));
                command.Parameters.Add(new MySqlParameter("@Type_", type));
                this.ExecuteNonQuery(command);
        }

        public void UpdateInstrument (int ID, string GuitarName, string GuitarType)
        {
                string spName = "updateinstrument";
                MySqlCommand command = new MySqlCommand();
                command.CommandText = spName;
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new MySqlParameter("@ID_", ID));
                command.Parameters.Add(new MySqlParameter("@Name_", GuitarName));
                command.Parameters.Add(new MySqlParameter("@Type_", GuitarType));
                ExecuteNonQuery(command);
        }

        public void DeleteInstrument (int ID)
        {
                string spName = "deleteinstrument";
                MySqlCommand command = new MySqlCommand();
                command.CommandText = spName;
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new MySqlParameter("@ID_", ID));
                ExecuteNonQuery(command);
        }

        public MySqlCommand SelectAllInstruments()
        {
            string spName = "selectallinstruments";
            MySqlCommand command = new MySqlCommand();
            command.CommandText = spName;
            command.CommandType = CommandType.StoredProcedure;
            return command;
        }

        public MySqlCommand SelectInstrument(int ID, User user)
        {
            string spName = "selectinstrument";
            MySqlCommand command = new MySqlCommand();
            command.CommandText = spName;
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new MySqlParameter("@Users_ID_", ID));
            return command;
        }

        public MySqlCommand SelectInstrumentListBox(int ID)
        {
            string spName = "selectinstrumentlistbox";
            MySqlCommand command = new MySqlCommand();
            command.CommandText = spName;
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new MySqlParameter("@Users_ID_", ID));
            return command;
        }

        public MySqlCommand TuningRecords()
        {
            string spName = "TuningRecords";
            MySqlCommand command = new MySqlCommand();
            command.CommandText = spName;
            command.CommandType = CommandType.StoredProcedure;
            return command;
        }

    }
}
