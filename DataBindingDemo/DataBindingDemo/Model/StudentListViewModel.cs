using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DataBindingDemo.Model
{
    public class StudentListViewModel
    {

        ObservableCollection<Model.StudentViewModel> _studentList;

        public ObservableCollection<Model.StudentViewModel> StudentList
        {
            get
            {
                _studentList = new ObservableCollection<StudentViewModel>(GetAllStudent());
                return _studentList;
            }
        }



        #region Repository

        private List<Model.StudentViewModel> GetAllStudent()
        {

            List<StudentViewModel> studentData = new List<StudentViewModel>();

            for (int i = 0; i < 5; i++)
            {
                studentData.Add(new Model.StudentViewModel()
                {
                    StudentId = new Random().Next(1000, 9999),
                    FirstName = $"First Name#{i}",
                    LastName = $"Last Name#{i}",
                    Age = new Random().Next(20, 40),
                    PhoneNo = $"01{i}{new Random().Next(100000, 999999)}",  //Generate random phone number 
                    TotalLike = new Random().Next(0, 999),
                    TotalDislike = new Random().Next(0, 999),
                });

            }

            return studentData;
        }

        #endregion

    }
}
