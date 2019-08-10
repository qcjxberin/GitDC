using Microsoft.EntityFrameworkCore;
using System;

namespace GitDC.Data.Oracle
{
    /// <summary>
    /// 工作单元
    /// </summary>
    public class GitDCUnitOfWork : Ding.Datas.Ef.Oracle.UnitOfWork, IGitDCUnitOfWork
    {
        /// <summary>
        /// 初始化工作单元
        /// </summary>
        /// <param name="options">配置项</param>
        /// <param name="serviceProvider">服务提供器</param>
        public GitDCUnitOfWork(DbContextOptions<GitDCUnitOfWork> options, IServiceProvider serviceProvider) : base(options, serviceProvider)
        {
        }
    }
}
