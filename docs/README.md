# UniappManagement

[![NuGet](https://img.shields.io/nuget/v/EasyAbp.UniappManagement.Domain.Shared.svg?style=flat-square)](https://www.nuget.org/packages/EasyAbp.UniappManagement.Domain.Shared)
[![NuGet Download](https://img.shields.io/nuget/dt/EasyAbp.UniappManagement.Domain.Shared.svg?style=flat-square)](https://www.nuget.org/packages/EasyAbp.UniappManagement.Domain.Shared)

实现uni-app的应用版本管理、整包更新、热更新、差量热更新等功能的Abp应用模块

## Getting Started

* Install with [AbpHelper](https://github.com/EasyAbp/AbpHelper.GUI)

    Coming soon.

* Install Manually

    1. Install `EasyAbp.UniappManagement.Application` NuGet package to `MyProject.Application` project and add `[DependsOn(UniappManagementApplicationModule)]` attribute to the module.

    1. Install `EasyAbp.UniappManagement.Application.Contracts` NuGet package to `MyProject.Application.Contracts` project and add `[DependsOn(UniappManagementApplicationContractsModule)]` attribute to the module.

    1. Install `EasyAbp.UniappManagement.Domain` NuGet package to `MyProject.Domain` project and add `[DependsOn(UniappManagementDomainModule)]` attribute to the module.

    1. Install `EasyAbp.UniappManagement.Domain.Shared` NuGet package to `MyProject.Domain.Shared` project and add `[DependsOn(UniappManagementDomainSharedModule)]` attribute to the module.

    1. Install `EasyAbp.UniappManagement.EntityFrameworkCore` NuGet package to `MyProject.EntityFrameworkCore` project and add `[DependsOn(UniappManagementEntityFrameworkCoreModule)]` attribute to the module.

    1. Install `EasyAbp.UniappManagement.HttpApi` NuGet package to `MyProject.HttpApi` project and add `[DependsOn(UniappManagementHttpApiModule)]` attribute to the module.

    1. Install `EasyAbp.UniappManagement.HttpApi.Client` NuGet package to `MyProject.HttpApi.Client` project and add `[DependsOn(UniappManagementHttpApiClientModule)]` attribute to the module.

    1. Install `EasyAbp.UniappManagement.MongoDB` NuGet package to `MyProject.MongoDB` project and add `[DependsOn(UniappManagementMongoDbModule)]` attribute to the module.

    1. (Optional) If you need MVC UI, install `EasyAbp.UniappManagement.Web` NuGet package to `MyProject.Web` project and add `[DependsOn(UniappManagementWebModule)]` attribute to the module.
    
    1. Add `builder.ConfigureUniappManagement();` to OnModelCreating method in `MyProjectMigrationsDbContext.cs`.

    1. Add EF Core migrations and update your database. See: [ABP document](https://docs.abp.io/en/abp/latest/Tutorials/Part-1?UI=MVC#add-new-migration-update-the-database).

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
