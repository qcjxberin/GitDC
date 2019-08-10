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
    public class RepositoriesServiceTest : IDisposable {
        /// <summary>
        /// 容器作用域
        /// </summary>
        private readonly IScope _scope;
        /// <summary>
        /// 服务
        /// </summary>
        private readonly IRepositoriesService _repositoriesService;
        /// <summary>
        /// 仓储
        /// </summary>
        private readonly IRepositoriesRepository _repositoriesRepository;
        /// <summary>
        /// Dto
        /// </summary>
        private readonly RepositoriesDto _repositoriesDto;

        /// <summary>
        /// 测试初始化
        /// </summary>
        public RepositoriesServiceTest() {
            _scope = Ioc.BeginScope();
            _repositoriesRepository = _scope.Create<IRepositoriesRepository>();
            _repositoriesService = _scope.Create<IRepositoriesService>();
            _repositoriesDto = RepositoriesDtoTest.Create();
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
            var count = _repositoriesRepository.Count();
            _repositoriesService.Save( _repositoriesDto );
            Assert.Equal( count + 1, _repositoriesRepository.Count() );
        }
    }
}