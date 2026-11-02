using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryLibrary
{
    public enum JapDaysOfMonth
    {
        ついたち = 1,
        ふつか = 2,
        みっか = 3,
        よっか = 4,
        いつか = 5,
        むいか = 6,
        なのか = 7,
        ようか = 8,
        ここのか = 9,
        とおか = 10,
        じゅういちにち = 11,
        じゅうににち = 12,
        じゅうさんにち = 13,
        じゅうよっか = 14,
        じゅうごにち = 15,
        じゅうろくにち = 16,
        じゅうしちにち = 17,
        じゅうはちにち = 18,
        じゅうくにち = 19,
        はつか = 20,
        にじゅういちにち = 21,
        にじゅうににち = 22,
        にじゅうさんにち = 23,
        にじゅうよっか = 24,
        にじゅうごにち = 25,
        にじゅうろくにち = 26,
        にじゅしちにち = 27,
        にじゅうはちにち = 28,
        にじゅうくにち = 29,
        さんじゅうにち = 30,
        さんじゅういちにち = 31
    }

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
                //slist.Add(specWeekday + ", " + specMonth + " " + i.ToString() + " " + specYear);
                slist.Add(specWeekday + ", " + specMonth + " " + i.ToString() + " (" + (JapDaysOfMonth)i + ") " + specYear);
                slist.Add("=====================================");
                slist.Add("");
                specWeekday = specifiedMonth.AddDays(i).ToString("dddd");
            }
            return slist;
        }

    }
}


