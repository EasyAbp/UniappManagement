using EasyAbp.UniappManagement.Uniapps;
using EasyAbp.UniappManagement.Uniapps.Dtos;
using EasyAbp.UniappManagement.UniappVersions;
using EasyAbp.UniappManagement.UniappVersions.Dtos;
using AutoMapper;

namespace EasyAbp.UniappManagement
{
    public class UniappManagementApplicationAutoMapperProfile : Profile
    {
        public UniappManagementApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<Uniapp, UniappDto>();
            CreateMap<CreateUpdateUniappDto, Uniapp>(MemberList.Source);
            CreateMap<UniappVersion, UniappVersionDto>();
            CreateMap<CreateUpdateUniappVersionDto, UniappVersion>(MemberList.Source);
        }
    }
}
