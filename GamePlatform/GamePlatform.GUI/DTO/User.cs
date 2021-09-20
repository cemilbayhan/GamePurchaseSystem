using GamePlatform.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePlatform.GUI.DTO
{
    public static class User
    {
        public static Registration_Customer _loggedUser;
        public static void Login(Registration_Customer user) 
        {
            _loggedUser = user;
        }

    }
}
