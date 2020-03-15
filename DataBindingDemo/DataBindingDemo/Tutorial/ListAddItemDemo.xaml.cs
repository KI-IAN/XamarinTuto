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
    public partial class ListAddItemDemo : ContentPage
    {

        ObservableCollection<Model.Student> studentData = new ObservableCollection<Model.Student>();

        Model.Student selectedItemOnTap;


        public ListAddItemDemo()
        {
            InitializeComponent();

            GetStudents();

            lvStudent.ItemsSource = studentData;


        }



        private void GetStudents()
        {

            //List<Model.Student> students = new List<Model.Student>();


            for (int i = 0; i < 5; i++)
            {
                studentData.Add(new Model.Student()
                {
                    StudentId = i,
                    FirstName = $"First Name#{i}",
                    LastName = $"Last Name#{i}",
                    Age = i + 23,
                });

            }

            //return studentData;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            studentData.Add(new Model.Student()
            {
                FirstName = "New Student FName",
                LastName = "New Student LName",
                Age = 43,
                StudentId = 111,

            });
        }


        private void Remove_Clicked(object sender, EventArgs e)
        {

            //studentData.RemoveAt(0);

            studentData.Remove(selectedItemOnTap);
        }

        private void lvStudent_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            try
            {
                var selectedItem = e.SelectedItem as Model.Student;

                selectedItemOnTap = selectedItem;

                //studentData.Remove(selectedItem);

                //var selectedItem2 = (Model.Student)e.SelectedItem;
            }
            catch (Exception ex)
            {
                //throw ex;
                DisplayAlert("",$"{ex.Message}","");
            }

        }

        private void lvStudent_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }
    }
}