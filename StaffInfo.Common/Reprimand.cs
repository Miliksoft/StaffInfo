using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffInfo.Common
{
    /// <summary>
    /// Выговор
    /// </summary>
    public class Reprimand : MarkEntity
    {
        /// <summary>
        /// Краткое описание выговора
        /// </summary>
        public string Title { get; set; }
        
        /// <summary>
        /// Сумма по выговору
        /// </summary>
        public double sumOfReprimand { get; set; }
        
        /// <summary>
        /// Дата выговора
        /// </summary>
        public DateTime reprimandDate { get; set; }
    }
}
