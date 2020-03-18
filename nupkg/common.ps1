# Paths
$packFolder = (Get-Item -Path "./" -Verbose).FullName
$rootFolder = Join-Path $packFolder "../"

# List of projects
$projects = (

    "src/EasyAbp.UniappManagement.Application",
    "src/EasyAbp.UniappManagement.Application.Contracts",
    "src/EasyAbp.UniappManagement.Domain",
    "src/EasyAbp.UniappManagement.Domain.Shared",
    "src/EasyAbp.UniappManagement.EntityFrameworkCore",
    "src/EasyAbp.UniappManagement.HttpApi",
    "src/EasyAbp.UniappManagement.HttpApi.Client",
    "src/EasyAbp.UniappManagement.MongoDB",
    "src/EasyAbp.UniappManagement.Web"
)