using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace EasyAbp.UniappManagement.Web.Pages.UniappVersions.UniappVersion.ViewModels
{
    public class CreateUpdateUniappVersionViewModel
    {
        [HiddenInput]
        [Display(Name="UniappVersionAppId")]
        public Guid AppId { get; set; }

        [Display(Name="UniappVersionBuildNumber")]
        public long BuildNumber { get; set; }

        [Required]
        [Display(Name="UniappVersionTag")]
        public string Tag { get; set; }

        [Url]
        [Display(Name="UniappVersionWgtUrl")]
        public string WgtUrl { get; set; }

        [Url]
        [Display(Name="UniappVersionPkgUrl")]
        public string PkgUrl { get; set; }

        [DefaultValue(true)]
        [Display(Name="UniappVersionIsLatest")]
        public bool IsLatest { get; set; }
    }
}