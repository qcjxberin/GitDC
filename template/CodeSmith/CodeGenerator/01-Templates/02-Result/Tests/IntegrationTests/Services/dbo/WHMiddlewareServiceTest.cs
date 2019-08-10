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
    /// 网络勾子中转表服务测试
    /// </summary>
    [Collection( "GlobalConfig" )]
    public class WHMiddlewareServiceTest : IDisposable {
        /// <summary>
        /// 容器作用域
        /// </summary>
        private readonly IScope _scope;
        /// <summary>
        /// 网络勾子中转表服务
        /// </summary>
        private readonly IWHMiddlewareService _wHMiddlewareService;
        /// <summary>
        /// 网络勾子中转表仓储
        /// </summary>
        private readonly IWHMiddlewareRepository _wHMiddlewareRepository;
        /// <summary>
        /// 网络勾子中转表Dto
        /// </summary>
        private readonly WHMiddlewareDto _wHMiddlewareDto;

        /// <summary>
        /// 测试初始化
        /// </summary>
        public WHMiddlewareServiceTest() {
            _scope = Ioc.BeginScope();
            _wHMiddlewareRepository = _scope.Create<IWHMiddlewareRepository>();
            _wHMiddlewareService = _scope.Create<IWHMiddlewareService>();
            _wHMiddlewareDto = WHMiddlewareDtoTest.Create();
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
            var count = _wHMiddlewareRepository.Count();
            _wHMiddlewareService.Save( _wHMiddlewareDto );
            Assert.Equal( count + 1, _wHMiddlewareRepository.Count() );
        }
    }
}