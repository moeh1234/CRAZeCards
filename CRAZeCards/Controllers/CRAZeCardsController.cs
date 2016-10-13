using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRAZeCards.Models;

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
        public ActionResult SendCard(string holidayId)
        {
            HolidayEntity entity = new HolidayEntity();
            HOLIDAY holiday = entity.HOLIDAYS.Single(x => x.Holiday_Id == holidayId);
            return View(holiday);
        }
    }
}