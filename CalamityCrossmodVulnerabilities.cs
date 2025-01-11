using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;

namespace CalamityCrossmodVulnerabilities
{
	// Please read https://github.com/tModLoader/tModLoader/wiki/Basic-tModLoader-Modding-Guide#mod-skeleton-contents for more information about the various files in a mod.
	public class CalamityCrossmodVulnerabilities : Mod
	{
        public static Mod CalamityMod { get; private set; }
        public static Mod Gensokyo { get; private set; }
        public static Mod FargoSoulsMod { get; private set; }
        public static Mod ThoriumMod { get; private set; }
        public static Mod TheStarsAbove { get; private set; }
        /// <summary>
        /// Contains the randomized debuff vulnerabilities for Arbitration.
        /// </summary>
        public static bool?[] ArbitrationVulnerabilities = new bool?[5];
        public override void Load()
        {
            ModLoader.TryGetMod("CalamityMod", out Mod calamityMod);
            CalamityMod = calamityMod;
            ModLoader.TryGetMod("Gensokyo", out Mod gensokyo);
            Gensokyo = gensokyo;
            ModLoader.TryGetMod("FargowiltasSouls", out Mod fargoSoulsMod);
            FargoSoulsMod = fargoSoulsMod;
            ModLoader.TryGetMod("ThoriumMod", out Mod thoriumMod);
            ThoriumMod = thoriumMod;
            ModLoader.TryGetMod("StarsAbove", out Mod theStarsAbove);
            TheStarsAbove = theStarsAbove;
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                switch (random.Next(0, 3))
                {
                    case 0:
                        ArbitrationVulnerabilities[i] = true;
                        break;
                    case 1:
                        ArbitrationVulnerabilities[i] = false;
                        break;
                    case 2:
                        ArbitrationVulnerabilities[i] = null;
                        break;
                    default:
                        ArbitrationVulnerabilities[i] = null;
                        break;
                }
            }
        }
        /// <summary>
        /// Returns true if Calamity mod is loaded. Could be done with a strong reference, but I don't know how to do custom vulnerabilities in a way other than mod calls. Still, the strong reference is here anyway, because why it wouldn't be - this mod makes no sense being active without Calamity in the first place
        /// </summary>
        public static bool IsCalamityLoaded => CalamityMod != null;
        /// <summary>
        /// Returns true if Gensokyo mod is loaded.
        /// </summary>
        public static bool IsGensokyoLoaded => Gensokyo != null;
        /// <summary>
        /// Returns true if Fargo's Souls mod is loaded.
        /// </summary>
        public static bool IsFargoSoulsLoaded => FargoSoulsMod != null;
        /// <summary>
        /// Returns true if Thorium Mod is loaded.
        /// </summary>
        public static bool IsThoriumModLoaded => ThoriumMod != null;
        /// <summary>
        /// Returns true if The Stars Above mod is loaded.
        /// </summary>
        public static bool IsTSALoaded => TheStarsAbove != null;
    }
}
