using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffInfo.Common
{
    /// <summary>
    /// Отпуск
    /// </summary>
    public class HolidayTime
    {
        /// <summary>
        /// Краткая заметка к отпуску
        /// </summary>
        public string Title { get; set; }
        
        /// <summary>
        /// Дата начала отпуска
        /// </summary>
        public DateTime startHolidayDate { get; set; }
        
        /// <summary>
        /// Дата окончания отпуска
        /// </summary>
        public DateTime finishHolidayDate { get; set; }
    }
}
