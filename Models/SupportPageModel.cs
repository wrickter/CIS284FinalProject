using static System.Net.Mime.MediaTypeNames;

namespace FinalProject.Models
{
    public class SupportPageModel
    {
        public List<SupportPageItem> supportPageItems { get; set; }
        public List<SupportPageItem> PopulateSupportPageItems()
        {
            return new List<SupportPageItem>()
            {
                new SupportPageItem()
                {
                    ImgName = "Ana",
                    Name = "Ana",
                    Overview = "One of the founding members of Overwatch, Ana uses her skills and expertise to defend her home and the people she cares for.",
                    Origin = "A founding member of Overwatch and once renowned as the greatest sniper in the world, Ana Amari comes from a long line of decorated military veterans. Though she was thought to have perished in a firefight with Talon, Ana has rejoined the fray to protect her country, family, and closest allies."
                },
                new SupportPageItem()
                {
                    ImgName = "Bap",
                    Name = "Baptiste",
                    Overview = "An elite combat medic and ex-Talon operative, Baptiste now uses his skills to help those whose lives have been impacted by war.",
                    Origin = "An elite combat medic, Baptiste was lured into Talon by the promise of easy riches. Later, disgusted with what he had done, he deserted Talon to forge a new path for himself. Now he works toward a better world, healing where he can and fighting when he must."
                },
                new SupportPageItem()
                {
                    ImgName = "Brig",
                    Name = "Brigitte",
                    Overview = "No longer sitting on the sidelines, Brigitte Lindholm has taken up arms to defend those in need of protection.",
                    Origin = "A Lindholm through and through, Brigitte’s aptitude for engineering is matched by her sense of honor. From her youth, Brigitte was inspired by the tales of valor she heard from her godfather, Reinhardt. When she came of age, she became the squire to his knight. The two have joined the new Overwatch, hoping to right the wrongs of the world."
                },
                new SupportPageItem()
                {
                    ImgName = "Illari",
                    Name = "Illari",
                    Overview = "As the last of the Inti Warriors, Illari is a vessel for the power of the sun. She’ll do anything to make up for her past.",
                    Origin = "Growing up, Illari Quispe Ruiz trained every day to become part of the Inti Warriors – an augmented group of noble protectors and masters of harnessing solar energy. After a horrific accident killed all the other Warriors, the guilt-stricken Illari vows to make up for her part in the tragedy."
                },
                 new SupportPageItem()
                {
                    ImgName = "Juno",
                    Name = "Juno",
                    Overview = "The first human born on Mars, Juno uses her space-age technology to solve any problem that enters her orbit. She is determined to one day save her home planet.",
                    Origin = "Juno Teo Minh was born on Mars during Project Red Promise – Lucheng Interstellar’s secret multi-stage initiative to terraform the planet. When dust storms began to ravage the planet, the Red Promise Colony lost contact with Lucheng, throwing the project’s future into jeopardy. To protect Juno, the Red Promise Team sent her to planet Earth, where she could live her life in safety. Now, Juno is determined to find a way to save her home and family – before time runs out."
                },
                new SupportPageItem()
                {
                    ImgName = "Kiriko",
                    Name = "Kiriko",
                    Overview = "As Miko of the Kanezaka shrine and daughter of the Shimada's former swordmaster, Kiriko Kamori channels both her spiritual and ninja skills to heal her fractured city.",
                    Origin = "Kiriko learned the deadly art of ninjutsu from her mother, Asa. When the Shimada clan fell, the rival Hashimoto took Kiriko’s father hostage. For her safety, Kiriko moved in with her grandmother, who taught her the art of healing. Years later, Kiriko has returned home to free her community from the cruel grip of the Hashimoto."
                },
                new SupportPageItem()
                {
                    ImgName = "Lifeweaver",
                    Name = "Lifeweaver",
                    Overview = "The brilliant creator of biolight, a technology that merges plant matter and hard light. He dreams of healing the world.",
                    Origin = "An artist, activist, and inventor, Lifeweaver has created a new form of life that heals wounds, cures illnesses, and may one day save everyone on the planet... providing the Vishkar Corporation doesn’t catch up with him first."
                },
                new SupportPageItem()
                {
                    ImgName = "Lucio",
                    Name = "Lucio",
                    Overview = "Lúcio is an international celebrity who inspires social change through his music and activism.",
                    Origin = "Lúcio grew up poor in the Rio favelas, before eventually becoming a popular underground DJ. But when the Vishkar Corporation redeveloped the city and cracked down on the community, Lúcio reclaimed his father’s sonic technology from the corporation and used it to rally his people to action. Now an international celebrity, he inspires social change through his music and actions."
                },
                new SupportPageItem()
                {
                    ImgName = "Mercy",
                    Name = "Mercy",
                    Overview = "A guardian angel to those who come under her care, Dr. Angela Ziegler is a peerless healer, a brilliant scientist, and a staunch advocate for peace.",
                    Origin = "Orphaned in the Omnic Crisis, child prodigy and nanotechnology pioneer Angela Ziegler became Overwatch’s most prominent combat medic and vocal proponent of global peace. After the organization’s fall, and with the coming of a new war, she wonders if she will ever know peace in her lifetime."
                },
                new SupportPageItem()
                {
                    ImgName = "Moira",
                    Name = "Moira",
                    Overview = "Equal parts brilliant and controversial, scientist Moira O'Deorain is on the cutting edge of genetic engineering, searching for a way to rewrite the fundamental building blocks of life.",
                    Origin = "Controversial geneticist Moira O’Deorain cared only about the evolutionary advancement of humanity. Though her work has earned her many enemies, her alliances with the scientific collective of Oasis and the ruthless organization Talon have freed her from moral and monetary constraints, allowing her to pursue her breakthroughs with great efficiency... and ruthlessness."
                },
                new SupportPageItem()
                {
                    ImgName = "Zen",
                    Name = "Zenyatta",
                    Overview = "Zenyatta is an omnic monk who wanders the world in search of spiritual enlightenment. It is said that those who cross his path are never the same again.",
                    Origin = "Zenyatta is an omnic monk who wanders the world in search of spiritual enlightenment, helping those he meets to overcome their personal struggles and find inner peace. When necessary, however, he will fight to protect the innocent, be they omnic or human. It is said that those who cross his path are never the same again."
                }
            };

        }
    }
}
//Images and hero descriptions from https://overwatch.blizzard.com/en-us/heroes/
//Code by Wesley Rickter