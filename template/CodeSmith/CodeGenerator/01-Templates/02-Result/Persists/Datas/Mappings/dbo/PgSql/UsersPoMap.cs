using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using GitDC.Data.Pos.dbo;

namespace GitDC.Data.Mappings.dbo.PgSql {
    /// <summary>
    /// 用户名持久化对象映射配置
    /// </summary>
    public class UsersPoMap : Ding.Datas.Ef.PgSql.AggregateRootMap<UsersPo> {
        /// <summary>
        /// 映射表
        /// </summary>
        protected override void MapTable( EntityTypeBuilder<UsersPo> builder ) {
            builder.ToTable( "Users", "dbo" );
        }
        
        /// <summary>
        /// 映射属性
        /// </summary>
        protected override void MapProperties( EntityTypeBuilder<UsersPo> builder ) {
            //编号
            builder.Property(t => t.Id)
                .HasColumnName("ID")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            builder.HasQueryFilter( t => t.IsDeleted == false );
        }
    }
}
