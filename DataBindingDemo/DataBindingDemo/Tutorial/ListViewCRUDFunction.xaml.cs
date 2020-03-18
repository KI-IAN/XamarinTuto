using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DataBindingDemo.Tutorial
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewCRUDFunction : ContentPage
    {

        ObservableCollection<Model.Student> studentData = new ObservableCollection<Model.Student>();

        public ListViewCRUDFunction()
        {
            InitializeComponent();                      //Initialize all the components of the page
                
            GetStudents();                              //Call the function to generate some dummy data

            lvStudent.ItemsSource = studentData;        //Initialize Listview item source
        }


        /// <summary>
        /// Generate some dummy data for ListView
        /// </summary>
        private void GetStudents()
        {

            for (int i = 0; i < 5; i++)
            {
                studentData.Add(new Model.Student()
                {
                    StudentId = i,
                    FirstName = $"First Name#{i}",
                    LastName = $"Last Name#{i}",
                    Age = i + 23,
                    PhoneNo = $"01{i}{new Random().Next(100000, 999999)}",  //Generate random phone number 
                });

            }

        }





        private async void DeleteItem(object sender, EventArgs e)
        {
            var DeleteButton = (ImageButton)sender;  //Converting sender as Button

            var bindingContext = DeleteButton.BindingContext;       //Get the current binding context/ source of the button

            var cellData = (Model.Student)bindingContext;       //Now convert the current binding context to appropriate model

            //These three lines of code can be written in one line as following:
            //var cellData = (Model.Student)((Button)sender).BindingContext;

            var isDeleted = studentData.Remove(cellData);

            #region Show Delete Confirmation

            //You can show delete confirmation diaglog following way if you wish to do so


            //if (isDeleted)
            //{
            //    await DisplayAlert("Delete", "Item is deleted", "Close");
            //}
            //else
            //{
            //    await DisplayAlert("Delete", "Item could not be deleted", "Close");

            //}

            #endregion

        }
    }
}