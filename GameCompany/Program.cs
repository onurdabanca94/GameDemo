using GameCompany.Adapters;
using GameCompany.Concrete;
using GameCompany.Entities;
using System;
using System.Collections.Generic;

namespace GameCompany
{
    public class Program
    {
        public static void Main(string[] args)
        {
            UserManager userManager = new UserManager(new MernisServiceAdapter());

            User playerFirst = new Player();
            userManager.Add(new Player 
            {
                DateOfBirth = new DateTime(1994,7,26),
                Name = "Onur",
                Surname = "Dabanca",
                NationalityId = 0123456789,
                Alias = "Kamuflaj"
            });
            Console.ReadLine();

            Game gameFirst = new Game();
            gameFirst.Id = 1;
            gameFirst.GameName = "Call of Duty: Black Ops.";
            gameFirst.GamePrice = 240;

            Game gameSecond = new Game { Id = 2, GameName = "Darkest Souls", GamePrice = 350 };
            Game gameThird = new Game { Id = 3, GameName = "Counter Strike: Global Offensive", GamePrice = 50 };

            List<Game> games = new List<Game> { gameFirst, gameSecond, gameThird };
            
            SaleManager saleManager = new SaleManager();
            saleManager.OrderViaCampaign(games, new Campaign() 
            {
                Id = 2,
                CampaignName = "BlackFriyay!",
                DiscountRate = 30
            });
            Console.ReadLine();
        }
    }
}
