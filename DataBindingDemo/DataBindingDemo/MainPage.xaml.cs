using DataBindingDemo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DataBindingDemo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        private PieTest PieData  { get; set; }

        public MainPage()
        {
            InitializeComponent();



            #region Binding Context on Page Level

            PieData = new PieTest()
            {
                Id = 2,
                PieName = "Orange Pie (Binding Context; Page Level)",
                Price = 44,
            };

            this.BindingContext = PieData;

            #endregion





        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            PieData.Price = PieData.Price + 3;
        }
    }
}
