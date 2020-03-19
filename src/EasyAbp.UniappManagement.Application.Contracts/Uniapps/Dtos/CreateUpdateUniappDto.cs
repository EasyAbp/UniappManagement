using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EasyAbp.UniappManagement.Uniapps.Dtos
{
    public class CreateUpdateUniappDto
    {
        [Required]
        [DisplayName("UniappName")]
        public string Name { get; set; }

        [DisplayName("UniappDescription")]
        public string Description { get; set; }

        [Url]
        [DisplayName("UniappIconImageUrl")]
        public string IconImageUrl { get; set; }

        [DisplayName("UniappIsAvailable")]
        public bool IsAvailable { get; set; }
    }
}