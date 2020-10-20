using DataBindingDemo.SimpleSubMenu.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DataBindingDemo.SimpleSubMenu.ViewModels
{
    public class SubMenuViewModel
    {

        private ObservableCollection<GroupedMenuItem> _groupedMenuItems;

        public ObservableCollection<GroupedMenuItem> GroupedMenuItems
        {
            get { return _groupedMenuItems; }

            set { _groupedMenuItems = value; }
        }


        public SubMenuViewModel()
        {
            SetMenuItems();

        }


        #region Data 

        private void SetMenuItems()
        {
            var mainMenu_1 = new GroupedMenuItem() { LongName = "Main Menu#1", StateIcon = "arrow_down.png" };
            var mainMenu_2 = new GroupedMenuItem() { LongName = "Main Menu#2", StateIcon = "arrow_down.png" };
            var mainMenu_3 = new GroupedMenuItem() { LongName = "Main Menu#3", StateIcon = "arrow_down.png" };

            // Sub Menu
            var sub_mm_1_1 = new NavigationMenuItem() { Title = "SM 1.1", PageType = typeof(MDP.ContactDetailPageView) };
            var sub_mm_1_2 = new NavigationMenuItem() { Title = "SM 1.2", PageType = typeof(MDP.AboutPageDetialView) };

            var sub_mm_2_1 = new NavigationMenuItem() { Title = "SM 2.1", PageType = typeof(MDP.ContactDetailPageView) };
            var sub_mm_2_2 = new NavigationMenuItem() { Title = "SM 2.2", PageType = typeof(MDP.AboutPageDetialView) };
            var sub_mm_2_3 = new NavigationMenuItem() { Title = "SM 2.1", PageType = typeof(MDP.ContactDetailPageView) };

            var sub_mm_3_1 = new NavigationMenuItem() { Title = "SM 3.1", PageType = typeof(MDP.HomeDetailPageView) };

            // Attach sub menus with main Menu
            mainMenu_1.Add(sub_mm_1_1);
            mainMenu_1.Add(sub_mm_1_2);

            // Attach sub menus with main Menu
            mainMenu_2.Add(sub_mm_2_1);
            mainMenu_2.Add(sub_mm_2_2);
            mainMenu_2.Add(sub_mm_2_3);

            // Attach sub menus with main Menu
            mainMenu_3.Add(sub_mm_3_1);

            _groupedMenuItems = new ObservableCollection<GroupedMenuItem>();
            _groupedMenuItems.Add(mainMenu_1);
            _groupedMenuItems.Add(mainMenu_2);
            _groupedMenuItems.Add(mainMenu_3);

        }


        #endregion
    }
}
