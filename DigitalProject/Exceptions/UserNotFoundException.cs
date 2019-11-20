using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalProject.Exceptions
{
    class UserNotFoundException : Exception
    {
        public string UserName;

        public UserNotFoundException(string username)
        {
            UserName = username;
        }
    }
}
