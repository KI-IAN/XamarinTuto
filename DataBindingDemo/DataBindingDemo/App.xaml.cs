using DataBindingDemo.ContentViewDemo;
using DataBindingDemo.MDP;
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
            //MainPage = new Tutorial.PersonViewPage();
            MainPage = new MasterDetailPageView();
            //MainPage = new SampleChart();
            //MainPage = new SimpleSubMenu.Views.SubMenuPage();
            //MainPage = new ListViewDemo.ListViewDemos();
            //MainPage = new ContentViewDemoNew.CVPageDemo();
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
