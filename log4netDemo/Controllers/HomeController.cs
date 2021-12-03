using log4net;
using System;
using System.Web.Mvc;

namespace log4netDemo.Controllers
{
    public class HomeController : Controller
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ActionResult Index()
        {
            dynamic debug = new { id = 1, MEssage = "Debug" };
            log.Debug(debug);

            dynamic info = new { id = 2, MEssage = "Info" };
            log.Info(info);

            dynamic warn = new { id = 3, MEssage = "Warn" };
            log.Warn(warn);

            try
            {
                throw new Exception("throw new exception");
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }

            return View();
        }

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