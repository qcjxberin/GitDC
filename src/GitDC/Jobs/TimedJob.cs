using GitDC.Common;
using GitDC.Service.Abstractions.dbo;
using Ding.Helpers;
using Ding.Log;
using Ding.TimedJob.Schema;
using EasyCaching.Core;
using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace DCLiGongBang.Jobs
{
    public class TimedJob : Job
    {
        [Invoke(Interval = 1000 * 10, SkipWhileExecuting = true, IsEnabled = true)]
        public async Task TimedTest()
        {

            await Task.FromResult(0);
        }
    }
}
