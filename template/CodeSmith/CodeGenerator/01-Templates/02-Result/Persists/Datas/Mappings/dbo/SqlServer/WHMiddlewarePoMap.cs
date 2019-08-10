using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using GitDC.Data.Pos.dbo;

namespace GitDC.Data.Mappings.dbo.SqlServer {
    /// <summary>
    /// 网络勾子中转表持久化对象映射配置
    /// </summary>
    public class WHMiddlewarePoMap : Ding.Datas.Ef.SqlServer.AggregateRootMap<WHMiddlewarePo> {
        /// <summary>
        /// 映射表
        /// </summary>
        protected override void MapTable( EntityTypeBuilder<WHMiddlewarePo> builder ) {
            builder.ToTable( "WH_Middleware", "dbo" );
        }
        
        /// <summary>
        /// 映射属性
        /// </summary>
        protected override void MapProperties( EntityTypeBuilder<WHMiddlewarePo> builder ) {
            //编号
            builder.Property(t => t.Id)
                .HasColumnName("Id");
            builder.HasQueryFilter( t => t.IsDeleted == false );
        }
    }
}
