using GameCompany.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCompany.Entities
{
    public class Game : IEntity
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public double GamePrice { get; set; }
        public List<Campaign> Campaigns { get; set; }
    }
}
