using System;
namespace GameSimulation
{
	public interface ICampaignService
	{
		void Add(Campaign campaign);
		void Update(Campaign campaign);
		void Delete(Campaign campaign);
		void MakeDiscount(Game game,Campaign campaign);
	}
}

