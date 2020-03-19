using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace EasyAbp.UniappManagement.Uniapps
{
    public class UniappAppServiceTests : UniappManagementApplicationTestBase
    {
        private readonly IUniappAppService _uniappAppService;

        public UniappAppServiceTests()
        {
            _uniappAppService = GetRequiredService<IUniappAppService>();
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
