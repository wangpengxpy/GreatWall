﻿using GreatWall.Data;
using GreatWall.Domain.Models;
using GreatWall.Domain.Repositories;
using GreatWall.Service.Abstractions;
using GreatWall.Service.Dtos;
using GreatWall.Service.Queries;
using Util.Applications.Trees;
using Util.Datas.Queries;
using Util.Domains.Repositories;

namespace GreatWall.Service.Implements {
    /// <summary>
    /// 角色服务
    /// </summary>
    public class RoleService : TreeServiceBase<Role, RoleDto, RoleQuery>, IRoleService {
        /// <summary>
        /// 初始化角色服务
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        /// <param name="roleRepository">角色仓储</param>
        public RoleService( IGreatWallUnitOfWork unitOfWork, IRoleRepository roleRepository )
            : base( unitOfWork, roleRepository ) {
            RoleRepository = roleRepository;
        }
        
        /// <summary>
        /// 角色仓储
        /// </summary>
        public IRoleRepository RoleRepository { get; set; }
        
        /// <summary>
        /// 创建查询对象
        /// </summary>
        /// <param name="param">查询参数</param>
        protected override IQueryBase<Role> CreateQuery( RoleQuery param ) {
            return new Query<Role>( param );
        }
    }
}