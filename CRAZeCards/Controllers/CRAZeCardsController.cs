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
        [HttpGet]
        public ActionResult SendCard(string holidayId, string imgUrl)
        {
            HolidayEntity entity = new HolidayEntity();
           HOLIDAY holiday = entity.HOLIDAYS.Single(x => x.Holiday_Id == holidayId);

            return View(holiday);
        }
        [HttpPost]
        public ActionResult SendCard(FormCollection form)
        {
            string toEMAIL = form["toemail"];
            string subject = form["subject"];
            string yourName = form["yourname"];
            string message = form["message"];
            string hiddenId = form["hiddenid"];
            IRestResponse response = SendSimpleMessage(toEMAIL, subject, yourName, message, hiddenId);

            return View("MessageSent");
        }

        public static IRestResponse SendSimpleMessage(string email, string subject, string yourname, string message, string hiddenId)
        {
            RestClient client = new RestClient();
            client.BaseUrl = new Uri("https://api.mailgun.net/v3");
            client.Authenticator =
                    new HttpBasicAuthenticator("api",
                                               "key-a13e230e7ba7be810d04ebaba1b72574");
            RestRequest request = new RestRequest();
            request.AddParameter("domain",
                                 "sandbox72fcdacea882400d8b44f1952838a66e.mailgun.org", ParameterType.UrlSegment);
            request.Resource = "{domain}/messages";
            request.AddParameter("from", "(test) <excited@sandbox72fcdacea882400d8b44f1952838a66e.mailgun.org>");
            request.AddParameter("to", email);
            request.AddParameter("subject", subject);
            request.AddParameter("html", "<html><body><div>" + (message) + "<img src="+(hiddenId)+"/></div></body></html>");
            request.Method = Method.POST;
            return client.Execute(request);
        }
    }
}