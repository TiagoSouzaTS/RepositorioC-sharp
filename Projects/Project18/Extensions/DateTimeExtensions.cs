using System;
using System.Globalization;

namespace Project18.Extensions {
    internal static class DateTimeExtensions { 

        public static string ElapsedTime(this DateTime thisObj) { // Método de extensão do struct DateTime. 

            TimeSpan duration = DateTime.Now.Subtract(thisObj);
            if (duration.TotalHours < 24.0) {
                
                return ($"{duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture)} hours");
            }
            else {

                return ($"{duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture)} days");
            }
        }
    }
}
