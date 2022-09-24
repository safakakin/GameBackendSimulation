using System;
namespace GameSimulation
{
	public interface IGameService
	{
		void Add(Game game);
		void SaleGame(Gamer gamer, Game game);
		void SaleWithCampaign(Gamer gamer, Game game, Campaign campaign);
	}
}

