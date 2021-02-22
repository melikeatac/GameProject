using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class SalesManager : ISalesService
    {
        public void Sales(Gamer gamer, Game game)
        {
            Console.WriteLine(gamer.GamerName+" "+gamer.GamerSurname+" adlı oyuncu"+" "+
                game.GameName+" isimli oyunu satın aldı");
        }

        public void SalesCampaign(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine(gamer.GamerName + " " + gamer.GamerSurname + " adlı oyuncu" + " " +
                game.GameName + " isimli oyunu kampanya fiyatında satın aldı");
        }
    }
}
