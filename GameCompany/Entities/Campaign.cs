using GameCompany.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCompany.Entities
{
    public class Campaign : IEntity
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
        public float DiscountRate { get; set; }
    }
}
