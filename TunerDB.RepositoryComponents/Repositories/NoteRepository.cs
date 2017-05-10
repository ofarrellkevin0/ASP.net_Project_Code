using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace TunerDB.RepositoryComponents
{
    public class NoteRepository : RepositioryBaseClass
    {

        public MySqlCommand SelectNotes ()
        {
            string spName = "SelectNotes";
            MySqlCommand command = new MySqlCommand();
            command.CommandText = spName;
            command.CommandType = CommandType.StoredProcedure;
            return command;
        }

    }
}
