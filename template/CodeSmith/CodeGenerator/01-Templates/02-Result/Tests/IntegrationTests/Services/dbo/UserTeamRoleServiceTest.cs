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
    public class UserTeamRoleServiceTest : IDisposable {
        /// <summary>
        /// 容器作用域
        /// </summary>
        private readonly IScope _scope;
        /// <summary>
        /// 服务
        /// </summary>
        private readonly IUserTeamRoleService _userTeamRoleService;
        /// <summary>
        /// 仓储
        /// </summary>
        private readonly IUserTeamRoleRepository _userTeamRoleRepository;
        /// <summary>
        /// Dto
        /// </summary>
        private readonly UserTeamRoleDto _userTeamRoleDto;

        /// <summary>
        /// 测试初始化
        /// </summary>
        public UserTeamRoleServiceTest() {
            _scope = Ioc.BeginScope();
            _userTeamRoleRepository = _scope.Create<IUserTeamRoleRepository>();
            _userTeamRoleService = _scope.Create<IUserTeamRoleService>();
            _userTeamRoleDto = UserTeamRoleDtoTest.Create();
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
            var count = _userTeamRoleRepository.Count();
            _userTeamRoleService.Save( _userTeamRoleDto );
            Assert.Equal( count + 1, _userTeamRoleRepository.Count() );
        }
    }
}