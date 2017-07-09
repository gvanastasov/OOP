using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public static class DateModifier
    {
        public static int DaysDifference(string dateStringOne, string dateStringTwo)
        {
            DateTime dateOne = DateTime.ParseExact(dateStringOne, "yyyy MM dd", System.Globalization.CultureInfo.InvariantCulture);

            DateTime dateTwo = DateTime.ParseExact(dateStringTwo, "yyyy MM dd", System.Globalization.CultureInfo.InvariantCulture);

            return (dateOne - dateTwo).Days;
        }
    }
}
