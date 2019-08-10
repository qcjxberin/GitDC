using Microsoft.EntityFrameworkCore;
using Ding.Datas.UnitOfWorks;

namespace GitDC.Data.UnitOfWorks.MySql {
    /// <summary>
    /// 工作单元
    /// </summary>
    public class GitDCUnitOfWork : Ding.Datas.Ef.MySql.UnitOfWork,IGitDCUnitOfWork {
        /// <summary>
        /// 初始化工作单元
        /// </summary>
        /// <param name="options">配置项</param>
        /// <param name="unitOfWorkManager">工作单元服务</param>
        public GitDCUnitOfWork( DbContextOptions options, IUnitOfWorkManager unitOfWorkManager ) : base( options, unitOfWorkManager ) {
        }
    }
}