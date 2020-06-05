using System.Collections.Generic;
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
            var l = context.GetLocalizer<UniappManagementResource>();            //Add main menu items.

            var authorizationService = context.ServiceProvider.GetRequiredService<IAuthorizationService>();

            var uniappManagementMenuItem = new ApplicationMenuItem("UniappManagement", l["Menu:UniappManagement"]);
            
            if (await authorizationService.IsGrantedAsync(UniappManagementPermissions.Uniapps.Default))
            {
                uniappManagementMenuItem.AddItem(
                    new ApplicationMenuItem("Uniapp", l["Menu:Uniapps"], "/UniappManagement/Uniapps/Uniapp")
                );
            }

            if (!uniappManagementMenuItem.Items.IsNullOrEmpty())
            {
                context.Menu.AddItem(uniappManagementMenuItem);
            }
        }
    }
}
