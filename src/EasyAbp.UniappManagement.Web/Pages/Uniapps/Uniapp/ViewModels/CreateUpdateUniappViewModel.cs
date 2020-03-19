using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EasyAbp.UniappManagement.Web.Pages.Uniapps.Uniapp.ViewModels
{
    public class CreateUpdateUniappViewModel
    {
        [Required]
        [Display(Name="UniappName")]
        public string Name { get; set; }

        [Display(Name="UniappDescription")]
        public string Description { get; set; }

        [Url]
        [Display(Name="UniappIconImageUrl")]
        public string IconImageUrl { get; set; }

        [Display(Name="UniappIsAvailable")]
        public bool IsAvailable { get; set; }
    }
}