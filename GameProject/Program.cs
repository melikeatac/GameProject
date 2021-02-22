using System;

namespace GameProject
{
    class Program
    {
        private const int V = 04041999;

        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer();
            gamer1.GamerId = 5;
            gamer1.GamerName = "Melike";
            gamer1.GamerSurname = "Ataç";
            gamer1.DateofBirth =1999;
            gamer1.NationalId = 12345678910;

            Gamer gamer2 = new Gamer();
            gamer2.GamerId = 5;
            gamer2.GamerName = "Büşra";
            gamer2.GamerSurname = "Bozkuş";
            gamer2.DateofBirth = 1998;
            gamer2.NationalId = 1656465478910;

            Game game1 = new Game();
            game1.GameId = 1;
            game1.GameName = "FIFA19";
            game1.GamePrice = 200;
            Game game2 = new Game();
            game2.GameId = 2;
            game2.GameName = "FIFA21";
            game2.GamePrice = 600;

            Campaign campaign1 = new Campaign();
            campaign1.CampaignId = 1;
            campaign1.Discount = 50;
            campaign1.CampaignName = "Campaign50";



            SalesManager salesManager = new SalesManager();
            salesManager.Sales(gamer1, game1);
            salesManager.SalesCampaign(gamer2, game2, campaign1);
            


        }
    }
}
