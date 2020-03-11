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
    public partial class ListViewModelDemo : ContentPage
    {
        public ListViewModelDemo()
        {
            InitializeComponent();

            lvStudent.ItemsSource = GetStudents();


        }


        private List<Model.Student> GetStudents()
        {

            List<Model.Student> students = new List<Model.Student>()
            {
                new Model.Student(){
                    Age = 23,
                    FirstName = "F#1",
                    LastName = "L#1",
                    StudentId = 1,
                },
                                new Model.Student(){
                    Age = 23,
                    FirstName = "F#2",
                    LastName = "L#2",
                    StudentId = 2,
                },

                                                new Model.Student(){
                    Age = 23,
                    FirstName = "F#3",
                    LastName = "L#3",
                    StudentId = 3,
                },

                                                                new Model.Student(){
                    Age = 23,
                    FirstName = "F#4",
                    LastName = "L#4",
                    StudentId = 4,
                },

                                                                                new Model.Student(){
                    Age = 23,
                    FirstName = "F#5",
                    LastName = "L#5",
                    StudentId = 5,
                },

                                                                                                new Model.Student(){
                    Age = 23,
                    FirstName = "F#6",
                    LastName = "L#6",
                    StudentId = 6,
                },

            };



            return students;

        }


    }
}