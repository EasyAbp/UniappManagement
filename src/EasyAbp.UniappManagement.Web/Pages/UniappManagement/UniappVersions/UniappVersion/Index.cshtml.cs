using System;
using System.Threading.Tasks;
using EasyAbp.UniappManagement.Uniapps;
using EasyAbp.UniappManagement.Uniapps.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace EasyAbp.UniappManagement.Web.Pages.UniappManagement.UniappVersions.UniappVersion
{
    public class IndexModel : UniappManagementPageModel
    {
        private readonly IUniappAppService _uniappAppService;

        [BindProperty(SupportsGet = true)]
        public Guid AppId { get; set; }
        
        [BindProperty]
        public UniappDto Uniapp { get; set; }

        public IndexModel(
            IUniappAppService uniappAppService)
        {
            _uniappAppService = uniappAppService;
        }
        
        public async Task OnGetAsync()
        {
            Uniapp = await _uniappAppService.GetAsync(AppId);
        }
    }
}
