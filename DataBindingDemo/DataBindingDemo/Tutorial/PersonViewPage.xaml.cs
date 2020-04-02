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
    public partial class PersonViewPage : ContentPage
    {

        private Model.PersonViewModel _personData;


        public PersonViewPage()
        {
            InitializeComponent();

            _personData = new Model.PersonViewModel()
            {
                FirstName = "ABC",
                LastName = "EFG",
            };

            this.BindingContext = _personData;

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            _personData.FullName = $"{_personData.FirstName} {_personData.LastName}";
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            _personData.FullName = $"{_personData.FirstName} {_personData.LastName}";
        }

        private void Entry_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            _personData.FullName = $"{_personData.FirstName} {_personData.LastName}";
        }
    }
}