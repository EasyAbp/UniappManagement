using System;
using EasyAbp.UniappManagement.Uniapps;
using Volo.Abp;
using Volo.Abp.ExceptionHandling;

namespace EasyAbp.UniappManagement.UniappVersions
{
    public class UniappUnavailableException : BusinessException
    {
        public UniappUnavailableException(Uniapp uniapp) : base(message: $"Uniapp is unavailable: {uniapp.Name} {uniapp.Id}")
        {
        }
    }
}