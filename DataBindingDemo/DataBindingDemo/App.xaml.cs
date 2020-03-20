using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DataBindingDemo
{
    public partial class App : Application
    {
        public App()
        {
            //One more unpushed comment
            InitializeComponent();

            //Test Changes
            MainPage = new Tutorial.ListViewMVVM();

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
