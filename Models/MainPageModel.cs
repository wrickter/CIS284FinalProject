namespace FinalProject.Models
{
    public class MainPageModel
    {
        public List<MainPageItem> mainPageItems { get; set; }

        public List<MainPageItem> PopulateMainPageItems()
        {
            return new List<MainPageItem>()
            {
                new MainPageItem()
                {
                    Title = "Overview",
                    Description = "Overwatch first launched as a 6v6 team based game. There was multiple modes that players could enter and even\r\n                a competitive mode. When Overwatch first launched, matches were played in what is called Open-Queue. This meant that players could choose multiple of the same roles.\r\n                In the up and coming competitive gaming scene, there was a team named \"GOATS\" which consisted of players running, a now historic hero composition, 3 tanks and 3 supports.\r\n                As the game went on and to move away from a stale gaming experience, the developers introduced a new way to play, Role-Queue. This would limit the number of each role that\r\n                players could play. This forced players to use a 2-2-2 composition, 2 tanks, 2 damage, and 2 supports. After 6 years of the game, it was time for new experiences. This would\r\n                lead to Overwatch being turned into what is now \"Overwatch 2\"."
                },
                new MainPageItem()
                {
                    Title = "A New Era",
                    Description = "After 6 years of updates, the team behind the hit shooter decided\r\n                to shift focus on a \"Player vs Enviorment\" mode. With this shift, it was stated that future updates would not happen to Overwatch,\r\n                but to a sequal they were going to release as a replacement named \"Overwatch 2\". The game now deemed as \"Overwatch 1\" shut down on October 3rd 2022 and\r\n                \"Overwatch 2\" was released the next day. The launch of Overwatch 2 brought many ideas to the front-line. There was a brand new mode and a complete shift\r\n                in how the game was played. The main difference was going to a 5v5 experience instead of 6v6. With the launch of Overwatch 2, the developers of Overwatch\r\n                had to rebuild every system from the ground up due to switching game engines."
                },
                new MainPageItem()
                {
                    Title = "Roles and Meta",
                    Description = "There are 3 roles a player can choose from when playing Overwatch. There is a Tank, Damage, and Support role. Tank heroes have more health than the other\r\n                two roles. Their main objective is to make space and provide protection for their teammates. Damage heroes are there to do majority of the damage and allow the\r\n                team to advance the objective by getting kills on the enemy team. Supports are the main healers of the team. Many of the heroes in the Support category have the\r\n                utility to assist the Damage characters in eliminating the other team but also keeping their own team healthy by healing them. There are many different ways\r\n                to play different heroes. Hero selection is also heavily influenced by balance updates. When new balance updates are released, we see different heroes being played\r\n                and can change the overall composition of the team. You can play a dive comp, where the main focus is to get into the backline and eliminate the supports. There is\r\n                also a poke comp, where the main objective is to do little damage but drag out the team fights until you build your ultimates."
                }
            };
        }
    }
}
