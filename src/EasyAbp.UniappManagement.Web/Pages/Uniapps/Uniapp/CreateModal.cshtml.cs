using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EasyAbp.UniappManagement.Uniapps;
using EasyAbp.UniappManagement.Uniapps.Dtos;
using EasyAbp.UniappManagement.Web.Pages.Uniapps.Uniapp.ViewModels;

namespace EasyAbp.UniappManagement.Web.Pages.Uniapps.Uniapp
{
    public class CreateModalModel : UniappManagementPageModel
    {
        [BindProperty]
        public CreateUpdateUniappViewModel Uniapp { get; set; }

        private readonly IUniappAppService _service;

        public CreateModalModel(IUniappAppService service)
        {
            _service = service;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _service.CreateAsync(ObjectMapper.Map<CreateUpdateUniappViewModel, CreateUpdateUniappDto>(Uniapp));
            return NoContent();
        }
    }
}