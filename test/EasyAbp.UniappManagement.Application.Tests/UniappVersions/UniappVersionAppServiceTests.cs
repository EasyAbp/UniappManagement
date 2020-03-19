using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace EasyAbp.UniappManagement.UniappVersions
{
    public class UniappVersionAppServiceTests : UniappManagementApplicationTestBase
    {
        private readonly IUniappVersionAppService _uniappVersionAppService;

        public UniappVersionAppServiceTests()
        {
            _uniappVersionAppService = GetRequiredService<IUniappVersionAppService>();
        }

        [Fact]
        public async Task Test1()
        {
            // Arrange

            // Act

            // Assert
        }
    }
}
