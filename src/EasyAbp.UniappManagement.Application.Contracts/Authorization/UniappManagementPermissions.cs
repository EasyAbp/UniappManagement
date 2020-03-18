using Volo.Abp.Reflection;

namespace EasyAbp.UniappManagement.Authorization
{
    public class UniappManagementPermissions
    {
        public const string GroupName = "UniappManagement";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(UniappManagementPermissions));
        }
    }
}