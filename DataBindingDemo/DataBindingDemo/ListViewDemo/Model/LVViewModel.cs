using System;
using System.Collections.Generic;
using System.Text;

namespace DataBindingDemo.ListViewDemo.Model
{
    public class LVViewModel
    {
        private List<SampleLVModel> _studentList;

        public List<SampleLVModel> StudentList
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


        public LVViewModel()
        {
            _studentList = GetDummyData();
        }

        private List<SampleLVModel> GetDummyData()
        {

            List<SampleLVModel> studentList = new List<SampleLVModel>()
            {
                new SampleLVModel(){
                    FirstName = "A",
                    LastName = "B",
                    Gender = "M",
                    StudentID = 1,
                },
                new SampleLVModel(){
                    FirstName = "AB",
                    LastName = "BC",
                    Gender = "F",
                    StudentID = 2,
                },

                new SampleLVModel(){
                    FirstName = "EFG",
                    LastName = "HIJK",
                    Gender = "F",
                    StudentID = 3,
                },

                new SampleLVModel(){
                    FirstName = "A",
                    LastName = "B",
                    Gender = "M",
                    StudentID = 4,
                },

                new SampleLVModel(){
                    FirstName = "A",
                    LastName = "B",
                    Gender = "M",
                    StudentID = 5,
                },

            };

            return studentList;

        }
    }
}
