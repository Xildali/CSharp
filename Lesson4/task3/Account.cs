using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4.task3
{
    struct Account
    {
        public string login;
        public string password;

        public Account(string login, string password)
        {
            this.login = login;
            this.password = password;
        }
    }
}
