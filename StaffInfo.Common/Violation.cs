using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffInfo.Common
{
    /// <summary>
    /// Нарушение
    /// </summary>
    public class Violation : MarkEntity
    {
        /// <summary>
        /// Краткое описание нарушения
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Дата нарушения
        /// </summary>
        public DateTime violationDate { get; set; }
    }
}
