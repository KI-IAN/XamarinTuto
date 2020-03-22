using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace DataBindingDemo.Model
{
    public class WhatsNewViewModel : INotifyPropertyChanged
    {

        #region Fields

        String _title;

        String _description;

        String _expiryInfo;

        String _linkDescription;

        String _imageURL;

        #endregion


        #region Properties

        public String Title
        {
            get { return _title; }
            set
            {
                _title = value;
                OnPropertyChanged();
            }
        }


        public String Description
        {
            get { return _description; }
            set
            {
                _description = value;
                OnPropertyChanged();
            }
        }


        public String ExpiryInfo
        {
            get { return _expiryInfo; }
            set
            {
                _expiryInfo = value;
                OnPropertyChanged();
            }
        }


        public String LinkDescription
        {
            get { return _linkDescription; }
            set
            {
                _linkDescription = value;
                OnPropertyChanged();
            }
        }


        public String ImageURL
        {
            get { return _imageURL; }
            set
            {
                _imageURL = value;
                OnPropertyChanged();
            }
        }


        #endregion



        #region Constructor



        #endregion



        #region Event Handler Functions

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        #endregion



        #region Events

        public event PropertyChangedEventHandler PropertyChanged;


        #endregion

    }
}
