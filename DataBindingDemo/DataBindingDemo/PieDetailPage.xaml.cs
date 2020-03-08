using DataBindingDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DataBindingDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PieDetailPage : ContentPage
    {

        public Pie Pie { get; set; }


        public PieDetailPage(Pie pie)
        {
            InitializeComponent();

            this.Pie = pie;

            this.BindingContext = Pie;
        }


        private async void SavePieButton_OnClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Success", "Pie saved", "Done");
        }

    }
}