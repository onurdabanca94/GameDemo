using GameCompany.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCompany.Abstract
{
    public interface IGameService
    {
        void Add(List<Game> games);
        void Update(Game game);
        void Delete(Game game);
    }
}
