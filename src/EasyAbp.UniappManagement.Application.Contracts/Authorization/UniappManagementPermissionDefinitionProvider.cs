using EasyAbp.UniappManagement.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace EasyAbp.UniappManagement.Authorization
{
    public class UniappManagementPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var uniappManagementGroup = context.AddGroup(UniappManagementPermissions.GroupName, L("Permission:UniappManagement"));
            
            var uniapps = uniappManagementGroup.AddPermission(UniappManagementPermissions.Uniapps.Default, L("Permission:Uniapps"));
            uniapps.AddChild(UniappManagementPermissions.Uniapps.Update, L("Permission:Edit"));
            uniapps.AddChild(UniappManagementPermissions.Uniapps.Delete, L("Permission:Delete"));
            uniapps.AddChild(UniappManagementPermissions.Uniapps.Create, L("Permission:Create"));
            
            var uniappVersions = uniappManagementGroup.AddPermission(UniappManagementPermissions.UniappVersions.Default, L("Permission:UniappVersions"));
            uniappVersions.AddChild(UniappManagementPermissions.UniappVersions.Update, L("Permission:Edit"));
            uniappVersions.AddChild(UniappManagementPermissions.UniappVersions.Delete, L("Permission:Delete"));
            uniappVersions.AddChild(UniappManagementPermissions.UniappVersions.Create, L("Permission:Create"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<UniappManagementResource>(name);
        }
    }
}