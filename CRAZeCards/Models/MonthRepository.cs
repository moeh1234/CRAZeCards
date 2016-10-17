using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRAZeCards.Models
{
    public class MonthRepository
    {

        private CrazEcardsEntities entity;
        public MonthRepository()
        {
            entity = new CrazEcardsEntities();
        }
        public Month GetMonthFromString(string month)
        {
            if (month == "January")
            {
                Month month1 = new Month();
                month1.Name = "January";
                List<HOLIDAY> holidays = entity.HOLIDAYS.Where(x => x.Holiday_Month == "jan").ToList();


                month1.Holidays = holidays;

                return month1;
            }
            if (month == "February")
            {
                Month month2 = new Month();
                month2.Name = "February";

                List<HOLIDAY> holidays = entity.HOLIDAYS.Where(x => x.Holiday_Month == "feb").ToList();


                month2.Holidays = holidays;

                return month2;
            }
            if (month == "March")
            {
                Month month3 = new Month();
                month3.Name = "March";

                List<HOLIDAY> holidays = entity.HOLIDAYS.Where(x => x.Holiday_Month == "mar").ToList();


                month3.Holidays = holidays;

                return month3;
            }
            if (month == "April")
            {
                Month month4 = new Month();
                month4.Name = "April";

                List<HOLIDAY> holidays = entity.HOLIDAYS.Where(x => x.Holiday_Month == "apr").ToList();


                month4.Holidays = holidays;

                return month4;
            }
            if (month == "May")
            {
                Month month5 = new Month();
                month5.Name = "May";

                List<HOLIDAY> holidays = entity.HOLIDAYS.Where(x => x.Holiday_Month == "may").ToList();


                month5.Holidays = holidays;

                return month5;
            }
            if (month == "June")
            {
                Month month6 = new Month();
                month6.Name = "june";

                List<HOLIDAY> holidays = entity.HOLIDAYS.Where(x => x.Holiday_Month == "jun").ToList();


                month6.Holidays = holidays;

                return month6;
            }
            if (month == "July")
            {
                Month month7 = new Month();
                month7.Name = "July";

                 List<HOLIDAY> holidays = entity.HOLIDAYS.Where(x => x.Holiday_Month == "jul").ToList();


                month7.Holidays = holidays;

                return month7;
            }
            if (month == "August")
            {
                Month month8 = new Month();
                month8.Name = "August";

               List<HOLIDAY> holidays = entity.HOLIDAYS.Where(x => x.Holiday_Month == "aug").ToList();


                month8.Holidays = holidays;

                return month8;
            }
            if (month == "September")
            {
                Month month9 = new Month();
                month9.Name = "September";

                List<HOLIDAY> holidays = entity.HOLIDAYS.Where(x => x.Holiday_Month == "sep").ToList();


                month9.Holidays = holidays;

                return month9;
            }
            if (month == "October")
            {
                Month month10 = new Month();
                month10.Name = "October";

                List<HOLIDAY> holidays = entity.HOLIDAYS.Where(x => x.Holiday_Month == "oct").ToList();


                month10.Holidays = holidays;

                return month10;
            }
            if (month == "November")
            {
                Month month11 = new Month();
                month11.Name = "November";

                List<HOLIDAY> holidays = entity.HOLIDAYS.Where(x => x.Holiday_Month == "nov").ToList();


                month11.Holidays = holidays;

                return month11;
            }
            if (month == "December")
            {
                Month month12 = new Month();
                month12.Name = "December";

                List<HOLIDAY> holidays = entity.HOLIDAYS.Where(x => x.Holiday_Month == "dec").ToList();


                month12.Holidays = holidays;

                return month12;
            }
            return null;
        }
    }
}