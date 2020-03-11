using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DataBindingDemo.Tutorial
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewGenericListItem : ContentPage
    {
        public ListViewGenericListItem()
        {
            InitializeComponent();


            lvSampleName.ItemsSource = GetItem();


        }


        private List<string> GetItem()
        {

            List<string> items = new List<string>()
            {
                "Item#1",
                "Item#2",
                "Item#3",
                "Item#4",
                "Item#5",
                                "Item#1",
                "Item#2",
                "Item#3",
                "Item#4",
                "Item#5",
                                "Item#1",
                "Item#2",
                "Item#3",
                "Item#4",
                "Item#5",
                                "Item#1",
                "Item#2",
                "Item#3",
                "Item#4",
                "Item#5",
                                "Item#1",
                "Item#2",
                "Item#3",
                "Item#4",
                "Item#5",
                                "Item#1",
                "Item#2",
                "Item#3",
                "Item#4",
                "Item#5",
            };


            return items;
        }
    }
}