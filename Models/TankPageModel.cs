namespace FinalProject.Models
{
    public class TankPageModel
    {
        public List<TankPageItem> tankPageItems { get; set; }

        public List<TankPageItem> PopulateTankPageItems()
        {
            return new List<TankPageItem>()
            {
                new TankPageItem()
                {
                    ImgName = "Dva",
                    Name = "D.VA",
                    Overview = "D.Va is a former professional gamer who now uses her skills to pilot a state-of-the-art mech in defense of her homeland.",
                    Origin = "Hana Song—better known by her screen name “D.Va”–is the best of the best. A former professional gamer, D.Va now puts her skills to use as a mech pilot in defense of South Korea. She and the other pilots, known as the MEKA Squad, stand between their country and the invading Gwishin: a mechanical threat from deep beneath the sea."
                },
                new TankPageItem()
                {
                    ImgName = "Doom",
                    Name = "Doomfist",
                    Overview = "Doomfist is the calculating leader of Talon, a terrorist organization and paramilitary force that works in direct opposition to Overwatch.",
                    Origin = "A highly trained fighter and born leader, Akande Ogundimu lost his right arm in the Omnic Crisis, then joined Talon. Rising through the ranks, he killed his boss – the previous Doomfist – taking his eponymous weapon and title. Now, he is determined to plunge the world into a new conflict for his own mysterious purposes."
                },
                new TankPageItem()
                {
                    ImgName = "Hazard",
                    Name = "Hazard",
                    Overview = "A radical disruptor and an unstoppable weapon, Hazard has rocketed to fame in the criminal underworld as he fights to tear the system down. ",
                    Origin = "After pulling himself from the wreckage of a troubled past, Hazard has pushed his body beyond its limits with advanced augmentations that enhance his strength and agility. As a member of the Phreaks, he fights to protect those he feels the system has left behind. Passionate and radical, Hazard is proud to stand with his found family of body modders against Overwatch, Talon, and any organization that enforces the status quo. "
                },
                new TankPageItem()
                {
                    ImgName ="JQ",
                    Name = "Junker Queen",
                    Overview = "Armed with her axe, Carnage, and her electromagnetic gauntlet, the cutthroat leader of the Junkers is on a mission to rule the world.",
                    Origin = "A former wastelander, Odessa \"Dez\" Stone has ruled the squabbling Junker factions for over a decade. Everywhere she goes is her battlefield of choice, every seat is her throne, and everyone on the planet is her subject, whether they know it or not. Her tale of conquest is just beginning..."
                },
                new TankPageItem()
                {
                    ImgName ="Mauga",
                    Name = "Mauga",
                    Overview = "A charismatic and cunning Samoan warrior, Mauga thrives in the chaos of the battlefield and lives every day like it’s his last.",
                    Origin = "Mauga Malosi was born to challenge the system. Previously the member of the eco-rebel group, the Deepsea Raiders, he is now a Talon mercenary, wreaking havoc all around the world. Wherever he goes, he knows how to have a good time."
                },
                new TankPageItem()
                {
                    ImgName ="Orisa",
                    Name = "Orisa",
                    Overview = "Built from parts of one of Numbani's short-lived OR15 defense robots, Orisa is the city's newest protector, though she still has much to learn.",
                    Origin = "Built by eleven-year-old genius Efi Oladele, Orisa was created to defend the city of Numbani from all threats. When the duo successfully repelled an attack from Talon’s Doomfist, they became known as national heroes. Now, Orisa stands ready to protect those in need, using her power for good."
                },
                new TankPageItem()
                {
                    ImgName ="Ram",
                    Name = "Ramattra",
                    Overview = "The brutal leader of Null Sector will stop at nothing to see his vision for the world realized.",
                    Origin = "Ramattra was created to lead omnics into war. But all I have ever wanted is a better life for my people. The fact that we exist... is a miracle unto itself. We have studied the ways of peace and harmony. We have meditated on the universe and our place within it. We have tried to coexist with humanity, but humanity is not interested in sharing their world. How many more omnics should perish to fuel mankind's dreams? No more. Our race is only a single generation - finite, and dying all too quickly."
                },
                new TankPageItem()
                {
                    ImgName ="Rein",
                    Name = "Reinhardt",
                    Overview = "Reinhardt Wilhelm styles himself as a champion of a bygone age, who lives by the knightly codes of valor, justice, and courage.",
                    Origin = "Reinhardt Wilhelm lives by the knightly codes of valor, justice, and courage. One of the founders of Overwatch, for decades he was a force for good the world over. After the organization’s fall, he travelled Europe like a knight of old, defending the innocent alongside his squire, Brigitte, until Winston’s call brought them back into the arms of Overwatch."
                },
                new TankPageItem()
                {
                    ImgName ="Hog",
                    Name = "Roadhog",
                    Overview = "Roadhog is a powerful enforcer with a well-earned reputation for random and wanton destruction.",
                    Origin = "Roadhog is a ruthless masked killer with a reputation for destruction. Roaming the irradiated, wreckage-littered Australian outback, his only known associate (and many wonder why) is the manic young Junker criminal known as Junkrat."
                },
                new TankPageItem()
                {
                    ImgName ="Sigma",
                    Name = "Sigma",
                    Overview = "Brilliant astrophysicist Dr. Siebren de Kuiper's life changed forever when an experiment gone wrong gave him the ability to control gravity; now, Talon manipulates him to their own ends.",
                    Origin = "The celebrated astrophysicist Siebren de Kuiper's life changed forever when a failed experiment gave him the ability to control gravity but splintered his mind. Now, he struggles to maintain his connection to reality, unaware that Talon is manipulating him to their own ends."
                },
                new TankPageItem()
                {
                    ImgName ="Winston",
                    Name = "Winston",
                    Overview = "A super-intelligent, genetically engineered gorilla, Winston is a brilliant scientist and a champion for humanity’s potential.",
                    Origin = "A super-intelligent, genetically engineered gorilla, mild-mannered Winston is a brilliant scientist and mighty champion. Fleeing the Horizon Lunar Colony, Winston found a home with Overwatch and became the hero he’d always dreamed of being... until Overwatch fell. Now, with the world facing a rising threat from Null Sector, Winston has recalled some of his friends and former allies. A new Overwatch has been born."
                },
                new TankPageItem()
                {
                    ImgName ="Ball",
                    Name = "Wrecking Ball",
                    Overview = "A resourceful and highly intelligent mechanic and fighter, Wrecking Ball rose from the laboratories of Horizon Lunar Colony to become the Junker Queen’s champion.",
                    Origin = "This hamster’s genetic therapy on the Horizon Lunar Colony resulted in his greatly increased size and intellect. Hammond taught himself engineering and mechanics, and escaped to earth, landing amidst the Junkers of the Australian Outback. There, he modified his escape pod into a battle mech called Wrecking Ball and became a champion gladiator and the bodyguard of the notorious Junker Queen."
                },
                new TankPageItem()
                {
                    ImgName ="Zarya",
                    Name = "Zarya",
                    Overview = "Aleksandra Zaryanova is one of the world's strongest women, a celebrated athlete who sacrificed personal glory to protect her family, friends, and country in a time of war.",
                    Origin = "Growing up surrounded by the post-war destruction of the Omnic Crisis, Zarya became a champion weightlifter and used her strength and fame to help her nation rebuild. Now, she has sacrificed personal glory to protect her people on the front lines of a war against a deadly new mechanical threat."
                }
            };
        }
    }
}
//Images and hero descriptions from https://overwatch.blizzard.com/en-us/heroes/