using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using GitDC.Domain.Models;

namespace GitDC.Data.Mappings.dbo.SqlServer {
    /// <summary>
    /// 映射配置
    /// </summary>
    public class AuthorizationLogMap : Ding.Datas.Ef.SqlServer.AggregateRootMap<AuthorizationLog> {
        /// <summary>
        /// 映射表
        /// </summary>
        protected override void MapTable( EntityTypeBuilder<AuthorizationLog> builder ) {
            builder.ToTable( "AuthorizationLog", "dbo" );
        }
        
        /// <summary>
        /// 映射属性
        /// </summary>
        protected override void MapProperties( EntityTypeBuilder<AuthorizationLog> builder ) {
            //
            builder.Property(t => t.Id)
                .HasColumnName("AuthCode");
        }
    }
}
