using EasyAbp.UniappManagement.Uniapps.Dtos;
using EasyAbp.UniappManagement.UniappVersions.Dtos;
using AutoMapper;
using EasyAbp.UniappManagement.Web.Pages.UniappManagement.Uniapps.Uniapp.ViewModels;
using EasyAbp.UniappManagement.Web.Pages.UniappManagement.UniappVersions.UniappVersion.ViewModels;

namespace EasyAbp.UniappManagement.Web
{
    public class UniappManagementWebAutoMapperProfile : Profile
    {
        public UniappManagementWebAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<UniappDto, CreateUpdateUniappViewModel>();
            CreateMap<CreateUpdateUniappViewModel, CreateUpdateUniappDto>();
            
            CreateMap<UniappVersionDto, CreateUpdateUniappVersionViewModel>();
            CreateMap<CreateUpdateUniappVersionViewModel, CreateUpdateUniappVersionDto>();
        }
    }
}
