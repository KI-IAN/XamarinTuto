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
    public partial class ListViewWithColumnHeader : ContentPage
    {


        public ListViewWithColumnHeader()
        {
            InitializeComponent();

            mainFormEntry.ItemsSource = GetStudents();
        }



        private List<Model.Student> GetStudents()
        {

            List<Model.Student> students = new List<Model.Student>();


            for (int i = 0; i < 100; i++)
            {
                students.Add(new Model.Student()
                {
                    StudentId = i,
                    FirstName = $"First Name#{i}",
                    LastName = $"Last Name#{i}",
                    Age = i + 23,
                });

            }




            return students;

        }

    }
}