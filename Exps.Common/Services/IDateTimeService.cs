using System;

namespace Exps.Common.Services
{
    /// <summary>
    /// Сервис для работы со временем и датой
    /// </summary>
    public interface IDateTimeService
    {
        /// <summary>
        /// Возвращает текущее время и дату (системный часовой пояс)
        /// </summary>
        DateTime Now();

        /// <summary>
        /// Возвращает текущую дату (без времени) (системный часовой пояс)
        /// </summary>
        DateTime Today();
    }
}
