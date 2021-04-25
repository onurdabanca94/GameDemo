using GameCompany.Abstract;
using GameCompany.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCompany.Concrete
{
    public class SaleManager : ISaleService
    {
        public void Order(Game game, Player player)
        {
            Console.WriteLine(player.Alias + " you can buy " + game.GameName + " to " + game.GamePrice);
        }

        public void OrderViaCampaign(Game game, Campaign campaign)
        {
            if (game.GamePrice > 250)
            {
                double discountedPrice = game.GamePrice - (game.GamePrice * campaign.DiscountRate / 100);
                Console.WriteLine("Dear player, you can buy " + game.GameName + " with " + discountedPrice + "tl via " + campaign.CampaignName);
            }
            else
            {
                Console.WriteLine("Out of Campaign price");
            }
        }

        public void OrderViaCampaign(List<Game> games, Campaign campaign)
        {
            foreach (var order in games)
            {
                if (order.GamePrice > 250)
                {
                    double discountedPrice = order.GamePrice - (order.GamePrice * campaign.DiscountRate / 100);
                    Console.WriteLine("Dear player, you can buy " + order.GameName + " with " + discountedPrice + "tl via " + campaign.CampaignName);
                }
                else
                {
                    Console.WriteLine(order.GameName +" Out of campaign list");
                }
            }
        }
    }
}
