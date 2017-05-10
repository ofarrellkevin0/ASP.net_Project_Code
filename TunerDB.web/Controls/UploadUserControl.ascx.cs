using System;
using System.IO;
using TunerDB;

public partial class Controls_UploadUserControl : System.Web.UI.UserControl
{



    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void uploading_Click(object sender, EventArgs e)
    {
        if (fileupload.HasFile)
        {
            String extention = Path.GetExtension(fileupload.FileName);
            if (IsAudioFile(extention) == true)
            {
                User user = (User)this.Session["User"];
                byte[] rawData = fileupload.FileBytes;

                Recording item = new Recording();
                item.Data = rawData;
                item.UserID = user.ID;
                item.RecordingName = fileupload.FileName;
                Global.TunerDB.RecordingRepository.Create(item);
            }
            else
            {
                extentions.Text = "File Format not accepted";
            }

        }
    }

    static string[] mediaExtensions = { ".WAV", ".MP3" };
    static bool IsAudioFile(string path)
    {
        return -1 != Array.IndexOf(mediaExtensions, 
            Path.GetExtension(path).ToUpperInvariant());
    }

}