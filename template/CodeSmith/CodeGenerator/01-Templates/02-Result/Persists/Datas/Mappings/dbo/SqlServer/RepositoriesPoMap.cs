using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using GitDC.Data.Pos.dbo;

namespace GitDC.Data.Mappings.dbo.SqlServer {
    /// <summary>
    /// 持久化对象映射配置
    /// </summary>
    public class RepositoriesPoMap : Ding.Datas.Ef.SqlServer.AggregateRootMap<RepositoriesPo> {
        /// <summary>
        /// 映射表
        /// </summary>
        protected override void MapTable( EntityTypeBuilder<RepositoriesPo> builder ) {
            builder.ToTable( "Repositories", "dbo" );
        }
        
        /// <summary>
        /// 映射属性
        /// </summary>
        protected override void MapProperties( EntityTypeBuilder<RepositoriesPo> builder ) {
            //
            builder.Property(t => t.Id)
                .HasColumnName("ID")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
