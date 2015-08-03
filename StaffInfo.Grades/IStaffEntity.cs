using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StaffInfo.Common;

namespace StaffInfo.Grades
{
    /// <summary>
    /// Базовый интерфейс 
    /// </summary>
    public interface IStaffEntity
    {
        /// <summary>
        /// Рассчитать выслугу лет для служащего
        /// </summary>
        /// <param name="startDate">Дата начала службы в МЧС</param>
        /// <returns></returns>
        ExpirienceTimeByYear CalculateExpirienceTimeByYear(DateTime startDate);        
    }
}
