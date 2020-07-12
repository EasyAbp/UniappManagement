using System.Collections.Generic;
using System.Threading.Tasks;
using EasyAbp.UniappManagement.Authorization;
using EasyAbp.UniappManagement.Localization;
using Volo.Abp.UI.Navigation;

namespace EasyAbp.UniappManagement.Web.Menus
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

            var uniappManagementMenuItem = new ApplicationMenuItem(UniappManagementMenus.Prefix, l["Menu:UniappManagement"]);
            
            if (await context.IsGrantedAsync(UniappManagementPermissions.Uniapps.Default))
            {
                uniappManagementMenuItem.AddItem(
                    new ApplicationMenuItem(UniappManagementMenus.Uniapp, l["Menu:Uniapp"], "/UniappManagement/Uniapps/Uniapp")
                );
            }

            if (!uniappManagementMenuItem.Items.IsNullOrEmpty())
            {
                context.Menu.AddItem(uniappManagementMenuItem);
            }
        }
    }
}
