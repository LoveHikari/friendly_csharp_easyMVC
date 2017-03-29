using System.Runtime.Remoting.Messaging;

namespace Easy.DAL
{
    /// <summary>
    /// 上下文简单工厂
    /// </summary>
    public class ContextFactory
    {

        /// <summary>
        /// 获取当前数据上下文
        /// </summary>
        /// <returns></returns>
        public static AppDbContext GetCurrentContext()
        {
            AppDbContext nContext = CallContext.GetData("AppDbContext") as AppDbContext;
            if (nContext == null)
            {
                nContext = new AppDbContext();
                CallContext.SetData("AppDbContext", nContext);
            }
            return nContext;
        }
    }
}