using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_4_ClassLibrary
{
    public class Role
    {
        private int ID;
        private string Name;
        private int Permission;

        public Administrator Administrator
        {
            get => default(Administrator);
            set
            {
            }
        }

        public User User
        {
            get => default(User);
            set
            {
            }
        }
    }
}