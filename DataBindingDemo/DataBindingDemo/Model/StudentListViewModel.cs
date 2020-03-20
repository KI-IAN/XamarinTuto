using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DataBindingDemo.Model
{
    public class StudentListViewModel
    {

        #region Fields

        ObservableCollection<Model.StudentViewModel> _studentList;

        #endregion

        #region Properties

        public ObservableCollection<Model.StudentViewModel> StudentList
        {
            get
            {
                return _studentList;
            }

            set
            {
                _studentList = value;

            }
        }


        public Command DeleteItemCommand { get; }

        public Command HitLikeCommand { get; }

        public Command HitDislikeCommand { get; }

        #endregion



        #region Constructor


        public StudentListViewModel()
        {

            #region Initialize Data

            this.StudentList = new ObservableCollection<StudentViewModel>(GetAllStudent());

            #endregion


            #region Event Delegation

            DeleteItemCommand = new Command(async (object boundData) => await DeleteItem(boundData));

            HitLikeCommand = new Command(async (object boundData) => await HitLike(boundData));

            HitDislikeCommand = new Command(async (object boundData) => await HitDislike(boundData));

            #endregion
        }


        #endregion


        #region Command Handler Functions


        public async Task HitDislike(object boundData)
        {
            try
            {
                var selectedItem = (StudentViewModel)boundData;

                selectedItem.TotalDislike++;
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Operation could not be completed", "Close");
            }
        }



        public async Task HitLike(object boundData)
        {
            try
            {
                var selectedItem = (StudentViewModel)boundData;

                selectedItem.TotalLike++;
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Operation could not be completed", "Close");
            }
        }



        public async Task DeleteItem(object boundData)
        {
            try
            {
                var selectedItem = (StudentViewModel)boundData;

                StudentList.Remove(selectedItem);
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Item could not be deleted. Try again later.", "Close");

            }
        }


        #endregion




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
                    PhoneNo = $"{new Random().Next(010, 019)}{new Random().Next(100000, 999999)}",  //Generate random phone number 
                    TotalLike = new Random().Next(0, 999),      //Generate Random number of TotalLike
                    TotalDislike = new Random().Next(0, 999),   //Generate Random number of TotalDislike
                });

            }

            return studentData;
        }

        #endregion

    }
}
