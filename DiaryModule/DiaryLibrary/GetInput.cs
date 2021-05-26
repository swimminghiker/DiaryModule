﻿using System;
using System.Globalization;

namespace DiaryLibrary
{
    public class GetInput
    {
        public static DateTime Get2DigitMonth()
        {
            int imUserInput;
            string inputedMonth;
            try
            {
                while (true)
                {
                    Console.WriteLine("Please enter 2 digit for the month: 01 for January and 12 for December");
                    Console.WriteLine("Press 'Enter' without making selection defaults to the current month");
                    inputedMonth = Console.ReadLine();
                    if (inputedMonth == "") { return new DateTime(DateTime.Now.Year, DateTime.Now.Month, 01, new GregorianCalendar()); }
                    if (inputedMonth.Length == 2 && Int32.TryParse(inputedMonth, out imUserInput) && imUserInput <= 12 && imUserInput >=1) { break; }
                }
                DateTime specifiedMonth = new DateTime(DateTime.Now.Year, int.Parse(imUserInput.ToString()), 01, new GregorianCalendar());
                return specifiedMonth;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return default;
            }
        }
        
    }

   
}
