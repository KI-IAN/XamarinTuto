using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DataBindingDemo.ContentViewDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainMenuCV : ContentView
    {
        public MainMenuCV()
        {
            InitializeComponent();
        }
    }
}