using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using GitDC.Domain.Models;

namespace GitDC.Data.Mappings.MySql {
    /// <summary>
    /// 网络勾子推送内容日志映射配置
    /// </summary>
    public class WHLogsMap : Ding.Datas.Ef.MySql.AggregateRootMap<WHLogs> {
        /// <summary>
        /// 映射表
        /// </summary>
        protected override void MapTable( EntityTypeBuilder<WHLogs> builder ) {
            builder.ToTable( "WH_Logs" );
        }
        
        /// <summary>
        /// 映射属性
        /// </summary>
        protected override void MapProperties( EntityTypeBuilder<WHLogs> builder ) {
            //编号
            builder.Property(t => t.Id)
                .HasColumnName("Id");
            builder.HasQueryFilter( t => t.IsDeleted == false );
        }
    }
}
