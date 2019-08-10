using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using GitDC.Data.Pos.dbo;

namespace GitDC.Data.Mappings.dbo.SqlServer {
    /// <summary>
    /// 持久化对象映射配置
    /// </summary>
    public class TeamsPoMap : Ding.Datas.Ef.SqlServer.AggregateRootMap<TeamsPo> {
        /// <summary>
        /// 映射表
        /// </summary>
        protected override void MapTable( EntityTypeBuilder<TeamsPo> builder ) {
            builder.ToTable( "Teams", "dbo" );
        }
        
        /// <summary>
        /// 映射属性
        /// </summary>
        protected override void MapProperties( EntityTypeBuilder<TeamsPo> builder ) {
            //
            builder.Property(t => t.Id)
                .HasColumnName("ID")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
