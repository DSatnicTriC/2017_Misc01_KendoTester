using System.Web.Mvc;
using DanielWebApp02.Models;
using System;
using System.Globalization;

namespace DanielWebApp02.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult CompareDate(CompareDateModel requestedDate)
        {
            bool result = requestedDate.ClientDate.ToLocalTime().Date == DateTime.Now.Date;
            string resultMessage = 
                result 
                    ? "You have chosen wisely" 
                    : "You have chosen poorly.  It ain't " 
                        + DateTimeFormatInfo.CurrentInfo.GetMonthName(requestedDate.ClientDate.Month) 
                        + " " 
                        + requestedDate.ClientDate.Day;
            var json = new { Success = true, Message = resultMessage };
            return Json(json);
        }
    }
}