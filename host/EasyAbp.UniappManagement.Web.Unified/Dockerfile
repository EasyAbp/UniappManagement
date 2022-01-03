#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["host/EasyAbp.UniappManagement.Web.Unified/EasyAbp.UniappManagement.Web.Unified.csproj", "host/EasyAbp.UniappManagement.Web.Unified/"]
COPY ["host/EasyAbp.UniappManagement.Host.Shared/EasyAbp.UniappManagement.Host.Shared.csproj", "host/EasyAbp.UniappManagement.Host.Shared/"]
COPY ["src/EasyAbp.UniappManagement.Web/EasyAbp.UniappManagement.Web.csproj", "src/EasyAbp.UniappManagement.Web/"]
COPY ["src/EasyAbp.UniappManagement.HttpApi/EasyAbp.UniappManagement.HttpApi.csproj", "src/EasyAbp.UniappManagement.HttpApi/"]
COPY ["src/EasyAbp.UniappManagement.Application.Contracts/EasyAbp.UniappManagement.Application.Contracts.csproj", "src/EasyAbp.UniappManagement.Application.Contracts/"]
COPY ["src/EasyAbp.UniappManagement.Domain.Shared/EasyAbp.UniappManagement.Domain.Shared.csproj", "src/EasyAbp.UniappManagement.Domain.Shared/"]
COPY ["src/EasyAbp.UniappManagement.Application/EasyAbp.UniappManagement.Application.csproj", "src/EasyAbp.UniappManagement.Application/"]
COPY ["src/EasyAbp.UniappManagement.Domain/EasyAbp.UniappManagement.Domain.csproj", "src/EasyAbp.UniappManagement.Domain/"]
COPY ["src/EasyAbp.UniappManagement.EntityFrameworkCore/EasyAbp.UniappManagement.EntityFrameworkCore.csproj", "src/EasyAbp.UniappManagement.EntityFrameworkCore/"]
COPY Directory.Build.props .
RUN dotnet restore "host/EasyAbp.UniappManagement.Web.Unified/EasyAbp.UniappManagement.Web.Unified.csproj"
COPY . .
WORKDIR "/src/host/EasyAbp.UniappManagement.Web.Unified"
RUN dotnet build "EasyAbp.UniappManagement.Web.Unified.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "EasyAbp.UniappManagement.Web.Unified.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "EasyAbp.UniappManagement.Web.Unified.dll"]
