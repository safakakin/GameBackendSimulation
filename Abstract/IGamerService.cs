using System;
namespace GameSimulation
{
	public interface IGamerService
	{
		void Add(Gamer gamer);
		void Update(Gamer gamer);
		void Delete(Gamer gamer);
	}
}

