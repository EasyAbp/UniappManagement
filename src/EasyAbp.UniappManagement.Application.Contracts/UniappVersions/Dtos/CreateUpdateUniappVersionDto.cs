using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EasyAbp.UniappManagement.UniappVersions.Dtos
{
    public class CreateUpdateUniappVersionDto
    {
        [DisplayName("UniappVersionAppId")]
        public Guid AppId { get; set; }

        [DisplayName("UniappVersionBuildNumber")]
        public long BuildNumber { get; set; }

        [DisplayName("UniappVersionTag")]
        public string Tag { get; set; }

        [Url]
        [DisplayName("UniappVersionWgtUrl")]
        public string WgtUrl { get; set; }

        [Url]
        [DisplayName("UniappVersionPkgUrl")]
        public string PkgUrl { get; set; }
    }
}