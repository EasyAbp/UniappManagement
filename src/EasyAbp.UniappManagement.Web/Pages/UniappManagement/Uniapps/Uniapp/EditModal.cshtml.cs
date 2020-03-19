using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EasyAbp.UniappManagement.Uniapps;
using EasyAbp.UniappManagement.Uniapps.Dtos;
using EasyAbp.UniappManagement.Web.Pages.UniappManagement.Uniapps.Uniapp.ViewModels;

namespace EasyAbp.UniappManagement.Web.Pages.UniappManagement.Uniapps.Uniapp
{
    public class EditModalModel : UniappManagementPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateUpdateUniappViewModel Uniapp { get; set; }

        private readonly IUniappAppService _service;

        public EditModalModel(IUniappAppService service)
        {
            _service = service;
        }

        public async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            Uniapp = ObjectMapper.Map<UniappDto, CreateUpdateUniappViewModel>(dto);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _service.UpdateAsync(Id,
                ObjectMapper.Map<CreateUpdateUniappViewModel, CreateUpdateUniappDto>(Uniapp));
            return NoContent();
        }
    }
}