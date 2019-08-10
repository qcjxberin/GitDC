using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using GitDC.Domain.Models;

namespace GitDC.Data.Mappings.dbo.SqlServer {
    /// <summary>
    /// 用户名映射配置
    /// </summary>
    public class UsersMap : Ding.Datas.Ef.SqlServer.AggregateRootMap<Users> {
        /// <summary>
        /// 映射表
        /// </summary>
        protected override void MapTable( EntityTypeBuilder<Users> builder ) {
            builder.ToTable( "Users", "dbo" );
        }
        
        /// <summary>
        /// 映射属性
        /// </summary>
        protected override void MapProperties( EntityTypeBuilder<Users> builder ) {
            //编号
            builder.Property(t => t.Id)
                .HasColumnName("ID")
                ;
            builder.HasQueryFilter( t => t.IsDeleted == false );
        }
    }
}
