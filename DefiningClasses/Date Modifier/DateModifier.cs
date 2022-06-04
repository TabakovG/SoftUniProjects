using System;
using System.Linq;

namespace DateModifier
{
    public class DateModifier
    {
        private DateTime startDate;

        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        private DateTime endDate;

        public DateTime EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }

        public int GetDifference(string startDate, string endDate)
        { 
            

            int[] start = startDate.Split(' ').Select(int.Parse).ToArray();
            int[] end = endDate.Split(' ').Select(int.Parse).ToArray();

            int sYear = start[0];
            int sMonth = start[1];
            int sDay = start[2];

            int eYear = end[0];
            int eMonth = end[1];
            int eDay = end[2];


            DateTime sDate = new DateTime(sYear, sMonth, sDay);
            this.StartDate = sDate;
            DateTime eDate = new DateTime(eYear, eMonth, eDay);
            this.EndDate = eDate;
            return (int)(EndDate - StartDate).TotalDays;


        }


    }
}
