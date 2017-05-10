//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net.Http;
//using System.Text;
//using System.Threading.Tasks;

//namespace TunerDB.RepositoryComponents
//{
//    class RecordingUpload
//    {
//        public HttpResponseMessage Post()
//        {
//            var httpRequest = HttpContext.Current.Request;
//            if (httpRequest.Files.Count > 0)
//            {
//                foreach (string file in httpRequest.Files)
//                {
//                    var postedFile = httpRequest.Files[file];
//                    var filePath = HttpContext.Current.Server.MapPath("~/" + postedFile.FileName);
//                    postedFile.SaveAs(filePath);
//                    // NOTE: To store in memory use postedFile.InputStream
//                }

//                return Request.CreateResponse(HttpStatusCode.Created);
//            }

//            return Request.CreateResponse(HttpStatusCode.BadRequest);
//        }
//    }
//}
