using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using GitDC.Domain.Models;

namespace GitDC.Data.Mappings.dbo.PgSql {
    /// <summary>
    /// 映射配置
    /// </summary>
    public class SshKeysMap : Ding.Datas.Ef.PgSql.AggregateRootMap<SshKeys> {
        /// <summary>
        /// 映射表
        /// </summary>
        protected override void MapTable( EntityTypeBuilder<SshKeys> builder ) {
            builder.ToTable( "SshKeys", "dbo" );
        }
        
        /// <summary>
        /// 映射属性
        /// </summary>
        protected override void MapProperties( EntityTypeBuilder<SshKeys> builder ) {
            //
            builder.Property(t => t.Id)
                .HasColumnName("ID")
                ;
        }
    }
}
