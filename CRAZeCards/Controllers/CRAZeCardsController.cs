using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRAZeCards.Models;
using RestSharp;
using RestSharp.Authenticators;

namespace CRAZeCards.Controllers
{
    public class CRAZeCardsController : Controller
    {
        // GET: CRAZeCards
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult SelectCard(string Month)
        {
          MonthRepository allMonths = new MonthRepository();
          Month jan=  allMonths.GetMonthFromString(Month);

            return View(jan);
        }
<<<<<<< HEAD
        public ActionResult ViewGodDay()
        {
            return View();
        }
=======
>>>>>>> origin/master
        [HttpGet]
        public ActionResult SendCard(string holidayId, string imgUrl)
        {
            HolidayEntity entity = new HolidayEntity();
<<<<<<< HEAD
           HOLIDAY holiday = entity.HOLIDAYS.Single(x => x.Holiday_Id == holidayId);

            return View(holiday);
        }
        [HttpPost]
        public ActionResult SendCard(FormCollection form)
        {
            string toEMAIL = form["toemail"];
            SendSimpleMessage(toEMAIL);
            return View("MessageSent");
        }


        public static IRestResponse SendSimpleMessage(string email)
        {
            RestClient client = new RestClient();
            client.BaseUrl = new Uri("https://api.mailgun.net/v3");
            client.Authenticator =
                    new HttpBasicAuthenticator("api",
                                               "key-5a66becd274a49eba1921a2545080bb1");
            RestRequest request = new RestRequest();
            request.AddParameter("domain",
                                 "YOUR_DOMAIN_NAME", ParameterType.UrlSegment);
            request.Resource = "{domain}/messages";
            request.AddParameter("from", "_Name_ <donotreply@carzyeCards.org>");
            request.AddParameter("to", email);
            request.AddParameter("subject", "Hello");
            request.AddParameter("text", "Testing some Mailgun awesomness!");
            request.Method = Method.POST;
            return client.Execute(request);
        }
=======
            HOLIDAY holiday = entity.HOLIDAYS.Single(x => x.Holiday_Id == holidayId);
            return View(holiday);
        }
>>>>>>> origin/master
    }
}