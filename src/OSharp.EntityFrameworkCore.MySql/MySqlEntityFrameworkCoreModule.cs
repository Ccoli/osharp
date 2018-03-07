﻿// -----------------------------------------------------------------------
//  <copyright file="MySqlEntityFrameworkCoreModule.cs" company="OSharp开源团队">
//      Copyright (c) 2014-2018 OSharp. All rights reserved.
//  </copyright>
//  <site>http://www.osharp.org</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2018-03-07 21:47</last-date>
// -----------------------------------------------------------------------

using Microsoft.Extensions.DependencyInjection;

using OSharp.Core;
using OSharp.Core.Modules;


namespace OSharp.Entity.MySql
{
    /// <summary>
    /// MySqlEntityFrameworkCore模块
    /// </summary>
    [DependsOn(typeof(EntityFrameworkCoreModule))]
    public class MySqlEntityFrameworkCoreModule : OSharpModule
    {
        /// <summary>
        /// 将模块服务添加到依赖注入服务容器中
        /// </summary>
        /// <param name="services">依赖注入服务容器</param>
        /// <returns></returns>
        public override IServiceCollection AddServices(IServiceCollection services)
        {
            services.AddSingleton<IDbContextOptionsBuilderCreator, MySqlDbContextOptionsBuilderCreator>();

            return services;
        }
    }
}