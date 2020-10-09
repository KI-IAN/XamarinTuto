using System;
using System.Collections.Generic;
using System.Text;

namespace DataBindingDemo.MultiMenu.Model
{
    public class MenusVM
    {
        //Main Menu
        public NavigationMenuVM MainMenu { get; set; }

        //List of Submenus
        public List<NavigationMenuVM> SubMenus { get; set; }

    }
}
