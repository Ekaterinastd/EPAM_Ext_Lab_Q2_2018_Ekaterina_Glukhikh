using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_4_ClassLibrary
{
    public class Album
    {
        private string Name;
        private string Date_of_create;

        public Photo Photo
        {
            get => default(Photo);
            set
            {
            }
        }

        public void Show_all_photo()
        {
            throw new System.NotImplementedException();
        }

        public void Sort()
        {
            throw new System.NotImplementedException();
        }
    }
}