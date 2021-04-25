using GameCompany.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCompany.Entities
{
    public class User
    {
        public int Id { get; set; }
        public long NationalityId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }

    }
}
