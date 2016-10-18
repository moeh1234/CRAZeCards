using System.Linq;
using System.Web.Mvc;
using CRAZeCards.Models;
using System.Net.Mail;

namespace CRAZeCards.Controllers
{
    public class CRAZeCardsController : Controller
    {
        private CrazEcardsEntities entity;
        public CRAZeCardsController()
        {
             entity = new CrazEcardsEntities();
        }
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
            string hiddenView = form["hiddenView"];
            string hiddenId = form["hiddenId"];
            //IRestResponse response = SendSimpleMessage(toEMAIL, subject, yourName, message, hiddenView,hiddenId);
            System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
            mail.From = new MailAddress("crazecards@gmail.com", yourName);
            mail.To.Add(toEMAIL);
            mail.IsBodyHtml = true;
            mail.Subject = subject;
            mail.Body = "<html><body><div>" + (message) + "<img src=" + (hiddenView) + "/></div></body></html>";
            mail.Priority = MailPriority.High;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            //smtp.UseDefaultCredentials = true;
            smtp.Credentials = new System.Net.NetworkCredential("crazecards@gmail.com", "ecoders1234");
            smtp.EnableSsl = true;
            //smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Send(mail);
            entity.USER_RESPONSE_INDEX.Add(new USER_RESPONSE_INDEX() { Track_Id= hiddenId });
            entity.SaveChanges();
            
            return View("MessageSent");
        }

        //public static IRestResponse SendSimpleMessage(string email, string subject, string yourname, string message, string hiddenView,string hiddenId)
        //{
        //    RestClient client = new RestClient();
        //    client.BaseUrl = new Uri("https://api.mailgun.net/v3");
        //    client.Authenticator =
        //            new HttpBasicAuthenticator("api",
        //                                       "key-a13e230e7ba7be810d04ebaba1b72574");
        //    RestRequest request = new RestRequest();
        //    request.AddParameter("domain",
        //                         "sandbox72fcdacea882400d8b44f1952838a66e.mailgun.org", ParameterType.UrlSegment);
        //    request.Resource = "{domain}/messages";
        //    request.AddParameter("from", "" + yourname + " <excited@sandbox72fcdacea882400d8b44f1952838a66e.mailgun.org>");
        //    request.AddParameter("to", email);
        //    request.AddParameter("subject", subject);
        //    request.AddParameter("html", "<html><body><div>" + (message) + "<img src="+(hiddenView)+"/></div></body></html>");
        //    request.Method = Method.POST;
        //    return client.Execute(request);
        //}
    }
}