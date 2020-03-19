using System;
using Volo.Abp;
using Volo.Abp.ExceptionHandling;

namespace EasyAbp.UniappManagement.UniappVersions
{
    public class UniappNotFoundException : BusinessException
    {
        public UniappNotFoundException(Guid appId) : base(message: $"Uniapp not found: {appId}")
        {
        }
        
        public UniappNotFoundException(string appName) : base(message: $"Uniapp not found: {appName}")
        {
        }
    }
}