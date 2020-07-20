using System.Collections.Generic;

namespace Exps.Common.Dispatcher
{
    /// <summary> Класс разрешения команд </summary>
    public interface IDispatcher
    {
        /// <summary> Команда с параметрами </summary>
        /// <param name="command"> Параметры команды </param>
        void Handle<TCommand>(TCommand command);

        /// <summary> Запрос </summary>
        /// <typeparam name="TEntity"> Сущность базы данных, к которой выполняется обращение</typeparam>
        /// <typeparam name="TParams"> Набор параметров, фильтров </typeparam>
        /// <typeparam name="TView"> Выходная модель-представление представление </typeparam>
        /// <param name="params"> Набор параметров, фильтров </param>
        /// <returns> Список записей сущности, загруженный в память </returns>
        IEnumerable<TView> HandleQuery<TEntity, TParams, TView>(TParams @params) where TEntity : class;
    }
}
