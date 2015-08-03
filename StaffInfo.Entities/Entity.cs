using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffInfo.Entities
{
    /// <summary>
    /// Базовая сущность
    /// </summary>
    public abstract class Entity
    {
        /// <summary>
        /// Id
        /// </summary>
        public long? Id { get; set; }
    }
}
