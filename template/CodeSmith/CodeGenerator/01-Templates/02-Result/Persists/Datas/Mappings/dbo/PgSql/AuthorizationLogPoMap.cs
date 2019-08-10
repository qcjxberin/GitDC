using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using GitDC.Data.Pos.dbo;

namespace GitDC.Data.Mappings.dbo.PgSql {
    /// <summary>
    /// 持久化对象映射配置
    /// </summary>
    public class AuthorizationLogPoMap : Ding.Datas.Ef.PgSql.AggregateRootMap<AuthorizationLogPo> {
        /// <summary>
        /// 映射表
        /// </summary>
        protected override void MapTable( EntityTypeBuilder<AuthorizationLogPo> builder ) {
            builder.ToTable( "AuthorizationLog", "dbo" );
        }
        
        /// <summary>
        /// 映射属性
        /// </summary>
        protected override void MapProperties( EntityTypeBuilder<AuthorizationLogPo> builder ) {
            //
            builder.Property(t => t.Id)
                .HasColumnName("AuthCode");
        }
    }
}
