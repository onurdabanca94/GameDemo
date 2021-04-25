using GameCompany.Abstract;
using GameCompany.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCompany.Concrete
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validate(User user)
        {
            return true;
        }
    }
}
