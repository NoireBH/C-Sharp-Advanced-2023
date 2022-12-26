using System;
using System.Collections.Generic;
using System.Text;

namespace DataModifier
{
    public class DateModifier
    {
        private int dayDifference;

        public int DayDifference
        {
            get { return dayDifference; }
            set { dayDifference = value; }
        }

        public int GetDifferenceInDays(string firstDateInfo, string secondDateInfo)
        {
            string[] arrayOfFirstDate = firstDateInfo.Split();
            int firstDateYear = int.Parse(arrayOfFirstDate[0]);
            int firstDateMonth = int.Parse(arrayOfFirstDate[1]);
            int firstDateDay = int.Parse(arrayOfFirstDate[2]);
            
            string[] arrayOfSecondDate = secondDateInfo.Split();
            int SecondDateYear = int.Parse(arrayOfSecondDate[0]);
            int SecondDateMonth = int.Parse(arrayOfSecondDate[1]);
            int SecondDateDay = int.Parse(arrayOfSecondDate[2]);

            var firstDate = new DateTime(firstDateYear, firstDateMonth, firstDateDay);

            var secondDate = new DateTime(SecondDateYear , SecondDateMonth, SecondDateDay);

            DayDifference = Math.Abs((int)(firstDate.Date - secondDate.Date).TotalDays);

            return DayDifference;
        }
    }
}
