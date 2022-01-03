# UniappManagement

[![ABP version](https://img.shields.io/badge/dynamic/xml?style=flat-square&color=yellow&label=abp&query=%2F%2FProject%2FPropertyGroup%2FAbpVersion&url=https%3A%2F%2Fraw.githubusercontent.com%2FEasyAbp%2FUniappManagement%2Fmaster%2FDirectory.Build.props)](https://abp.io)
[![NuGet](https://img.shields.io/nuget/v/EasyAbp.UniappManagement.Domain.Shared.svg?style=flat-square)](https://www.nuget.org/packages/EasyAbp.UniappManagement.Domain.Shared)
[![NuGet Download](https://img.shields.io/nuget/dt/EasyAbp.UniappManagement.Domain.Shared.svg?style=flat-square)](https://www.nuget.org/packages/EasyAbp.UniappManagement.Domain.Shared)
[![Discord online](https://badgen.net/discord/online-members/S6QaezrCRq?label=Discord)](https://discord.gg/S6QaezrCRq)
[![GitHub stars](https://img.shields.io/github/stars/EasyAbp/UniappManagement?style=social)](https://www.github.com/EasyAbp/UniappManagement)

实现uni-app的应用版本管理、整包更新、热更新、差量热更新等功能的Abp应用模块

## Online Demo

We have launched an online demo for this module: [https://uniapp.samples.easyabp.io](https://uniapp.samples.easyabp.io)

## Installation

1. Install the following NuGet packages. ([see how](https://github.com/EasyAbp/EasyAbpGuide/blob/master/docs/How-To.md#add-nuget-packages))

    * EasyAbp.UniappManagement.Application
    * EasyAbp.UniappManagement.Application.Contracts
    * EasyAbp.UniappManagement.Domain
    * EasyAbp.UniappManagement.Domain.Shared
    * EasyAbp.UniappManagement.EntityFrameworkCore
    * EasyAbp.UniappManagement.HttpApi
    * EasyAbp.UniappManagement.HttpApi.Client
    * (Optional) EasyAbp.UniappManagement.MongoDB
    * (Optional) EasyAbp.UniappManagement.Web

1. Add `DependsOn(typeof(UniappManagementXxxModule))` attribute to configure the module dependencies. ([see how](https://github.com/EasyAbp/EasyAbpGuide/blob/master/docs/How-To.md#add-module-dependencies))

1. Add `builder.ConfigureUniappManagement();` to the `OnModelCreating()` method in **MyProjectMigrationsDbContext.cs**.

1. Add EF Core migrations and update your database. See: [ABP document](https://docs.abp.io/en/abp/latest/Tutorials/Part-1?UI=MVC&DB=EF#add-database-migration).

## Usage

1. Add permissions to the roles you want.

1. Enjoy this wonderful module.

![Notifications](/docs/images/NewApp.png)
![AppList](/docs/images/AppList.png)
![NewVersion](/docs/images/NewVersion.png)
![VersionList](/docs/images/VersionList.png)
![WebApis](/docs/images/WebApis.png)

## Roadmap

- [ ] Add cache.
- [ ] Unit tests.
