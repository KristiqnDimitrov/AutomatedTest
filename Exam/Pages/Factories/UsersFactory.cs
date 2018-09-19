using System;
using System.Collections.Generic;
using System.Text;

namespace Exam.Pages.Factories
{
    using global::Exam.Pages.Models;
    
    using System.Collections.Generic;
    using System.IO;

    public static class UserFactory
    {
        public static RegistrationUser GenerateRegUser()
        {
            var _user = new RegistrationUser();
            _user.FirstName = "Pesho";
            _user.LastName = "Goshevvv";
            _user.MatrialStatus = new List<bool>
            {
                false, true, false
            };
            _user.Hobbies = new List<bool>
            {
                false, true, false
            };

            _user.Country = "Bulgaria";
            _user.Month = "4";
            _user.Day = "16";
            _user.Year = "2014";
            _user.Phone = "4534354656";
            _user.UserName = "PeSHOOOo";
            _user.Email = "sgghgha@ghgh.dt";
            _user.PicturePath = Path.GetPathRoot(@"..\..\logo.jpg");
            _user.AboutYourself = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
            _user.Password = "4rfv%TGB0][";
            _user.ConfirmPassword = "4rfv%TGB0][";

            return _user;
        }
    }
}
