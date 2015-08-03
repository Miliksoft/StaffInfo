using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StaffInfo.Grades;
using StaffInfo.Entities;
using StaffInfo.Common;

namespace StaffInfo.Entities
{
    /// <summary>
    /// Базовая сущность для служащих
    /// </summary>
    public abstract class EmployerEntity : Entity, IStaffEntity
    {

        #region Properties
        /// <summary>
        /// Имя служащего
        /// </summary>
        public string FirstName { get; set; }
                
        /// <summary>
        /// Отчество служащего
        /// </summary>
        public string MiddleName { get; set; }
        
        /// <summary>
        /// Фамилия служащего
        /// </summary>
        public string LastName { get; set; }
        
        /// <summary>
        /// Должность служащего
        /// </summary>
        public string Post { get; set; }
        
        /// <summary>
        /// Звание служащего
        /// </summary>
        public string Rank { get; set; }
        
        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime BornDate { get; set; }
        
        /// <summary>
        /// Дата начала службы в МЧС
        /// </summary>
        public DateTime JobStartDate { get; set; }

        /// <summary>
        /// Список нарушений служащего
        /// </summary>
        public IEnumerable<Violation> ViolationList;

        /// <summary>
        /// Список выговоров служащего
        /// </summary>
        public IEnumerable<Reprimand> ReprimandList;
        
        /// <summary>
        /// Список больничных служащего
        /// </summary>
        public IEnumerable<HospitalTime> HospitalTimeList;
        
        /// <summary>
        /// Список отпусков служащего
        /// </summary>
        public IEnumerable<HolidayTime> HolidayTimeList;
        
        /// <summary>
        /// Список благодарностей служащего
        /// </summary>
        public IEnumerable<Gratitude> GratitudeList;

        /// <summary>
        /// Дополнительные заметки по служащему
        /// </summary>
        public AdditionalRemark additionalRemark;

        #endregion 
    
        #region Constructor
        public EmployerEntity()
        {
            ViolationList = new List<Violation>();
            ReprimandList = new List<Reprimand>();
            HolidayTimeList = new List<HolidayTime>();
            HospitalTimeList = new List<HospitalTime>();
            GratitudeList = new List<Gratitude>();
            additionalRemark = new AdditionalRemark();
        }
        #endregion
    }
}
/*
 * Нарушение                - violation
 * Больничный               - hospital
 * Выговор                  - reprimand
 * Благодарность            - gratitude
 * Отпуск                   - holiday
 * Выслуга лет              - expirience
 * Дополнительное замечание - remark
 * Должность                - post
 * Звание                   - rank
 * Служба                   - service/duty
 * МЧС                      - ministry of emergency sutuations
*/