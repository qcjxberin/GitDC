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
    public class UsersServiceTest : IDisposable {
        /// <summary>
        /// 容器作用域
        /// </summary>
        private readonly IScope _scope;
        /// <summary>
        /// 用户名服务
        /// </summary>
        private readonly IUsersService _usersService;
        /// <summary>
        /// 用户名仓储
        /// </summary>
        private readonly IUsersRepository _usersRepository;
        /// <summary>
        /// 用户名Dto
        /// </summary>
        private readonly UsersDto _usersDto;

        /// <summary>
        /// 测试初始化
        /// </summary>
        public UsersServiceTest() {
            _scope = Ioc.BeginScope();
            _usersRepository = _scope.Create<IUsersRepository>();
            _usersService = _scope.Create<IUsersService>();
            _usersDto = UsersDtoTest.Create();
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
            var count = _usersRepository.Count();
            _usersService.Save( _usersDto );
            Assert.Equal( count + 1, _usersRepository.Count() );
        }
    }
}