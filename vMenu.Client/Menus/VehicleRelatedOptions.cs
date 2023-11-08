using CitizenFX.Core;
using CitizenFX.Core.Native;
using static CitizenFX.Core.Native.API;
using ScaleformUI.Elements;
using ScaleformUI.Menu;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vMenu.Client.Functions;
using vMenu.Client.MenuSettings;

namespace vMenu.Client.Menus
{
    public class VehicleRelatedOptions : BaseScript
    {
        public static MenuFunctions MenuFunctions = new MenuFunctions();

        private static UIMenu vehicleRelatedOptions = null;

        public VehicleRelatedOptions()
        {
            vehicleRelatedOptions = new UIMenu(Main.MenuBanner.BannerTitle, "Vehicle Related Options", MenuFunctions.GetMenuOffset(), Main.MenuBanner.TextureDictionary, Main.MenuBanner.TextureName, menuSettings.Glare, menuSettings.AlternativeTitle, menuSettings.fadingTime)
            {
                MaxItemsOnScreen = menuSettings.maxItemsOnScreen,
                BuildingAnimation = menuSettings.buildingAnimation,
                ScrollingType = menuSettings.scrollingType,
                Enabled3DAnimations = menuSettings.enabled3DAnimations,
                MouseControlsEnabled = menuSettings.mouseControlsEnabled,
                ControlDisablingEnabled = menuSettings.controlDisablingEnabled,
                EnableAnimation = menuSettings.enableAnimation,
            };
            UIMenuItem button = new UIMenuItem("~r~~h~Under Construction!~h~", "", menuSettings.BackgroundColor, menuSettings.HighlightColor);

            vehicleRelatedOptions.AddItem(button);

            Main.Menus.Add(vehicleRelatedOptions);
        }

        public static UIMenu Menu()
        {
            return vehicleRelatedOptions;
        }
    }
}