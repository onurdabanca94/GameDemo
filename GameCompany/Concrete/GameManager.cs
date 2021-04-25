using GameCompany.Abstract;
using GameCompany.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCompany.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(List<Game> games)
        {
            foreach (var game in games)
            {
                Console.WriteLine("Success! " + game.GameName + " added to cart.");
            }
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " has been removed from cart.");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " has been changed with the new game");
        }
    }
}
