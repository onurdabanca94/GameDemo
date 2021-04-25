using GameCompany.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCompany.Abstract
{
    public interface ICampaignService
    {
        void Add(Campaign campaign, Game game);
        void Add(List<Campaign> campaigns);
        void Update(Campaign campaign);
        void Delete(Campaign campaign);
    }
}
