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
    public class TeamRepositoryRoleServiceTest : IDisposable {
        /// <summary>
        /// 容器作用域
        /// </summary>
        private readonly IScope _scope;
        /// <summary>
        /// 服务
        /// </summary>
        private readonly ITeamRepositoryRoleService _teamRepositoryRoleService;
        /// <summary>
        /// 仓储
        /// </summary>
        private readonly ITeamRepositoryRoleRepository _teamRepositoryRoleRepository;
        /// <summary>
        /// Dto
        /// </summary>
        private readonly TeamRepositoryRoleDto _teamRepositoryRoleDto;

        /// <summary>
        /// 测试初始化
        /// </summary>
        public TeamRepositoryRoleServiceTest() {
            _scope = Ioc.BeginScope();
            _teamRepositoryRoleRepository = _scope.Create<ITeamRepositoryRoleRepository>();
            _teamRepositoryRoleService = _scope.Create<ITeamRepositoryRoleService>();
            _teamRepositoryRoleDto = TeamRepositoryRoleDtoTest.Create();
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
            var count = _teamRepositoryRoleRepository.Count();
            _teamRepositoryRoleService.Save( _teamRepositoryRoleDto );
            Assert.Equal( count + 1, _teamRepositoryRoleRepository.Count() );
        }
    }
}