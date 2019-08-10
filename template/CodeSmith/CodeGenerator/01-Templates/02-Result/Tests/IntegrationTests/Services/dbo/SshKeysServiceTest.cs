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
    public class SshKeysServiceTest : IDisposable {
        /// <summary>
        /// 容器作用域
        /// </summary>
        private readonly IScope _scope;
        /// <summary>
        /// 服务
        /// </summary>
        private readonly ISshKeysService _sshKeysService;
        /// <summary>
        /// 仓储
        /// </summary>
        private readonly ISshKeysRepository _sshKeysRepository;
        /// <summary>
        /// Dto
        /// </summary>
        private readonly SshKeysDto _sshKeysDto;

        /// <summary>
        /// 测试初始化
        /// </summary>
        public SshKeysServiceTest() {
            _scope = Ioc.BeginScope();
            _sshKeysRepository = _scope.Create<ISshKeysRepository>();
            _sshKeysService = _scope.Create<ISshKeysService>();
            _sshKeysDto = SshKeysDtoTest.Create();
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
            var count = _sshKeysRepository.Count();
            _sshKeysService.Save( _sshKeysDto );
            Assert.Equal( count + 1, _sshKeysRepository.Count() );
        }
    }
}