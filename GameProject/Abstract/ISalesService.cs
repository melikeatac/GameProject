using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public interface ISalesService
    {
        void Sales(Gamer gamer, Game game);
        void SalesCampaign(Gamer gamer, Game game, Campaign campaign);
    }
}
