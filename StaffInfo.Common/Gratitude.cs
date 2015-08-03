using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffInfo.Common
{
    /// <summary>
    /// Благодарность
    /// </summary>
    public class Gratitude : MarkEntity
    {
        /// <summary>
        /// Краткое описание благодарности
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Дата представления к благодарности
        /// </summary>
        public DateTime gratitudeDate { get; set; }
        
        /// <summary>
        /// Сумма премирования
        /// </summary>
        public double sumOfGratitude { get; set; }
    }
}
