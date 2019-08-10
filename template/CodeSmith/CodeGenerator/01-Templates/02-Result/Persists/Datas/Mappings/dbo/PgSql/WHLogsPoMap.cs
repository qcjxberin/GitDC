using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using GitDC.Data.Pos.dbo;

namespace GitDC.Data.Mappings.dbo.PgSql {
    /// <summary>
    /// 网络勾子推送内容日志持久化对象映射配置
    /// </summary>
    public class WHLogsPoMap : Ding.Datas.Ef.PgSql.AggregateRootMap<WHLogsPo> {
        /// <summary>
        /// 映射表
        /// </summary>
        protected override void MapTable( EntityTypeBuilder<WHLogsPo> builder ) {
            builder.ToTable( "WH_Logs", "dbo" );
        }
        
        /// <summary>
        /// 映射属性
        /// </summary>
        protected override void MapProperties( EntityTypeBuilder<WHLogsPo> builder ) {
            //编号
            builder.Property(t => t.Id)
                .HasColumnName("Id");
            builder.HasQueryFilter( t => t.IsDeleted == false );
        }
    }
}
