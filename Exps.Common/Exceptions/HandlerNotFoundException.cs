using System;

namespace Exps.Common.Exceptions
{
    public class HandlerNotFoundException : Exception
    {
        public HandlerNotFoundException(string commandName)
            : base(String.Format("Нет зарегистрированных обработчиков для вызванной команды '{0}'", commandName))
        {
        }

        public HandlerNotFoundException(Type commandType)
            : base(String.Format("Нет зарегистрированных обработчиков для вызванной команды '{0}'", commandType.FullName))
        {
        }
    }
}
