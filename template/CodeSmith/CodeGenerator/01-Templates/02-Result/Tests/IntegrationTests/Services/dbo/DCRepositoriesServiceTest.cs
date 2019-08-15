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
    /// 仓库表服务测试
    /// </summary>
    [Collection( "GlobalConfig" )]
    public class DCRepositoriesServiceTest : IDisposable {
        /// <summary>
        /// 容器作用域
        /// </summary>
        private readonly IScope _scope;
        /// <summary>
        /// 仓库表服务
        /// </summary>
        private readonly IDCRepositoriesService _dCRepositoriesService;
        /// <summary>
        /// 仓库表仓储
        /// </summary>
        private readonly IDCRepositoriesRepository _dCRepositoriesRepository;
        /// <summary>
        /// 仓库表Dto
        /// </summary>
        private readonly DCRepositoriesDto _dCRepositoriesDto;

        /// <summary>
        /// 测试初始化
        /// </summary>
        public DCRepositoriesServiceTest() {
            _scope = Ioc.BeginScope();
            _dCRepositoriesRepository = _scope.Create<IDCRepositoriesRepository>();
            _dCRepositoriesService = _scope.Create<IDCRepositoriesService>();
            _dCRepositoriesDto = DCRepositoriesDtoTest.Create();
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
            var count = _dCRepositoriesRepository.Count();
            _dCRepositoriesService.Save( _dCRepositoriesDto );
            Assert.Equal( count + 1, _dCRepositoriesRepository.Count() );
        }
    }
}