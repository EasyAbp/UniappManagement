using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EasyAbp.UniappManagement.UniappVersions;
using EasyAbp.UniappManagement.UniappVersions.Dtos;
using EasyAbp.UniappManagement.Web.Pages.UniappVersions.UniappVersion.ViewModels;

namespace EasyAbp.UniappManagement.Web.Pages.UniappVersions.UniappVersion
{
    public class EditModalModel : UniappManagementPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateUpdateUniappVersionViewModel UniappVersion { get; set; }

        private readonly IUniappVersionAppService _service;

        public EditModalModel(IUniappVersionAppService service)
        {
            _service = service;
        }

        public async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            UniappVersion = ObjectMapper.Map<UniappVersionDto, CreateUpdateUniappVersionViewModel>(dto);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _service.UpdateAsync(Id,
                ObjectMapper.Map<CreateUpdateUniappVersionViewModel, CreateUpdateUniappVersionDto>(UniappVersion));
            return NoContent();
        }
    }
}