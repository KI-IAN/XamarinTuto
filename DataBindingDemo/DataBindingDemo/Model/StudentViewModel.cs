using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace DataBindingDemo.Model
{
    public class StudentViewModel : INotifyPropertyChanged
    {


        #region Fields

        int _studentId;

        string _firstName;

        string _lastName;

        string _phoneNo;

        DateTime _dateofBirth;

        int _age;

        int _totalLike;

        int _totalDislike;

        #endregion

        #region Events

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion


        #region Constructors

        public StudentViewModel()
        {

        }


        #endregion


        #region All Properties

        public int StudentId
        {
            get
            {
                return _studentId;
            }
            set
            {
                _studentId = value;
                OnPropertyChanged();
            }
        }

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
                OnPropertyChanged();
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
                OnPropertyChanged();
            }
        }

        public string PhoneNo
        {
            get
            {
                return _phoneNo;
            }
            set
            {
                _phoneNo = value;
                OnPropertyChanged();
            }
        }

        public DateTime DateofBirth
        {
            get
            {
                return _dateofBirth;
            }
            set
            {
                _dateofBirth = value;
                OnPropertyChanged();
            }
        }

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
                OnPropertyChanged();
            }
        }


        public int TotalLike
        {
            get
            {
                return _totalLike;
            }
            set
            {
                _totalLike = value;
                OnPropertyChanged();
            }
        }


        public int TotalDislike
        {
            get
            {
                return _totalDislike;
            }
            set
            {
                _totalDislike = value;
                OnPropertyChanged();
            }
        }


        #endregion



        #region Event Handler Functions

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        #endregion





    }
}
