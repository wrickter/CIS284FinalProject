namespace FinalProject.Models
{
    public class DamagePageModel
    {
        public List<DamagePageItem> damagePageItems { get; set; }
        public List<DamagePageItem> PopulateDamagePageItems()
        {
            return new List<DamagePageItem>()
            {
                new DamagePageItem()
                {
                    ImgName = "Ashe",
                    Name = "Ashe",
                    Overview = "Ashe is the ambitious and calculating leader of the Deadlock Rebels Gang and a respected figure in the criminal underworld.",
                    Origin = "Ashe was born into a wealthy family to parents who cared more for their fortune than their daughter. Ambitious and calculating, Ashe rebelled and formed the Deadlock Gang, which quickly gained infamy in the criminal underworld. Convincing the gangs of the Southwest to work together, Ashe has branded herself a legend, restoring the notoriety of the once-wild West."
                },
                new DamagePageItem()
                {
                    ImgName = "Bastion",
                    Name = "Bastion",
                    Overview = "Once a frontline combatant in the devastating Omnic Crisis, this curious Bastion unit now explores the world, fascinated by nature but wary of a fearful humanity.",
                    Origin = "Left abandoned and dormant after the devastating Omnic Crisis, this curious Bastion unit has reawakened in a changed world. The once-hostile machine now possesses curiosity and a fascination for nature. Along with his bird companion, Ganymede, Bastion has found his way into the care of Torbjorn Lindholm, where he now works to help the humans he once fought against."
                },
                new DamagePageItem()
                {
                    ImgName = "Cass",
                    Name = "Cassidy",
                    Overview = "Armed with his Peacekeeper revolver, the outlaw Cole Cassidy doles out justice on his own terms.",
                    Origin = "A founding member of the notorious Deadlock Gang, Cassidy was eventually coerced into joining Blackwatch, Overwatch’s covert-ops division. He came to believe he could make amends for his past by righting the world’s injustices. But when Overwatch fell, Cassidy went underground, resurfacing later as a gunslinger for hire, fighting only for causes he believes are just."
                },
                new DamagePageItem()
                {
                    ImgName = "Echo",
                    Name = "Echo",
                    Overview = "Echo is a multirole, adaptive robot with the most sophisticated artificial intelligence in the world, originally designed by Dr. Mina Liao for use during combat missions with Overwatch.",
                    Origin = "Developed by Overwatch roboticist Mina Liao, the highly adaptable, advanced AI-driven robot Echo derives her personality from her creator. But after Liao was killed, her project was shut down and Echo placed in military quarantine. Years later, she was freed by Cole Cassidy and joined the new Overwatch in the fight to save the world."
                },
                new DamagePageItem()
                {
                    ImgName = "Genji",
                    Name = "Genji",
                    Overview = "The cyborg ninja Genji Shimada has made peace with the augmented body he once rejected, and in doing so, he has discovered a higher humanity.",
                    Origin = "Near death at the hands of his own brother, ninja Genji Shimada was rescued by Overwatch. To save his life, they made him a living weapon with cybernetic upgrades. Struggling with his nature and purpose after Overwatch’s fall, Genji sought peace through study with the omnic monk Zenyatta before answering Winston’s call."
                },
                new DamagePageItem()
                {
                    ImgName = "Hanzo",
                    Name = "Hanzo",
                    Overview = "Mastering his skills as a bowman and an assassin, Hanzo Shimada strives to prove himself as a warrior without peer.",
                    Origin = "When his father passed, Hanzo was left to lead the Shimada ninja clan. The clan’s elders pushed him to bring his carefree brother, Genji, into line—leading to a confrontation where Hanzo struck Genji down. Horrified, Hanzo abandoned the clan, roaming the world in solitude as punishment. But now, finding out that his brother still lives, Hanzo must decide where this new path will take him."
                },
                new DamagePageItem()
                {
                    ImgName = "Junkrat",
                    Name = "Junkrat",
                    Overview = "Junkrat is an explosives-obsessed demolitionist who lives to cause chaos and destruction.",
                    Origin = "Growing up in the irradiated wasteland surrounding Junkertown, Junkrat is an unhinged, explosives-obsessed oddity. One of the lawless “Junkers” of the Outback, he and his partner/bodyguard Roadhog live for crime sprees and mayhem."
                },
                new DamagePageItem()
                {
                    ImgName = "Mei",
                    Name = "Mei",
                    Overview = "Mei is a scientist who has taken the fight to preserve the environment into her own hands.",
                    Origin = "As a peerless climatologist stationed in Ecopoint: Antarctica, Mei-Ling Zhou’s team was forced into cryostasis during a turbulent storm. Sadly, the cryostasis lasted far longer than intended, and Mei awoke nine years later as the only survivor in a damaged station. With the help of her robot companion, Snowball, Mei invented new technology to escape Antarctica and join up with the new Overwatch."
                },
                new DamagePageItem()
                {
                    ImgName = "Phara",
                    Name = "Phara",
                    Overview = "Fareeha Amari's commitment to duty runs in her blood. She comes from a long line of highly decorated soldiers and burns with the desire to serve with honor.",
                    Origin = "Fareeha Amari dreamed of being part of Overwatch with her mother Ana, only to see it disbanded before she had the chance. She found success as “Pharah”, head of an elite security squad guarding the rogue AI that started the Omnic Crisis. But now that a new Overwatch has returned, Pharah's dreams are finally becoming a reality."
                },
                new DamagePageItem()
                {
                    ImgName = "Reaper",
                    Name = "Reaper",
                    Overview = "Some speak of a black-robed terrorist known only as the Reaper. His identity and motives are a mystery. What is known is that where he appears, death follows.",
                    Origin = "Gabriel Reyes was once an esteemed member of Overwatch, first as its Strike Commander and then as the leader of Blackwatch, Overwatch’s branch for covert operations. He was believed dead following an explosion at Overwatch’s headquarters. But rumors say he escaped his fate, and now works as the volatile killer known only as Reaper, one of Talon’s deadliest enforcers."
                },
                new DamagePageItem()
                {
                    ImgName = "Sojourn",
                    Name = "Sojourn",
                    Overview = "As a leader in the bygone days of Overwatch, Vivian Chase, callsign Sojourn, is determined to ensure its new heroes don’t repeat the mistakes of the past.",
                    Origin = "From soldier to Overwatch Captain to veteran, Sojourn has devoted her life to helping those who would be made victims by the evils of the world. Her extensive cybernetic augmentations enhanced her innate strategic skills and prowess on the battlefield made her Overwatch’s most skilled tactician. Now on her own, she faces new challenges... and new dangers."
                },
                new DamagePageItem()
                {
                    ImgName = "Soldier",
                    Name = "Soldier: 76",
                    Overview = "The target of an international manhunt, the vigilante known as Soldier: 76 wages a personal war to expose the truth behind Overwatch's collapse.",
                    Origin = "The former commander of Overwatch turned physically-enhanced vigilante, Jack Morrison travels the world hunting those responsible for the downfall of Overwatch. It is unknown whether he seeks justice... or revenge."
                },
                new DamagePageItem()
                {
                    ImgName = "Sombra",
                    Name = "Sombra",
                    Overview = "One of the world's most notorious hackers, Sombra uses information to manipulate those in power.",
                    Origin = "One of the world's most notorious hackers, Sombra uses information to manipulate those in power. As she works to uncover the truth behind a shadowy global conspiracy, Sombra has joined the ranks of Talon, exploiting their resources for her own ends."
                },
                new DamagePageItem()
                {
                    ImgName = "Sym",
                    Name = "Symmetra",
                    Overview = "Symmetra literally bends reality. By manipulating hard-light constructs, she crafts the world as she wishes it to be, in hopes of engineering a perfect society.",
                    Origin = "As an “architech” for the Vishkar Corporation, Symmetra weaves hard-light architectural constructs, creating buildings and infrastructure from thin air. Vishkar also sends her on clandestine missions around the world to uphold their corporate interests, leading her to wonder whether the control and order she desires--and Vishkar represents--are truly best for humanity."
                },
                new DamagePageItem()
                {
                    ImgName = "Torb",
                    Name = "Torbjörn",
                    Overview = "At its height, Overwatch possessed one of the most advanced armaments on the planet, which could be traced to the workshop of an ingenious engineer named Torbjörn Lindholm.",
                    Origin = "As one of the world’s top engineers, Torbjörn Lindholm’s inventions were crucial to ending the Omnic Crisis, and kept Overwatch at the cutting edge of weapons technology for decades. In recent years, his “adoption” of a curious Bastion unit has led him to question his antipathy to robots and omnics, even as he works to stop his creations from falling into the wrong hands."
                },
                new DamagePageItem()
                {
                    ImgName = "Tracer",
                    Name = "Tracer",
                    Overview = "The former Overwatch agent known as Tracer is a time-jumping adventurer and an irrepressible force for good.",
                    Origin = "Tracer is a time-jumping adventurer and an irrepressible force for good. With a chronal harness that lets her control her flow of time, she was one of Overwatch’s top agents, and she continues to try to make the world a better place wherever – and whenever – she can. Tracer brings her skill and optimism to help the new Overwatch keep the world safe."
                },
                new DamagePageItem()
                {
                    ImgName = "Widow",
                    Name = "Widowmaker",
                    Overview = "Widowmaker is the perfect assassin: a patient, ruthlessly efficient killer who shows neither emotion nor remorse.",
                    Origin = "A lifetime ago, Amélie Lacroix, wife of an Overwatch agent, was kidnapped by Talon. Shortly after returning home, she killed her husband and vanished. Now, “Widowmaker” is Talon's most effective weapon, a patient, ruthlessly efficient operative who rarely shows emotion and remorse, and revels only in the moment of the kill."
                }
            };
        }
    }
}
//Images and hero descriptions from https://overwatch.blizzard.com/en-us/heroes/