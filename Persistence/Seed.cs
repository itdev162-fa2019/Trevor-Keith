using System;
using System.Collections.Generic;
using System.Linq;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static void SeedData(DataContext context) {
            if(!context.Posts.Any()) {
                var Posts = new List<Post> {
                    new Post {
                        Title = "First post!",
                        Date = DateTime.Now.AddDays(-10),
                        Body = "In the first age, in the first battle, when the shadows first lengthened, one stood. Burned by the embers of Armageddon, his soul blistered by the fires of Hell and tainted beyond ascension, he chose the path of perpetual torment. In his ravenous hatred he found no peace; and with boiling blood he scoured the Umbral Plains seeking vengeance against the dark lords who had wronged him. He wore the crown of the Night Sentinels, and those that tasted the bile of his sword named him... the Doom Slayer."

                    },
                    new Post {
                        Title = "This is my second post.",
                        Date = DateTime.Now.AddDays(-7),
                        Body = "Tempered by the fires of Hell, his iron will remained steadfast through the passage that preys upon the weak. For he alone was the Hell Walker, the Unchained Predator, who sought retribution in all quarters, dark and light, fire and ice, in the beginning and the end, and he hunted the slaves of Doom with barbarous cruelty; for he passed through the divide as none but demon had before."

                    },
                    new Post {
                        Title = "This is my third post",
                        Date = DateTime.Now.AddDays(-4),
                        Body = "And in his conquest against the blackened souls of the doomed, his prowess was shown. In his crusade, the seraphim bestowed upon him terrible power and speed, and with his might he crushed the obsidian pillars of the Blood Temples. He set forth without pity upon the beasts of the nine circles. Unbreakable, incorruptible, unyielding, the Doom Slayer sought to end the dominion of the dark realm."

                    }

                };

                context.Posts.AddRange(Posts);
                context.SaveChanges();

            }

        }

    }
}