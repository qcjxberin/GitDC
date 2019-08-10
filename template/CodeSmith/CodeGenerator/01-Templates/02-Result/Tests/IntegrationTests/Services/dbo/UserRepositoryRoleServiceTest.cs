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
    public class UserRepositoryRoleServiceTest : IDisposable {
        /// <summary>
        /// 容器作用域
        /// </summary>
        private readonly IScope _scope;
        /// <summary>
        /// 服务
        /// </summary>
        private readonly IUserRepositoryRoleService _userRepositoryRoleService;
        /// <summary>
        /// 仓储
        /// </summary>
        private readonly IUserRepositoryRoleRepository _userRepositoryRoleRepository;
        /// <summary>
        /// Dto
        /// </summary>
        private readonly UserRepositoryRoleDto _userRepositoryRoleDto;

        /// <summary>
        /// 测试初始化
        /// </summary>
        public UserRepositoryRoleServiceTest() {
            _scope = Ioc.BeginScope();
            _userRepositoryRoleRepository = _scope.Create<IUserRepositoryRoleRepository>();
            _userRepositoryRoleService = _scope.Create<IUserRepositoryRoleService>();
            _userRepositoryRoleDto = UserRepositoryRoleDtoTest.Create();
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
            var count = _userRepositoryRoleRepository.Count();
            _userRepositoryRoleService.Save( _userRepositoryRoleDto );
            Assert.Equal( count + 1, _userRepositoryRoleRepository.Count() );
        }
    }
}