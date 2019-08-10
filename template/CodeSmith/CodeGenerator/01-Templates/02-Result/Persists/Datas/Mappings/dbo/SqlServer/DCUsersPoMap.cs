using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using GitDC.Data.Pos.dbo;

namespace GitDC.Data.Mappings.dbo.SqlServer {
    /// <summary>
    /// 用户名持久化对象映射配置
    /// </summary>
    public class DCUsersPoMap : Ding.Datas.Ef.SqlServer.AggregateRootMap<DCUsersPo> {
        /// <summary>
        /// 映射表
        /// </summary>
        protected override void MapTable( EntityTypeBuilder<DCUsersPo> builder ) {
            builder.ToTable( "DC_Users", "dbo" );
        }
        
        /// <summary>
        /// 映射属性
        /// </summary>
        protected override void MapProperties( EntityTypeBuilder<DCUsersPo> builder ) {
            //编号
            builder.Property(t => t.Id)
                .HasColumnName("ID")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            builder.HasQueryFilter( t => t.IsDeleted == false );
        }
    }
}
