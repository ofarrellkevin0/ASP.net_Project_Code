using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TunerDB.RepositoryComponents
{
	public class TunerDatabase : RepositioryManagerClass
	{
		public TunerDatabase(string server, string database, string uid, string password) : base(server, database, uid, password)
		{
			this.InitializeComponents();
		}
		private void InitializeComponents()
		{
			this.userRepository = new UserRepository();
			this.userRepository.RepositioryManager = this;
			this.recordingRepository = new RecordingRepository();
			this.recordingRepository.RepositioryManager = this;
            this.instrumentTunerRepository = new InstrumentTunerRepository();
            this.instrumentTunerRepository.RepositioryManager = this;
            this.instrumentRepository = new InstrumentRepository();
            this.instrumentRepository.RepositioryManager = this;
            this.noteRepository = new NoteRepository();
            this.noteRepository.RepositioryManager = this;
        }

		public UserRepository UserRepository
		{
			get { return this.userRepository; }
		}

		public RecordingRepository RecordingRepository
		{
			get { return this.recordingRepository; }
		}

        public InstrumentTunerRepository InstrumentTunerRepository
        {
            get { return this.instrumentTunerRepository; }
        }

        public InstrumentRepository InstrumentRepository
        {
            get { return this.instrumentRepository; }
        }

        public NoteRepository NoteRepository
        {
            get { return this.noteRepository; }
        }


        public User UserLogin(String Username, String Password)
		{
			return this.userRepository.Login(Username, Password);
		}
		public User LoginActive(String Username, String Password)
		{
			return this.userRepository.LoginActive(Username, Password);
		}

		private UserRepository userRepository;
		private RecordingRepository recordingRepository;
        private InstrumentTunerRepository instrumentTunerRepository;
        private InstrumentRepository instrumentRepository;
        private NoteRepository noteRepository;
    }
}
