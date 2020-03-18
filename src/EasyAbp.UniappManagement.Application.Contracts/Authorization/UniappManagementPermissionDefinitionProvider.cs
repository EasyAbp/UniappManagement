using EasyAbp.UniappManagement.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace EasyAbp.UniappManagement.Authorization
{
    public class UniappManagementPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            //var moduleGroup = context.AddGroup(UniappManagementPermissions.GroupName, L("Permission:UniappManagement"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<UniappManagementResource>(name);
        }
    }
}