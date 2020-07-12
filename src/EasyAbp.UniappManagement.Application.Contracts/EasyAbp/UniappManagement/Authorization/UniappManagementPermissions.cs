using Volo.Abp.Reflection;

namespace EasyAbp.UniappManagement.Authorization
{
    public class UniappManagementPermissions
    {
        public const string GroupName = "EasyAbp.UniappManagement";

        public class Uniapps
        {
            public const string Default = GroupName + ".Uniapp";
            public const string Delete = Default + ".Delete";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
        }
        
        public class UniappVersions
        {
            public const string Default = GroupName + ".UniappVersion";
            public const string Delete = Default + ".Delete";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
        }
        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(UniappManagementPermissions));
        }
    }
}