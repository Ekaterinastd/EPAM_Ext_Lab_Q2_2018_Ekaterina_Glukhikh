using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_4_ClassLibrary
{
    public class User
    {
        private string Login;
        private string Password;
        private string Mail;

        public Album Album
        {
            get => default(Album);
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

        public void Register()
        {
            throw new System.NotImplementedException();
        }

        public void Log_in()
        {
            throw new System.NotImplementedException();
        }

        public void Add_photo()
        {
            throw new System.NotImplementedException();
        }

        public void Create_album()
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

        public void See_other_users_photo()
        {
            throw new System.NotImplementedException();
        }

        public void Find_photo()
        {
            throw new System.NotImplementedException();
        }

        public void Add_comment()
        {
            throw new System.NotImplementedException();
        }

        public void Delete_comment()
        {
            throw new System.NotImplementedException();
        }
    }
}