using Ding.Files;
using Ding.Helpers;
using Ding.IO;
using GitDC.Common;
using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GitDC.Handlers
{
    public static class Check
    {
        /// <summary>
        /// Git环境检测
        /// </summary>
        /// <param name="self"></param>
        /// <returns></returns>
        public static IApplicationBuilder CheckGit(this IApplicationBuilder self)
        {
            if (SiteSetting.Current.GitConfig.GitCorePath.IsNullOrEmpty() || !FileSystemObject.IsExist(Path.Combine(SiteSetting.Current.GitConfig.GitCorePath, "git.exe"), FsoMethod.File))
            {
                var list = new List<string>();
                var variable = Environment.GetEnvironmentVariable("path");
                if (variable != null)
                    list.AddRange(variable.Split(';'));

                list.Add(Environment.GetEnvironmentVariable("ProgramW6432"));
                list.Add(Environment.GetEnvironmentVariable("ProgramFiles"));

                foreach (var drive in Environment.GetLogicalDrives())
                {
                    list.Add(drive + @"Program Files\Git");
                    list.Add(drive + @"Program Files (x86)\Git");
                    list.Add(drive + @"Program Files\PortableGit");
                    list.Add(drive + @"Program Files (x86)\PortableGit");
                    list.Add(drive + @"PortableGit");
                }

                list = list.Where(x => !string.IsNullOrEmpty(x)).Distinct().ToList();
                foreach (var path in list)
                {
                    var ret = SearchPath(path);
                    if (ret != null)
                    {
                        SiteSetting.Current.GitConfig.GitCorePath = ret;
                        SiteSetting.Current.SaveAsync();
                    }
                }
            }

            if (SiteSetting.Current.GitConfig.RepositoryPath.IsNullOrEmpty())
            {
                SiteSetting.Current.GitConfig.RepositoryPath = Path.Combine(AppContext.BaseDirectory, "Repository");
                SiteSetting.Current.SaveAsync();
            }

            if (!FileSystemObject.IsExist(SiteSetting.Current.GitConfig.RepositoryPath, FsoMethod.Folder))
            {
                DirectoryUtil.CreateIfNotExists(SiteSetting.Current.GitConfig.RepositoryPath);
            }

            if (SiteSetting.Current.GitConfig.CachePath.IsNullOrEmpty())
            {
                SiteSetting.Current.GitConfig.CachePath = Path.Combine(AppContext.BaseDirectory, "Cache");
                SiteSetting.Current.SaveAsync();
            }

            if (!FileSystemObject.IsExist(SiteSetting.Current.GitConfig.CachePath, FsoMethod.Folder))
            {
                DirectoryUtil.CreateIfNotExists(SiteSetting.Current.GitConfig.CachePath);
            }

            return self;
        }

        private static string SearchPath(string path)
        {
            var patterns = new[] {
                @"..\libexec\git-core", // git 1.x
                @"libexec\git-core", // git 1.x
                @"..\mingw64\libexec\git-core", // git 2.x
                @"mingw64\libexec\git-core", // git 2.x
            };
            foreach (var pattern in patterns)
            {
                var fullpath = new DirectoryInfo(Path.Combine(path, pattern)).FullName;
                if (System.IO.File.Exists(Path.Combine(fullpath, "git.exe"))
                    && System.IO.File.Exists(Path.Combine(fullpath, "git-receive-pack.exe"))
                    && System.IO.File.Exists(Path.Combine(fullpath, "git-upload-archive.exe"))
                    && System.IO.File.Exists(Path.Combine(fullpath, "git-upload-pack.exe")))
                    return fullpath;
            }
            return null;
        }
    }
}
