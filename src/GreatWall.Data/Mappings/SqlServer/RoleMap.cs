﻿using GreatWall.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GreatWall.Data.Mappings.SqlServer {
    /// <summary>
    /// 角色映射配置
    /// </summary>
    public class RoleMap : Util.Datas.Ef.SqlServer.AggregateRootMap<Role> {
        /// <summary>
        /// 映射表
        /// </summary>
        protected override void MapTable( EntityTypeBuilder<Role> builder ) {
            builder.ToTable( "Role", "Systems" );
        }
        
        /// <summary>
        /// 映射属性
        /// </summary>
        protected override void MapProperties( EntityTypeBuilder<Role> builder ) {
            //角色标识
            builder.Property(t => t.Id).HasColumnName("RoleId");
            builder.Property( t => t.Path ).HasColumnName( "Path" );
            builder.Property( t => t.Level ).HasColumnName( "Level" );
            builder.HasQueryFilter( t => t.IsDeleted == false );
        }
    }
}
