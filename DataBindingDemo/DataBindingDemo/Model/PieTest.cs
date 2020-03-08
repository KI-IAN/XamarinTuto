using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Text;

namespace DataBindingDemo.Model
{
    public class PieTest : INotifyPropertyChanged
    {

        public int Id { get; set; }

        private string _pieName;
        public string PieName
        {
            get
            {
                return _pieName;
            }

            set
            {
                _pieName = value;
                RaisePropertyChanged(nameof(PieName));
            }
        }


        private double _price;
        public double Price
        {
            get
            {
                return _price;
            }

            set
            {
                _price = value;
                RaisePropertyChanged(GetPropertyName());
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }



        #region Reusuable Function to Get Current Property Name

        public string GetPropertyName()
        {
            string currentCallerMethod = GetCurrentCallerName();

            String[] splittedString = currentCallerMethod.Split('_');

            var currentPropertyName = "";

            int expectedLength = 2;
            int expectedCallerNameIndex = expectedLength - 1;

            if (splittedString.Length == expectedLength)
            {
                currentPropertyName = splittedString[expectedCallerNameIndex];
            }

            return currentPropertyName;
        }

        public string GetCurrentCallerName()
        {
            StackTrace stackTrace = new StackTrace();

            var propertyFrameIndex = 2;

            var callerMethodName = stackTrace.GetFrame(propertyFrameIndex).GetMethod().Name;

            return callerMethodName;

        }


        #endregion




    }
}
