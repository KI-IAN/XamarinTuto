using DataBindingDemo.MDP.Model;
using DataBindingDemo.MultiMenu.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DataBindingDemo.MDP
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPageView : ContentPage
    {
        private List<NavigationMenuItem> menuItems;

        private List<MenusVM> multiMenus;

        public MasterPageView()
        {
            InitializeComponent();

            SetMenuItems();

            menuItemlv.ItemsSource = menuItems;
        }


        private void SetMenuItems()
        {
            menuItems = new List<NavigationMenuItem>()
            {
                new NavigationMenuItem(){
                    Title = "Home",
                    Icon = "home.png",
                    PageType = typeof(MDP.HomeDetailPageView),
                },
                new NavigationMenuItem(){
                    Title = "About",
                    Icon = "about.png",
                    PageType = typeof(MDP.AboutPageDetialView),
                },
                new NavigationMenuItem(){
                    Title = "Contact",
                    Icon = "contact.png",
                    PageType = typeof(MDP.ContactDetailPageView),
                },
            };
        }


    }
}