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
    public partial class RegularDataBindingDemo : ContentPage
    {
        public RegularDataBindingDemo()
        {
            InitializeComponent();

            Model.Student student = new Model.Student()
            {
                StudentId = 1,
                Age = 20,
                DateofBirth = new DateTime(2001, 11,11),
                FirstName = "Nusrat",
                LastName = "Israt",
                PhoneNo = "01125252512",
            };


            this.BindingContext = student;

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Model.Student student = (Model.Student)this.BindingContext;
        }
    }
}