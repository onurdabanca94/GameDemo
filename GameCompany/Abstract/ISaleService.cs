using GameCompany.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCompany.Abstract
{
    public interface ISaleService
    {
        void Order(Game game, Player player);
        void OrderViaCampaign(Game game, Campaign campaign);
        void OrderViaCampaign(List<Game> games, Campaign campaign);
    }
}
