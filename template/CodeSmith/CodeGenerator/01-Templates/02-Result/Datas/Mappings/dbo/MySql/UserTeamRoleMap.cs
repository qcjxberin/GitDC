using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using GitDC.Domain.Models;

namespace GitDC.Data.Mappings.MySql {
    /// <summary>
    /// 映射配置
    /// </summary>
    public class UserTeamRoleMap : Ding.Datas.Ef.MySql.AggregateRootMap<UserTeamRole> {
        /// <summary>
        /// 映射表
        /// </summary>
        protected override void MapTable( EntityTypeBuilder<UserTeamRole> builder ) {
            builder.ToTable( "UserTeamRole" );
        }
        
        /// <summary>
        /// 映射属性
        /// </summary>
        protected override void MapProperties( EntityTypeBuilder<UserTeamRole> builder ) {
            //
            builder.Property(t => t.Id)
                .HasColumnName("ID");
        }
    }
}
