using GameSimulation;

internal class Program
{
    private static void Main(string[] args)
    {
        GamerManager gamerManager = new GamerManager(new UserValidationManager());

        GameManager gameManager = new GameManager();

        CampaignManager campaignManager = new CampaignManager();

        Gamer gamer1 = new Gamer() { GamerId = 1, FirstName = "Şafak", LastName = "Akın", DateYear = 1992, IdNo = 55321549868 };

        gamerManager.Add(gamer1);

        Game game1 = new Game() { GameId = 1, GameName = "Knight", GamePrice=100};

        gameManager.Add(game1);

        gameManager.SaleGame(gamer1, game1);

        Campaign campaign1 = new Campaign() { CampaignID = 1, CampaignName = "Kışa Merhaba", DiscountRate = 0.1f };

        gameManager.SaleWithCampaign(gamer1, game1, campaign1);

    }
}