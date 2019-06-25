﻿using GreatWall.Service.Abstractions;
using GreatWall.Service.Dtos;
using GreatWall.Service.Queries;
using Util.Webs.Controllers;

namespace GreatWall.Apis.Systems {
    /// <summary>
    /// 角色控制器
    /// </summary>
    public class RoleController : QueryControllerBase<RoleDto, RoleQuery> {
        /// <summary>
        /// 初始化角色控制器
        /// </summary>
        /// <param name="service">角色服务</param>
        public RoleController( IRoleService service ) : base( service ) {
            RoleService = service;
        }

        /// <summary>
        /// 角色服务
        /// </summary>
        public IRoleService RoleService { get; }
    }
}