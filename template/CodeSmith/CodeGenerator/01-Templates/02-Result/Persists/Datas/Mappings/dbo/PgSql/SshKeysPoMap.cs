using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using GitDC.Data.Pos.dbo;

namespace GitDC.Data.Mappings.dbo.PgSql {
    /// <summary>
    /// 持久化对象映射配置
    /// </summary>
    public class SshKeysPoMap : Ding.Datas.Ef.PgSql.AggregateRootMap<SshKeysPo> {
        /// <summary>
        /// 映射表
        /// </summary>
        protected override void MapTable( EntityTypeBuilder<SshKeysPo> builder ) {
            builder.ToTable( "SshKeys", "dbo" );
        }
        
        /// <summary>
        /// 映射属性
        /// </summary>
        protected override void MapProperties( EntityTypeBuilder<SshKeysPo> builder ) {
            //
            builder.Property(t => t.Id)
                .HasColumnName("ID")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
