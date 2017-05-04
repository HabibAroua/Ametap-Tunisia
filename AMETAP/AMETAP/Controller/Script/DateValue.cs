using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMETAP.Controller.Script
{
    public class DateValue
    {
        private String date;

        public DateValue(String date)
        {
            this.date = date;
        }

        public DateValue()
        {

        }

        public String getDateValue()
        {
            return this.date;
        }

        public String getDay()
        {
            return getDateValue().Substring(0,2);
        }

        public String getMonth()
        {
            return getDateValue().Substring(3,2);
        }

        public String getYear()
        {
            return getDateValue().Substring(6,4);
        }

        public String getToday()
        {
            DateTime thisDay = DateTime.Today;
            Console.WriteLine(thisDay.ToString("d"));
            return thisDay.ToString("d");
        }

        public String getDayToday()
        {
            return getToday().Substring(0, 2);
        }

        public String getMonthToday()
        {
            return getToday().Substring(3, 2);
        }

        public String getYearToday()
        {
            return getToday().Substring(6, 4);
        }
    }
}
