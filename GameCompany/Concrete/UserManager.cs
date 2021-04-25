using GameCompany.Abstract;
using GameCompany.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCompany.Concrete
{
    public class UserManager : IUserService
    {
        IUserValidationService _userValicationService;
        public UserManager(IUserValidationService userValidationService)
        {
            _userValicationService = userValidationService;
        }
        public void Add(User user)
        {
            if (_userValicationService.Validate(user) == true)
            {
                Console.WriteLine("User " + user.Name + " " + user.Surname + " has been registered. Please push to Enter.");
            }
            else
            {
                Console.WriteLine(user.Name + " Not a valid user. Please check your Tc.No or another informations");
            }
        }

        public void Delete(User user)
        {
            Console.WriteLine("User " + user.Name + " " + user.Surname + " has been removed from the system.");
        }

        public void Update(User user)
        {
            Console.WriteLine("User " + user.Name + " " + user.Surname + " has been updated.");
        }
    }
}
