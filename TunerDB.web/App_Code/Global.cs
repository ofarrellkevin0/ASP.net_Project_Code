using System;
using System.Configuration;
using TunerDB.RepositoryComponents;
using System.Web;

public class Global : HttpApplication
{
	private static TunerDatabase tunerDB;
	private static bool tunerdbIsNull = true;

	private static TunerDatabase CreateTunerDB()
	{

		String database = ConfigurationManager.AppSettings["db"];
		String server = ConfigurationManager.AppSettings["dbserver"];
		String uid = ConfigurationManager.AppSettings["dbuid"];
		String password = ConfigurationManager.AppSettings["dbpassword"];
		TunerDatabase tunerdb = new TunerDatabase(server, database, uid, password);
		return tunerdb;

	}

	public static TunerDatabase TunerDB

	{
		get
		{
			if(Global.tunerdbIsNull)
			{
				tunerDB = Global.CreateTunerDB();
			}
			return Global.tunerDB;

		}
	}


	public Global()
	{
	}
}