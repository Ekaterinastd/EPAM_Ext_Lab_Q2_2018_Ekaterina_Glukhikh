using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_4_ClassLibrary
{
    public class Photo : Content
    {
        private int Image;

        public Like Like
        {
            get => default(Like);
            set
            {
            }
        }

        public Comment Comment
        {
            get => default(Comment);
            set
            {
            }
        }

        public void Show_comment()
        {
            throw new System.NotImplementedException();
        }

        public void Rate_photo()
        {
            throw new System.NotImplementedException();
        }
    }
}