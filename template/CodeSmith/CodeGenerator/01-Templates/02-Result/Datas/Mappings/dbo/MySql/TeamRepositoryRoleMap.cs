using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using GitDC.Domain.Models;

namespace GitDC.Data.Mappings.MySql {
    /// <summary>
    /// 映射配置
    /// </summary>
    public class TeamRepositoryRoleMap : Ding.Datas.Ef.MySql.AggregateRootMap<TeamRepositoryRole> {
        /// <summary>
        /// 映射表
        /// </summary>
        protected override void MapTable( EntityTypeBuilder<TeamRepositoryRole> builder ) {
            builder.ToTable( "TeamRepositoryRole" );
        }
        
        /// <summary>
        /// 映射属性
        /// </summary>
        protected override void MapProperties( EntityTypeBuilder<TeamRepositoryRole> builder ) {
            //
            builder.Property(t => t.Id)
                .HasColumnName("ID");
        }
    }
}
