using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CloudPlayerKuhn.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
          return View();
        }
        /*
        public FileResult DownloadFile(string fileId)
        {
            DriveService service = Session["service"] as DriveService;
            Google.Apis.Drive.v2.Data.File file = service.Files.Get(fileId).Fetch();
            System.IO.Stream data = new GDriveRepository(Utils.ReturnIAuth((GoogleAuthenticator)Session["Gauthenticator"])).DownloadFile(file.DownloadUrl);

            return File(data, System.Net.Mime.MediaTypeNames.Application.Octet, file.Title);
        }
        */

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}