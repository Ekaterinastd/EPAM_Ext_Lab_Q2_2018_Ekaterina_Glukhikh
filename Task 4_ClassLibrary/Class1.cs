using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_ClassLibrary
{
    public class Administrator
    {
        private int ID;
        private string Name;

        public User User
        {
            get => default(User);
            set
            {
            }
        }

        public Photo Photo
        {
            get => default(Photo);
            set
            {
            }
        }

        public Album Album
        {
            get => default(Album);
            set
            {
            }
        }

        public void Delete_user()
        {
            throw new System.NotImplementedException();
        }

        public void Delete_photo()
        {
            throw new System.NotImplementedException();
        }

        public void Delete_album()
        {
            throw new System.NotImplementedException();
        }

        public void View_all_users()
        {
            throw new System.NotImplementedException();
        }

        public void Get_user_info()
        {
            throw new System.NotImplementedException();
        }

        public void Delete_comment()
        {
            throw new System.NotImplementedException();
        }
    }
}
