using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffInfo.Common
{
    /// <summary>
    /// Больничный
    /// </summary>
    public class HospitalTime : MarkEntity
    {
        /// <summary>
        /// Краткое описание
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Дата открытия больничного
        /// </summary>
        public DateTime StartHospitalTime { get; set; }
        
        /// <summary>
        /// Дата закрытия больничного
        /// </summary>
        public DateTime FinishHospitalTime { get; set; }    
    }
}
