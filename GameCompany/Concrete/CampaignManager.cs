using GameCompany.Abstract;
using GameCompany.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCompany.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign, Game game)
        {
            Console.WriteLine("Added discount %" + campaign.DiscountRate + " for" + game.GameName);
        }

        public void Add(List<Campaign> campaigns)
        {
            Console.WriteLine("Campaigns has been added to system");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " campaign has been removed");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Campaign has been updated");
        }
    }
}
