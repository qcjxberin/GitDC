using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using GitDC.Domain.Models;

namespace GitDC.Data.Mappings.dbo.PgSql {
    /// <summary>
    /// 用户名映射配置
    /// </summary>
    public class DCUsersMap : Ding.Datas.Ef.PgSql.AggregateRootMap<DCUsers> {
        /// <summary>
        /// 映射表
        /// </summary>
        protected override void MapTable( EntityTypeBuilder<DCUsers> builder ) {
            builder.ToTable( "DC_Users", "dbo" );
        }
        
        /// <summary>
        /// 映射属性
        /// </summary>
        protected override void MapProperties( EntityTypeBuilder<DCUsers> builder ) {
            //编号
            builder.Property(t => t.Id)
                .HasColumnName("ID")
                ;
            builder.HasQueryFilter( t => t.IsDeleted == false );
        }
    }
}
