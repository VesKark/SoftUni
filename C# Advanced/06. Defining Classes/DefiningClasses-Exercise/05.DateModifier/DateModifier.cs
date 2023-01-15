using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace _05.DateModifier
{
    public class DateModifier
    {
        private string dateA;
        private string dateB;

        public string DateA { get; set; }
        public string DateB { get; set; }

        public DateModifier(string dateA, string dateB)
        { 
            DateA = dateA;
            DateB = dateB;
        }

        public int DateDiff()
        {
            DateTime dtA = DateTime.ParseExact(DateA, "yyyy MM dd", CultureInfo.InvariantCulture);
            DateTime dtB = DateTime.ParseExact(DateB, "yyyy MM dd", CultureInfo.InvariantCulture);
            return Math.Abs((dtA - dtB).Days);
        }
    }
}
