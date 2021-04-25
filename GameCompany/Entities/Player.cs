using GameCompany.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCompany.Entities
{
    public class Player : User, IEntity
    {
        public string CardNumber { get; set; }
        public string Alias { get; set; }
    }
}
