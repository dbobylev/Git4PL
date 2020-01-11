using System;
using System.Runtime.InteropServices;

namespace Git4PL.PLSqlDeveloper.IDECallBacks
{
    /// <summary>
    /// Класс который хранит делегат для обратного вызова из PL/SQL Developer
    /// </summary>
    /// <typeparam name="T">Тип делегата</typeparam>
    class Callback<T> : ICallback where T : Delegate
    {
        private static NLog.Logger logger = NLog.LogManager.GetLogger("Git4PL.PLSqlDeveloper.IDECallBacks.Callback");

        public T CallBackDelegate;

        public Type delegateType
        {
            get { return typeof(T); }
        }

        public Callback()
        {

        }

        public P GetDelegate<P>()
        {
            logger.Trace("Запрошен делегат {0}", typeof(P).ToString());
            if (CallBackDelegate is P AnswerDelegate)
                return AnswerDelegate;

            return default;
        }

        /// <summary>
        /// PL/SQL Developer устанавливает указатель для этого делагата
        /// </summary>
        /// <param name="function"></param>
        public void SetDelegate(IntPtr function)
        {
            logger.Trace("Для делегата {0} установлен указатель {1}", typeof(T).ToString(), (long)function);
            CallBackDelegate = Marshal.GetDelegateForFunctionPointer<T>(function);
        }
    }
}
