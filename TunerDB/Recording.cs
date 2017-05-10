using System;

namespace TunerDB
{
    public class Recording
    {
		public Recording ()
		{
			this.TimeStamp = DateTime.Now;
		}
		public DateTime TimeStamp
        {
            get; set;
        }
        public int ID
        {
            get; set;
        }
        public int UserID
        {
            get; set;
        }
        public string RecordingName
        {
            get; set;
        }
        public byte [] Data
        {
            get; set;
        }
    }
}
