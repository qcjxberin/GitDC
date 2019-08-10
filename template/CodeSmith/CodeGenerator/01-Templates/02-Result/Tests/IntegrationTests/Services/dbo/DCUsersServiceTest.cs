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
    /// 用户名服务测试
    /// </summary>
    [Collection( "GlobalConfig" )]
    public class DCUsersServiceTest : IDisposable {
        /// <summary>
        /// 容器作用域
        /// </summary>
        private readonly IScope _scope;
        /// <summary>
        /// 用户名服务
        /// </summary>
        private readonly IDCUsersService _dCUsersService;
        /// <summary>
        /// 用户名仓储
        /// </summary>
        private readonly IDCUsersRepository _dCUsersRepository;
        /// <summary>
        /// 用户名Dto
        /// </summary>
        private readonly DCUsersDto _dCUsersDto;

        /// <summary>
        /// 测试初始化
        /// </summary>
        public DCUsersServiceTest() {
            _scope = Ioc.BeginScope();
            _dCUsersRepository = _scope.Create<IDCUsersRepository>();
            _dCUsersService = _scope.Create<IDCUsersService>();
            _dCUsersDto = DCUsersDtoTest.Create();
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
            var count = _dCUsersRepository.Count();
            _dCUsersService.Save( _dCUsersDto );
            Assert.Equal( count + 1, _dCUsersRepository.Count() );
        }
    }
}