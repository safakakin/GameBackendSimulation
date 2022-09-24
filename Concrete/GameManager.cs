using System;
namespace GameSimulation
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("{0} isimli oyun sisteme eklendi.",game.GameName);
        }

        public void SaleGame(Gamer gamer, Game game)
        {
            Console.WriteLine("{0} isimli oyun {1} isimli oyuncu tarafından satın alındı.",game.GameName,gamer.FirstName+" "+gamer.LastName);
        }

        public void SaleWithCampaign(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine("{0} isimli oyun {1} isimli oyuncu tarafından {2} kampanyası dahilinde %{3} indirimli satın alındı.",
                game.GameName, gamer.FirstName + " " + gamer.LastName, campaign.CampaignName, campaign.DiscountRate * 100);
        }
    }
}

