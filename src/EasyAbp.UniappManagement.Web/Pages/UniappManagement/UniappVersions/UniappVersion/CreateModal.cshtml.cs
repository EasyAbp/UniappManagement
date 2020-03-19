using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EasyAbp.UniappManagement.UniappVersions;
using EasyAbp.UniappManagement.UniappVersions.Dtos;
using EasyAbp.UniappManagement.Web.Pages.UniappManagement.UniappVersions.UniappVersion.ViewModels;

namespace EasyAbp.UniappManagement.Web.Pages.UniappManagement.UniappVersions.UniappVersion
{
    public class CreateModalModel : UniappManagementPageModel
    {
        [BindProperty]
        public CreateUpdateUniappVersionViewModel UniappVersion { get; set; }

        private readonly IUniappVersionAppService _service;

        public CreateModalModel(IUniappVersionAppService service)
        {
            _service = service;
        }

        public Task OnGetAsync(Guid appId)
        {
            UniappVersion = new CreateUpdateUniappVersionViewModel
            {
                AppId = appId
            };

            return Task.CompletedTask;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _service.CreateAsync(
                ObjectMapper.Map<CreateUpdateUniappVersionViewModel, CreateUpdateUniappVersionDto>(UniappVersion));
            return NoContent();
        }
    }
}