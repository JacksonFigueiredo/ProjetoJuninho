using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods.Extensions
{
    static class DateTimeExtensions
    {
        public static string ElapsedTime(this DateTime dateTime)
        {
            TimeSpan duration = DateTime.Now.Subtract(dateTime);

            if (duration.TotalHours < 24.0)
            {
                return String.Format("O Tempo Total é {0} Horas", duration);
            }
            else
            {
                return String.Format("O Tempo Total é {0} Dias", duration);
            }
        }
    }
}
