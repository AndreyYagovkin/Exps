using System;

namespace Exps.Common.Services
{
    /// <summary>
    /// Сервис для работы со временем и датой
    /// </summary>
    public class DateTimeService : IDateTimeService
    {
        /// <summary>
        /// Возвращает текущее время и дату (системный часовой пояс)
        /// </summary>
        public DateTime Now()
        {
            return DateTime.Now;
        }

        /// <summary>
        /// Возвращает текущую дату (без времени) (системный часовой пояс)
        /// </summary>
        public DateTime Today()
        {
            return DateTime.Today;
        }
    }
}
