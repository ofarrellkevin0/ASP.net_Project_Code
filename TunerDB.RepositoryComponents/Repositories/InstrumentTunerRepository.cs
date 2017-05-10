using MySql.Data.MySqlClient;
using System;
using System.Data;


namespace TunerDB.RepositoryComponents
{
    public class InstrumentTunerRepository : RepositioryBaseClass
    {

        public void LogNotes (string list1, string list2, string list3, string list4, string list5, string list6, string ID)
        { 
            String spName = "Lognotes";
            MySqlCommand command = new MySqlCommand();
            command.CommandText = spName;
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new MySqlParameter("@Instrument_ID_", Int32.Parse(ID)));
            command.Parameters.Add(new MySqlParameter("@FirstString_", Int32.Parse("1")));
            command.Parameters.Add(new MySqlParameter("@FirstStringNote_", (list1)));

            command.Parameters.Add(new MySqlParameter("@SecondString_", Int32.Parse("2")));
            command.Parameters.Add(new MySqlParameter("@SecondStringNote_", (list2)));

            command.Parameters.Add(new MySqlParameter("@ThirdString_", Int32.Parse("3")));
            command.Parameters.Add(new MySqlParameter("@ThirdStringNote_",  (list3)));

            command.Parameters.Add(new MySqlParameter("@FourthString_", Int32.Parse("4")));
            command.Parameters.Add(new MySqlParameter("@FourthStringNote_", (list4)));

            command.Parameters.Add(new MySqlParameter("@FifthString_", Int32.Parse("5")));
            command.Parameters.Add(new MySqlParameter("@FifthStringNote_",  (list5)));

            command.Parameters.Add(new MySqlParameter("@SixthString_", Int32.Parse("6")));
            command.Parameters.Add(new MySqlParameter("@SixthStringNote_",  (list6)));
            ExecuteNonQuery(command);
        }

        public MySqlCommand SelectTuningRecords(int id)
        {
            string spName = "Selecttunings";
            MySqlCommand command = new MySqlCommand();
            command.CommandText = spName;
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new MySqlParameter("@Users_ID_", id));
            return command;
        }

        public void lognotes2 (long ID)
        {
            String spName = "createinstrument2";
            MySqlCommand command = new MySqlCommand();
            command.CommandText = spName;
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new MySqlParameter("@Instrument_ID_", Convert.ToInt16(ID)));
            this.ExecuteNonQuery(command);
        }
    }
}
