using DataBindingDemo.SimpleSubMenu.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DataBindingDemo.SimpleSubMenu.ViewModels
{
    public class SubMenuViewModel : INotifyPropertyChanged
    {

        private ObservableCollection<GroupedMenuItem> _groupedMenuItems;


        #region Implement INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPreopertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion


        public ObservableCollection<GroupedMenuItem> GroupedMenuItems
        {
            get { return _groupedMenuItems; }

            set
            {
                _groupedMenuItems = value;
                OnPreopertyChanged();
            }
        }

        public ICommand TapMenu { get; set; }

        public SubMenuViewModel()
        {
            SetMenuItems();

            TapMenu = new Command<GroupedMenuItem>((data) => TapMenuHandler(data));

        }


        private void TapMenuHandler(GroupedMenuItem menu)
        {
            //Reload menu
            SetMenuItems();

            menu.IsExpanded = !menu.IsExpanded;

            // When menu is closed; open the selected menu and close all other menus
            if (menu.IsExpanded)
            {
                var selectedMenu = _groupedMenuItems.Where(r => r.LongName.Equals(menu.LongName, StringComparison.OrdinalIgnoreCase))
                                    .FirstOrDefault();
                selectedMenu.StateIcon = "arrow_down.png";
                selectedMenu.IsExpanded = menu.IsExpanded;

                var unSelectedMenu = _groupedMenuItems.Where(r => !r.LongName.Equals(menu.LongName, StringComparison.OrdinalIgnoreCase));


                foreach (var closedMenu in unSelectedMenu)
                {
                    closedMenu.StateIcon = "arrow_up.png";
                    closedMenu.IsExpanded = false;

                    //remove sub menus from those main menus to simulate collapsing
                    closedMenu.Clear();
                }
            }
            else
            {
                foreach (var closedMenus in _groupedMenuItems)
                {
                    closedMenus.StateIcon = "arrow_up.png";
                    closedMenus.IsExpanded = false;

                    //remove sub menus from those main menus to simulate collapsing
                    closedMenus.Clear();
                }
            }

            GroupedMenuItems = _groupedMenuItems;


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
