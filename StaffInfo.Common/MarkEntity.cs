using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffInfo.Common
{
    /// <summary>
    /// Базовый класс для доп. информации по служащему
    /// </summary>
    public abstract class MarkEntity
    {
        public long Id { get; set; }
        public string Description { get; set; }
    }
}
