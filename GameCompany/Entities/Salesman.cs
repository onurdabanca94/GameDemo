using GameCompany.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCompany.Entities
{
    public class Salesman : User, IEntity
    {
        public string Department { get; set; }
    }
}
