using System;
using System.Collections.Generic;
using Xunit;
using Ding;
using Ding.Helpers;
using Ding.Dependency;
using GitDC.Domain.Models;
using GitDC.Domain.Repositories;
using GitDC.Service.Abstractions.dbo;
using GitDC.Service.Dtos.dbo;
using GitDC.Test.Integration.Dtos.dbo;

namespace GitDC.Test.Integration.Services.dbo {
    /// <summary>
    /// 网络勾子推送内容日志服务测试
    /// </summary>
    [Collection( "GlobalConfig" )]
    public class WHLogsServiceTest : IDisposable {
        /// <summary>
        /// 容器作用域
        /// </summary>
        private readonly IScope _scope;
        /// <summary>
        /// 网络勾子推送内容日志服务
        /// </summary>
        private readonly IWHLogsService _wHLogsService;
        /// <summary>
        /// 网络勾子推送内容日志仓储
        /// </summary>
        private readonly IWHLogsRepository _wHLogsRepository;
        /// <summary>
        /// 网络勾子推送内容日志Dto
        /// </summary>
        private readonly WHLogsDto _wHLogsDto;

        /// <summary>
        /// 测试初始化
        /// </summary>
        public WHLogsServiceTest() {
            _scope = Ioc.BeginScope();
            _wHLogsRepository = _scope.Create<IWHLogsRepository>();
            _wHLogsService = _scope.Create<IWHLogsService>();
            _wHLogsDto = WHLogsDtoTest.Create();
        }
        
        /// <summary>
        /// 测试清理
        /// </summary>
        public void Dispose() {
            _scope.Dispose();
        }
        
        /// <summary>
        /// 测试
        /// </summary>
        [Fact]
        public void Test() {
            var count = _wHLogsRepository.Count();
            _wHLogsService.Save( _wHLogsDto );
            Assert.Equal( count + 1, _wHLogsRepository.Count() );
        }
    }
}