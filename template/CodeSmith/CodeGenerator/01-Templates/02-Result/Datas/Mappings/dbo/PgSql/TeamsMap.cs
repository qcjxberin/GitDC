using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using GitDC.Domain.Models;

namespace GitDC.Data.Mappings.dbo.PgSql {
    /// <summary>
    /// 映射配置
    /// </summary>
    public class TeamsMap : Ding.Datas.Ef.PgSql.AggregateRootMap<Teams> {
        /// <summary>
        /// 映射表
        /// </summary>
        protected override void MapTable( EntityTypeBuilder<Teams> builder ) {
            builder.ToTable( "Teams", "dbo" );
        }
        
        /// <summary>
        /// 映射属性
        /// </summary>
        protected override void MapProperties( EntityTypeBuilder<Teams> builder ) {
            //
            builder.Property(t => t.Id)
                .HasColumnName("ID")
                ;
        }
    }
}
