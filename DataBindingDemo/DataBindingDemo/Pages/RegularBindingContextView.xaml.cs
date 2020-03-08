using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBindingDemo.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DataBindingDemo.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegularBindingContextView : ContentPage
    {

        private Model.Student Student = null;

        public RegularBindingContextView()
        {
            InitializeComponent();


            #region Binding Object

            Student = new Model.Student()
            {
                FirstName = "Mashrafee",
                LastName = "Mortaza",
                DateofBirth = new DateTime(1986, 5, 5),
                PhoneNo = "01715101214",
                StudentId = 1,
            };


            #endregion


            //gridStudent.BindingContext = student;

            this.BindingContext = Student;

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //Model.Student studentData = (Student)this.BindingContext;
        }
    }
}