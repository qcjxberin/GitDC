using Ding;
using Ding.Maps;
using Ding.Domains.Repositories;
using Ding.Datas.Queries;
using Ding.Applications;
using GitDC.Data;
using GitDC.Domain.Models;
using GitDC.Domain.Repositories;
using GitDC.Service.Dtos.dbo;
using GitDC.Service.Queries.dbo;
using GitDC.Service.Abstractions.dbo;
using System.Threading.Tasks;
using System.Collections.Generic;
using LibGit2Sharp;
using System.IO;
using GitDC.Common;
using System.Linq;

namespace GitDC.Service.Implements.dbo {
    /// <summary>
    /// 仓库表服务
    /// </summary>
    public class DCRepositoriesService : CrudServiceBase<DCRepositories, DCRepositoriesDto, DCRepositoriesQuery>, IDCRepositoriesService {
        /// <summary>
        /// 初始化仓库表服务
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        /// <param name="dCRepositoriesRepository">仓库表仓储</param>
        public DCRepositoriesService( IGitDCUnitOfWork unitOfWork, IDCRepositoriesRepository dCRepositoriesRepository )
            : base( unitOfWork, dCRepositoriesRepository ) {
            DCRepositoriesRepository = dCRepositoriesRepository;
        }
        
        /// <summary>
        /// 仓库表仓储
        /// </summary>
        public IDCRepositoriesRepository DCRepositoriesRepository { get; set; }
        
        /// <summary>
        /// 创建查询对象
        /// </summary>
        /// <param name="param">查询参数</param>
        protected override IQueryBase<DCRepositories> CreateQuery( DCRepositoriesQuery param ) {
            return new Query<DCRepositories>( param );
        }

        /// <summary>
        /// 获取指定用户的仓库信息
        /// </summary>
        /// <param name="UserName">用户名</param>
        /// <returns></returns>
        public async Task<List<DCRepositories>> GetListByUserName(string UserName)
        {
            return await DCRepositoriesRepository.FindAllNoTrackingAsync(x => x.UserName == UserName);
        }

        /// <summary>
        /// 创建仓储
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Repository CreateRepository(string name)
        {
            string path = Path.Combine(SiteSetting.Current.GitConfig.RepositoryPath, name);
            Repository repo = new Repository(Repository.Init(path, true));
            return repo;
        }

        /// <summary>
        /// 创建创建
        /// </summary>
        /// <param name="name"></param>
        /// <param name="remoteUrl"></param>
        /// <returns></returns>
        public Repository CreateRepository(string name, string remoteUrl)
        {
            var path = Path.Combine(SiteSetting.Current.GitConfig.RepositoryPath, name);
            try
            {
                using (var repo = new Repository(Repository.Init(path, true)))
                {
                    repo.Config.Set("core.logallrefupdates", true);
                    repo.Network.Remotes.Add("origin", remoteUrl, "+refs/*:refs/*");
                    var logMessage = "";
                    foreach (var remote in repo.Network.Remotes)
                    {
                        IEnumerable<string> refSpecs = remote.FetchRefSpecs.Select(x => x.Specification);
                        Commands.Fetch(repo, remote.Name, refSpecs, null, logMessage);
                    }
                    return repo;
                }
            }
            catch
            {
                try
                {
                    Directory.Delete(path, true);
                }
                catch { }
                return null;
            }
        }

        /// <summary>
        /// 获取指定仓库的地址
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Repository GetRepository(string name)
            => new Repository(Path.Combine(SiteSetting.Current.GitConfig.RepositoryPath, name));

        /// <summary>
        /// 获取最后的提交
        /// </summary>
        /// <param name="repoName"></param>
        /// <param name="branch"></param>
        /// <returns></returns>
        public Commit GetLatestCommit(string repoName, string branch = null)
        {
            Repository repo = GetRepository(repoName);

            Branch b;
            if (branch == null)
                b = repo.Head;
            else
                b = repo.Branches.First(d => d.CanonicalName == branch);

            return b.Tip;
        }

    }
}