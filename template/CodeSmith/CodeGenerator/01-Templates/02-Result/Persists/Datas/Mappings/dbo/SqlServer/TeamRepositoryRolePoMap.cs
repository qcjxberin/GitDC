using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using GitDC.Data.Pos.dbo;

namespace GitDC.Data.Mappings.dbo.SqlServer {
    /// <summary>
    /// 持久化对象映射配置
    /// </summary>
    public class TeamRepositoryRolePoMap : Ding.Datas.Ef.SqlServer.AggregateRootMap<TeamRepositoryRolePo> {
        /// <summary>
        /// 映射表
        /// </summary>
        protected override void MapTable( EntityTypeBuilder<TeamRepositoryRolePo> builder ) {
            builder.ToTable( "TeamRepositoryRole", "dbo" );
        }
        
        /// <summary>
        /// 映射属性
        /// </summary>
        protected override void MapProperties( EntityTypeBuilder<TeamRepositoryRolePo> builder ) {
            //
            builder.Property(t => t.Id)
                .HasColumnName("ID");
        }
    }
}
