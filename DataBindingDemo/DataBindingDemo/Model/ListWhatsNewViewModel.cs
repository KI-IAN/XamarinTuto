using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace DataBindingDemo.Model
{
    public class ListWhatsNewViewModel : INotifyPropertyChanged
    {


        #region Fields

        ObservableCollection<Model.WhatsNewViewModel> _whatsNewItems;

        #endregion


        #region Properties

        public ObservableCollection<WhatsNewViewModel> WhatsNewItemList
        {
            get
            {
                return _whatsNewItems;
            }
            set
            {
                _whatsNewItems = value;
                OnPropertyChanged();
            }
        }


        #endregion


        #region Constructors

        public ListWhatsNewViewModel()
        {
            #region Initialize Data

            WhatsNewItemList = new ObservableCollection<WhatsNewViewModel>(GetWhatsNewItems());

            #endregion


        }


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

        #region Repository

        private List<Model.WhatsNewViewModel> GetWhatsNewItems()
        {
            List<Model.WhatsNewViewModel> data = new List<WhatsNewViewModel>()
            {
                new WhatsNewViewModel(){
                    Title = $"Title#1",
                    Description = $"This is just a dummy description. You may need to add description by yourself...",
                    ExpiryInfo = $"Promotion ends {new DateTime(new Random().Next(2020,2022), new Random().Next(1,11), new Random().Next(1,28)).ToString("dd MMM yyyy") }",
                    LinkDescription = $"DETAILS",
                    ImageURL = $"https://quotefancy.com/media/wallpaper/thumb/18846.jpg",
                },

                new WhatsNewViewModel(){
                    Title = $"Title#2",
                    Description = $"This is just a dummy description. You may need to add description by yourself...",
                    ExpiryInfo = $"Promotion ends {new DateTime(new Random().Next(2020,2022), new Random().Next(1,11), new Random().Next(1,28)).ToString("dd MMM yyyy") }",
                    LinkDescription = $"DETAILS",
                    ImageURL = $"https://quotefancy.com/media/wallpaper/thumb/18847.jpg",

                },

                new WhatsNewViewModel(){
                    Title = $"Title#3",
                    Description = $"This is just a dummy description. You may need to add description by yourself...",
                    //ExpiryInfo = $"Promotion ends {new DateTime(new Random().Next(2020,2022), new Random().Next(1,11), new Random().Next(1,28)).ToString("DD MMM yyyy") }",
                    LinkDescription = $"DETAILS",
                    ImageURL = $"https://quotefancy.com/media/wallpaper/thumb/18848.jpg",

                },

                new WhatsNewViewModel(){
                    Title = $"Title#4",
                    Description = $"This is just a dummy description. You may need to add description by yourself...",
                    //ExpiryInfo = $"Promotion ends {new DateTime(new Random().Next(2020,2022), new Random().Next(1,11), new Random().Next(1,28)).ToString("DD MMM yyyy") }",
                    LinkDescription = $"DETAILS",
                    ImageURL = $"https://quotefancy.com/media/wallpaper/thumb/18849.jpg",

                },

                new WhatsNewViewModel(){
                    Title = $"Title#5",
                    Description = $"This is just a dummy description. You may need to add description by yourself...",
                    ExpiryInfo = $"Promotion ends {new DateTime(new Random().Next(2020,2022), new Random().Next(1,11), new Random().Next(1,28)).ToString("dd MMM yyyy") }",
                    LinkDescription = $"DETAILS",
                    ImageURL= $"https://thednetworks.com/wp-content/uploads/2012/01/picture_not_available_400-300.png",
                },

            };

            return data;


        }

        #endregion

    }
}
