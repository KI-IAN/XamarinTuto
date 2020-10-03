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
    public partial class MasterDetailPageView : MasterDetailPage
    {
        public MasterDetailPageView()
        {
            InitializeComponent();

            masterView.menuItemlv.ItemSelected += MenuItemlv_ItemSelected;
        }

        private void MenuItemlv_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem is MDP.Model.NavigationMenuItem item)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.PageType));
                IsPresented = false;

            }
        }
    }
}