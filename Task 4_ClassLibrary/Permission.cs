using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_4_ClassLibrary
{
    public class Permissions
    {
        private int ID;
        private int Hash;
        private int Album_ID;
        private int Photo_ID;
        private int User_ID;

        public Role Role
        {
            get => default(Role);
            set
            {
            }
        }
    }
}