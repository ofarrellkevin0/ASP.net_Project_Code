namespace TunerDB
{
    public class User
    {
        public string Username
        {
            get; set;
        }
        public string Password
        {
            get; set;
        }
        public string Email
        {
            get; set;
        }
        public string Firstname
        {
            get; set;
        }
        public string Lastname
        {
            get; set;
        }
        public int Privilege
        {
            get; set;
        }
        public int ID
        {
            get; set;
        }
        public bool IsAdmin()
        {
            return this.Privilege == 1;
        }
        public bool IsActive
        {
            get; set;
        }
    }
}
