using System.Threading.Tasks;
using EasyAbp.UniappManagement.Authorization;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;
using EasyAbp.UniappManagement.Localization;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;
using EasyAbp.UniappManagement.Localization;
using Microsoft.AspNetCore.Authorization;
using Volo.Abp.UI.Navigation;

namespace EasyAbp.UniappManagement.Web
{
    public class UniappManagementMenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenu(context);
            }
        }

        private async Task ConfigureMainMenu(MenuConfigurationContext context)
        {
            var administrationMenuItem = context.Menu.GetAdministration();
            var l = context.ServiceProvider.GetRequiredService<IStringLocalizer<UniappManagementResource>>();            //Add main menu items.

            var authorizationService = context.ServiceProvider.GetRequiredService<IAuthorizationService>();

            if (await authorizationService.IsGrantedAsync(UniappManagementPermissions.Uniapps.Default))
            {
                administrationMenuItem.AddItem(
                    new ApplicationMenuItem("Uniapp", l["Menu:Uniapp"], "/UniappManagement/Uniapps/Uniapp")
                );
            }
        }
    }
}
