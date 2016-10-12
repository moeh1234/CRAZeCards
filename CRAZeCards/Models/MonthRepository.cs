using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRAZeCards.Models
{
    public class MonthRepository
    {
        public Month GetMonthFromString(string month)
        {
            if (month == "January")
            {
                Month month1 = new Month();
                month1.Name = "January";

                HolidayEntity holidayentity = new HolidayEntity();
                List<HOLIDAY> holidays = holidayentity.HOLIDAYS.Where(x => x.Holiday_Month == "jan").ToList();


                month1.Holidays = holidays;

                return month1;
            }
            if (month == "February")
            {
                Month month2 = new Month();
                month2.Name = "February";

                HolidayEntity holidayentity = new HolidayEntity();
                List<HOLIDAY> holidays = holidayentity.HOLIDAYS.Where(x => x.Holiday_Month == "feb").ToList();


                month2.Holidays = holidays;

                return month2;
            }
            if (month == "March")
            {
                Month month3 = new Month();
                month3.Name = "March";

                HolidayEntity holidayentity = new HolidayEntity();
                List<HOLIDAY> holidays = holidayentity.HOLIDAYS.Where(x => x.Holiday_Month == "mar").ToList();


                month3.Holidays = holidays;

                return month3;
            }
            if (month == "April")
            {
                Month month4 = new Month();
                month4.Name = "April";

                HolidayEntity holidayentity = new HolidayEntity();
                List<HOLIDAY> holidays = holidayentity.HOLIDAYS.Where(x => x.Holiday_Month == "apr").ToList();


                month4.Holidays = holidays;

                return month4;
            }
            if (month == "May")
            {
                Month month5 = new Month();
                month5.Name = "May";

                HolidayEntity holidayentity = new HolidayEntity();
                List<HOLIDAY> holidays = holidayentity.HOLIDAYS.Where(x => x.Holiday_Month == "may").ToList();


                month5.Holidays = holidays;

                return month5;
            }
            return null;
        }
    }
}