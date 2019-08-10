using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using GitDC.Domain.Models;

namespace GitDC.Data.Mappings.dbo.SqlServer {
    /// <summary>
    /// 网络勾子中转表映射配置
    /// </summary>
    public class WHMiddlewareMap : Ding.Datas.Ef.SqlServer.AggregateRootMap<WHMiddleware> {
        /// <summary>
        /// 映射表
        /// </summary>
        protected override void MapTable( EntityTypeBuilder<WHMiddleware> builder ) {
            builder.ToTable( "WH_Middleware", "dbo" );
        }
        
        /// <summary>
        /// 映射属性
        /// </summary>
        protected override void MapProperties( EntityTypeBuilder<WHMiddleware> builder ) {
            //编号
            builder.Property(t => t.Id)
                .HasColumnName("Id");
            builder.HasQueryFilter( t => t.IsDeleted == false );
        }
    }
}
