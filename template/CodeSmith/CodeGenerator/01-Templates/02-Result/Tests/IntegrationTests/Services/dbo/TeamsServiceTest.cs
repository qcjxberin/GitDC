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
    public class TeamsServiceTest : IDisposable {
        /// <summary>
        /// 容器作用域
        /// </summary>
        private readonly IScope _scope;
        /// <summary>
        /// 服务
        /// </summary>
        private readonly ITeamsService _teamsService;
        /// <summary>
        /// 仓储
        /// </summary>
        private readonly ITeamsRepository _teamsRepository;
        /// <summary>
        /// Dto
        /// </summary>
        private readonly TeamsDto _teamsDto;

        /// <summary>
        /// 测试初始化
        /// </summary>
        public TeamsServiceTest() {
            _scope = Ioc.BeginScope();
            _teamsRepository = _scope.Create<ITeamsRepository>();
            _teamsService = _scope.Create<ITeamsService>();
            _teamsDto = TeamsDtoTest.Create();
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
            var count = _teamsRepository.Count();
            _teamsService.Save( _teamsDto );
            Assert.Equal( count + 1, _teamsRepository.Count() );
        }
    }
}