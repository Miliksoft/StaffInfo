using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffInfo.Common
{
    /// <summary>
    ///Выслуга лет
    /// </summary>
    public sealed class ExpirienceTimeByYear
    {
        public int Year { get; private set; }
        public int Month { get; private set; }
        public int Day { get; private set; }
        public ExpirienceTimeByYear(int year, int month, int day)
        {
            Year = year;
            Month = month;
            Day = day;
        }
        public override string ToString()
        {
            return string.Format("{0} лет {1} месяцев {2} дней)", Year, Month, Day); 
        }
    }
}
