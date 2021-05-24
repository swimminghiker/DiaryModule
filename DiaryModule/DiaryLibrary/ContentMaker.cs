using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryLibrary
{
    public static class ContentMaker
    {
        public static List<string> CreateLegend(List<string> slist)
        {
            slist.Add("- Events");
            slist.Add("# Thoughts");
            slist.Add("+ Action Items");
            slist.Add("");
            return slist;
        }

        public static List<string> CreateDateHeader(List<string> slist, DateTime specifiedMonth)
        {
            int daysInGivenMonth = DateTime.DaysInMonth(specifiedMonth.Year, specifiedMonth.Month);
            string specWeekday = specifiedMonth.ToString("dddd");
            string specMonth = specifiedMonth.ToString("MMMM");
            string specYear = specifiedMonth.ToString("yyyy");

            for (int i = 1; i <= daysInGivenMonth ; i++)
            {
                slist.Add(specWeekday + ", " + specMonth + " " + i.ToString() + " " + specYear);
                slist.Add("===========================");
                slist.Add("");
                specWeekday = specifiedMonth.AddDays(i).ToString("dddd");
            }
            return slist;
        }

    }
}


