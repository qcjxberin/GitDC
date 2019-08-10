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
    /// 服务测试
    /// </summary>
    [Collection( "GlobalConfig" )]
    public class AuthorizationLogServiceTest : IDisposable {
        /// <summary>
        /// 容器作用域
        /// </summary>
        private readonly IScope _scope;
        /// <summary>
        /// 服务
        /// </summary>
        private readonly IAuthorizationLogService _authorizationLogService;
        /// <summary>
        /// 仓储
        /// </summary>
        private readonly IAuthorizationLogRepository _authorizationLogRepository;
        /// <summary>
        /// Dto
        /// </summary>
        private readonly AuthorizationLogDto _authorizationLogDto;

        /// <summary>
        /// 测试初始化
        /// </summary>
        public AuthorizationLogServiceTest() {
            _scope = Ioc.BeginScope();
            _authorizationLogRepository = _scope.Create<IAuthorizationLogRepository>();
            _authorizationLogService = _scope.Create<IAuthorizationLogService>();
            _authorizationLogDto = AuthorizationLogDtoTest.Create();
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
            var count = _authorizationLogRepository.Count();
            _authorizationLogService.Save( _authorizationLogDto );
            Assert.Equal( count + 1, _authorizationLogRepository.Count() );
        }
    }
}