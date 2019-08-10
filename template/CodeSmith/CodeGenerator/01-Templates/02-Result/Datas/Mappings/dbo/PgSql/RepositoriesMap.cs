using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using GitDC.Domain.Models;

namespace GitDC.Data.Mappings.dbo.PgSql {
    /// <summary>
    /// 映射配置
    /// </summary>
    public class RepositoriesMap : Ding.Datas.Ef.PgSql.AggregateRootMap<Repositories> {
        /// <summary>
        /// 映射表
        /// </summary>
        protected override void MapTable( EntityTypeBuilder<Repositories> builder ) {
            builder.ToTable( "Repositories", "dbo" );
        }
        
        /// <summary>
        /// 映射属性
        /// </summary>
        protected override void MapProperties( EntityTypeBuilder<Repositories> builder ) {
            //
            builder.Property(t => t.Id)
                .HasColumnName("ID")
                ;
        }
    }
}
