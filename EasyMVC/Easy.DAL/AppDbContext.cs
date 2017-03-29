using System.Data.Entity;

namespace Easy.DAL
{
    /// <summary>
    /// 数据上下文
    /// <remarks>创建：2014.02.03</remarks>
    /// </summary>
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("AppDbContext")
        {
        }
        ///// <summary>
        ///// 积分变更记录上下文
        ///// </summary>
        //public IDbSet<IntegralChange> IntegralChanges { get; set; }
    }
}