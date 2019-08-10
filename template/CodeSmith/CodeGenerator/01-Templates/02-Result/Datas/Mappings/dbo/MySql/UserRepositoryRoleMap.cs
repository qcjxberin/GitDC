using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using GitDC.Domain.Models;

namespace GitDC.Data.Mappings.MySql {
    /// <summary>
    /// 映射配置
    /// </summary>
    public class UserRepositoryRoleMap : Ding.Datas.Ef.MySql.AggregateRootMap<UserRepositoryRole> {
        /// <summary>
        /// 映射表
        /// </summary>
        protected override void MapTable( EntityTypeBuilder<UserRepositoryRole> builder ) {
            builder.ToTable( "UserRepositoryRole" );
        }
        
        /// <summary>
        /// 映射属性
        /// </summary>
        protected override void MapProperties( EntityTypeBuilder<UserRepositoryRole> builder ) {
            //
            builder.Property(t => t.Id)
                .HasColumnName("ID");
        }
    }
}
