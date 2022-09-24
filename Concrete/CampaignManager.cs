using System;
namespace GameSimulation
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("{0} isimli kampanya sisteme tanımlandı.",campaign.CampaignName);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("{0} isimli kampanyada sistemden silindi.", campaign.CampaignName);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("{0} isimli kampanyada güncelleme yapıldı.", campaign.CampaignName);
        }

        public void MakeDiscount(Game game, Campaign campaign)
        {
            Console.WriteLine("{0} isimli oyuna {1} kampanyası tanımlandı.",game.GameName, campaign.CampaignName);
        }
    }
}

