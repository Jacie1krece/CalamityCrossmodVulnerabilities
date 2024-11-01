using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace CalamityCrossmodVulnerabilities
{
    internal class GlobalVulnerabilities : GlobalNPC
    {
        public static bool IsCalamityLoaded = CalamityCrossmodVulnerabilities.IsCalamityLoaded;
        public static Mod CalamityMod = CalamityCrossmodVulnerabilities.CalamityMod;
        public static bool IsGensokyoLoaded = CalamityCrossmodVulnerabilities.IsGensokyoLoaded;
        public static Mod Gensokyo = CalamityCrossmodVulnerabilities.Gensokyo;
        public static bool IsFargoSoulsLoaded = CalamityCrossmodVulnerabilities.IsFargoSoulsLoaded;
        public static Mod FargoSoulsMod = CalamityCrossmodVulnerabilities.FargoSoulsMod;
        public static bool IsThoriumModLoaded = CalamityCrossmodVulnerabilities.IsThoriumModLoaded;
        public static Mod ThoriumMod = CalamityCrossmodVulnerabilities.ThoriumMod;
        public static bool FargoSoulsVulnerabilityOverride => ModContent.GetInstance<VulnerabilityConfig>().FargoSoulsVulnerabilityToggle;
        /// <summary>
        /// Sets Calamity's debuff vulnerabilities for a specific modded NPC.
        /// </summary>
        /// <param name="entity">The NPC to modify vulnerabilities.</param>
        /// <param name="mod">The mod that will be searched for the NPC.</param>
        /// <param name="NPC">Name of the NPC that should get the modified vulnerabilities</param>
        /// <param name="heat">The vulnerablity to heat debuffs. True if vulnerable, false if resistant, null if neutral.</param>
        /// <param name="sickness">The vulnerablity to sickness debuffs. True if vulnerable, false if resistant, null if neutral.</param>
        /// <param name="cold">The vulnerablity to cold debuffs. True if vulnerable, false if resistant, null if neutral.</param>
        /// <param name="electricity">The vulnerablity to electricity debuffs. True if vulnerable, false if resistant, null if neutral.</param>
        /// <param name="water">The vulnerablity to water debuffs. True if vulnerable, false if resistant, null if neutral.</param>
        public static void SetDebuffVulnerability(NPC entity, Mod mod, string NPC, bool? heat, bool? sickness, bool? cold, bool? electricity, bool? water)
        {
            mod.TryFind(NPC, out ModNPC entityCheck);
            if (entity.type == entityCheck.Type)
            {
                CalamityMod.Call("SetDebuffVulnerability", entity, "heat", heat);
                CalamityMod.Call("SetDebuffVulnerability", entity, "sickness", sickness);
                CalamityMod.Call("SetDebuffVulnerability", entity, "cold", cold);
                CalamityMod.Call("SetDebuffVulnerability", entity, "electricity", electricity);
                CalamityMod.Call("SetDebuffVulnerability", entity, "water", water);
            }    
        }
        public override void SetDefaults(NPC entity)
        {
            //Gensokyo
            if (IsGensokyoLoaded)
            {
                //Bosses
                SetDebuffVulnerability(entity, Gensokyo, "LilyWhite", null, null, false, null, false);
                SetDebuffVulnerability(entity, Gensokyo, "Rumia", true, null, false, true, false);
                SetDebuffVulnerability(entity, Gensokyo, "EternityLarva", null, false, true, null, null);
                SetDebuffVulnerability(entity, Gensokyo, "Nazrin", null, true, null, null, false);
                SetDebuffVulnerability(entity, Gensokyo, "HinaKagiyama", true, false, null, null, false);
                SetDebuffVulnerability(entity, Gensokyo, "Sekibanki", false, true, null, null, null);
                SetDebuffVulnerability(entity, Gensokyo, "Seiran", null, false, false, null, null);
                SetDebuffVulnerability(entity, Gensokyo, "NitoriKawashiro", null, null, true, null, false);
                SetDebuffVulnerability(entity, Gensokyo, "MedicineMelancholy", true, false, null, null, true);
                SetDebuffVulnerability(entity, Gensokyo, "Cirno", true, null, false, null, false);
                SetDebuffVulnerability(entity, Gensokyo, "MinamitsuMurasa", true, false, null, null, false);
                SetDebuffVulnerability(entity, Gensokyo, "AliceMargatroid", true, true, null, null, null);
                SetDebuffVulnerability(entity, Gensokyo, "BenbenTsukumo", true, false, null, false, true);
                SetDebuffVulnerability(entity, Gensokyo, "YatsuhashiTsukumo", true, false, null, false, true);
                SetDebuffVulnerability(entity, Gensokyo, "SakuyaIzayoi", null, true, false, null, null);
                SetDebuffVulnerability(entity, Gensokyo, "SeijaKijin", false, true, true, true, true);
                SetDebuffVulnerability(entity, Gensokyo, "MayumiJoutouguu", false, false, null, null, null);
                SetDebuffVulnerability(entity, Gensokyo, "ToyosatomimiNoMiko", false, true, null, null, true);
                SetDebuffVulnerability(entity, Gensokyo, "KaguyaHouraisan", false, null, true, null, true);
                //Koishi Komeiji? Who's that?
                SetDebuffVulnerability(entity, Gensokyo, "UtsuhoReiuji", false, null, null, false, true);
                SetDebuffVulnerability(entity, Gensokyo, "TenshiHinanawi", false, false, null, false, true);
                SetDebuffVulnerability(entity, Gensokyo, "Kisume", false, null, null, null, false);
                //Boss servants
                SetDebuffVulnerability(entity, Gensokyo, "Mouse", null, true, null, null, false);
                SetDebuffVulnerability(entity, Gensokyo, "SekibankiHead", false, true, null, null, null);
                SetDebuffVulnerability(entity, Gensokyo, "MedicineDoll", true, false, null, null, true);
                SetDebuffVulnerability(entity, Gensokyo, "CasterDoll", true, null, null, null, null);
                SetDebuffVulnerability(entity, Gensokyo, "LancerDoll", true, null, null, null, null);
                SetDebuffVulnerability(entity, Gensokyo, "HaniwaArcher", false, false, null, null, null);
                SetDebuffVulnerability(entity, Gensokyo, "HaniwaSoldier", false, false, null, null, null);
                SetDebuffVulnerability(entity, Gensokyo, "HaniwaCavalry", false, false, null, null, null);
                SetDebuffVulnerability(entity, Gensokyo, "HaniwaProtector", false, false, null, null, null);
                SetDebuffVulnerability(entity, Gensokyo, "CursedDecoyDoll", false, false, false, false, false);
                //Enemies
                SetDebuffVulnerability(entity, Gensokyo, "Fairy_Flower", null, true, true, null, false);
                SetDebuffVulnerability(entity, Gensokyo, "Fairy_Rain", null, null, true, false, false);
                SetDebuffVulnerability(entity, Gensokyo, "Fairy_Sand", false, null, false, null, true);
                SetDebuffVulnerability(entity, Gensokyo, "Fairy_Snow", true, null, false, null, false);
                SetDebuffVulnerability(entity, Gensokyo, "Fairy_Water", null, null, true, true, false);
                SetDebuffVulnerability(entity, Gensokyo, "Fairy_Thorn", true, false, false, null, null);
                SetDebuffVulnerability(entity, Gensokyo, "Fairy_Stone", null, null, true, null, true);
                SetDebuffVulnerability(entity, Gensokyo, "Fairy_Blood", true, true, true, null, null);
                SetDebuffVulnerability(entity, Gensokyo, "Fairy_Spore", true, false, null, null, null);
                SetDebuffVulnerability(entity, Gensokyo, "Fairy_Metal", true, null, null, true, null);
                SetDebuffVulnerability(entity, Gensokyo, "Fairy_Bone", false, false, true, true, null);
                SetDebuffVulnerability(entity, Gensokyo, "Fairy_Lava", false, null, null, null, true);
                SetDebuffVulnerability(entity, Gensokyo, "Fairy_Sunflower", null, null, true, null, false);
                SetDebuffVulnerability(entity, Gensokyo, "Fairy_Crystal", false, null, null, null, null);
                SetDebuffVulnerability(entity, Gensokyo, "Yamawaro_Forest", true, null, false, null, null);
                SetDebuffVulnerability(entity, Gensokyo, "Yamawaro_Jungle", true, false, false, null, null);
                SetDebuffVulnerability(entity, Gensokyo, "Kappa", null, null, true, null, false);
                SetDebuffVulnerability(entity, Gensokyo, "Kappa_Hallow", null, null, true, null, false);
                SetDebuffVulnerability(entity, Gensokyo, "Kappa_Crimson", null, false, true, null, false);
                SetDebuffVulnerability(entity, Gensokyo, "Kappa_Corruption", null, false, true, null, false);
                SetDebuffVulnerability(entity, Gensokyo, "VengefulSpirit", true, false, null, null, null);
                SetDebuffVulnerability(entity, Gensokyo, "HellRaven", false, true, null, null, null);
            }
            //Fargo's Souls
            if (IsFargoSoulsLoaded && FargoSoulsVulnerabilityOverride)
            {
                //Bosses
                SetDebuffVulnerability(entity, FargoSoulsMod, "TrojanSquirrel", true, null, null, null, true);
                SetDebuffVulnerability(entity, FargoSoulsMod, "DeviBoss", true, true, false, null, null);
                SetDebuffVulnerability(entity, FargoSoulsMod, "BanishedBaron", null, false, null, true, null);
                SetDebuffVulnerability(entity, FargoSoulsMod, "LifeChallenger", true, null, null, false, null);
                SetDebuffVulnerability(entity, FargoSoulsMod, "TimberChampion", true, null, null, null, true);
                SetDebuffVulnerability(entity, FargoSoulsMod, "TimberChampionHead", true, null, null, null, true);
                SetDebuffVulnerability(entity, FargoSoulsMod, "TerraChampion", null, null, true, false, true);
                SetDebuffVulnerability(entity, FargoSoulsMod, "SpiritChampion", false, false, null, null, true);
                SetDebuffVulnerability(entity, FargoSoulsMod, "LifeChampion", true, null, null, false, null);
                SetDebuffVulnerability(entity, FargoSoulsMod, "ShadowChampion", true, false, null, true, null);
                SetDebuffVulnerability(entity, FargoSoulsMod, "WillChampion", null, false, null, true, false);
                SetDebuffVulnerability(entity, FargoSoulsMod, "NatureChampion", false, false, false, null, null);
                SetDebuffVulnerability(entity, FargoSoulsMod, "EarthChampion", false, null, true, null, true);
                SetDebuffVulnerability(entity, FargoSoulsMod, "CosmosChampion", false, null, false, false, false);
                SetDebuffVulnerability(entity, FargoSoulsMod, "AbomBoss", false, true, null, null, true);
                SetDebuffVulnerability(entity, FargoSoulsMod, "MutantBoss", null, true, true, null, false);
                SetDebuffVulnerability(entity, FargoSoulsMod, "CursedCoffin", false, false, null, null, true);
            }
            //Thorium
            if (IsThoriumModLoaded)
            {
                //Bosses
                SetDebuffVulnerability(entity, ThoriumMod, "TheGrandThunderBirdv2", false, true, null, false, null);
                SetDebuffVulnerability(entity, ThoriumMod, "PatchWerk", null, false, null, null, true);
                SetDebuffVulnerability(entity, ThoriumMod, "QueenJelly", false, true, null, true, false);
                SetDebuffVulnerability(entity, ThoriumMod, "Viscount", true, true, null, null, true);
                SetDebuffVulnerability(entity, ThoriumMod, "CorpseBloom", null, false, true, null, false);
                SetDebuffVulnerability(entity, ThoriumMod, "Illusionist", null, false, null, null, true);
                SetDebuffVulnerability(entity, ThoriumMod, "GraniteEnergyStorm", null, false, null, null, true);
                SetDebuffVulnerability(entity, ThoriumMod, "TheBuriedWarrior", null, false, null, null, true);
                SetDebuffVulnerability(entity, ThoriumMod, "ThePrimeScouter", null, false, null, true, null);
                SetDebuffVulnerability(entity, ThoriumMod, "BoreanStrider", true, true, false, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "BoreanStriderPopped", true, true, false, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "FallenDeathBeholder", false, null, null, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "FallenDeathBeholder2", false, null, null, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "Lich", null, false, null, null, true);
                SetDebuffVulnerability(entity, ThoriumMod, "LichHeadless", null, false, null, null, true);
                SetDebuffVulnerability(entity, ThoriumMod, "Abyssion", null, false, null, null, false);
                SetDebuffVulnerability(entity, ThoriumMod, "AbyssionCracked", null, null, null, null, false);
                SetDebuffVulnerability(entity, ThoriumMod, "AbyssionReleased", null, true, null, null, false);
                SetDebuffVulnerability(entity, ThoriumMod, "SlagFury", false, false, null, null, true);
                SetDebuffVulnerability(entity, ThoriumMod, "Aquaius", false, true, null, null, false);
                SetDebuffVulnerability(entity, ThoriumMod, "Omnicide", true, false, null, null, false);
                SetDebuffVulnerability(entity, ThoriumMod, "DreamEater", false, false, null, null, false);
                //Biome mimics
                //Fun fact: The only reason why Biome Mimics got their own vulnerability so early is because they are minibosses, and got the miniboss theme in my personal music mod (which probably won't be released because of the fact that I used many songs that I like and aren't mine).
                SetDebuffVulnerability(entity, ThoriumMod, "SubmergedMimic", null, false, null, null, false);
                SetDebuffVulnerability(entity, ThoriumMod, "HellBringerMimic", false, false, null, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "MyceliumMimic", null, false, null, null, null);
                //Boss servants
                SetDebuffVulnerability(entity, ThoriumMod, "AbyssalSpawn", null, true, null, null, false);
                SetDebuffVulnerability(entity, ThoriumMod, "Beholder", false, null, null, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "PyroCore", false, false, true, true, null);
                SetDebuffVulnerability(entity, ThoriumMod, "BioCore", true, false, false, true, null);
                SetDebuffVulnerability(entity, ThoriumMod, "CryoCore", false, true, false, true, null);
                SetDebuffVulnerability(entity, ThoriumMod, "BiteyBaby", true, true, null, null, true);
                SetDebuffVulnerability(entity, ThoriumMod, "BoreanHopper", true, true, false, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "BoreanMyte", true, true, false, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "BurstingMaggot", null, false, null, null, true);
                SetDebuffVulnerability(entity, ThoriumMod, "CoalescedEnergy", false, false, null, null, true);
                SetDebuffVulnerability(entity, ThoriumMod, "EnergyConduit", false, false, null, null, true);
                SetDebuffVulnerability(entity, ThoriumMod, "CorpsePetal", null, false, true, null, false);
                SetDebuffVulnerability(entity, ThoriumMod, "CorpseWeed", null, false, true, null, false);
                SetDebuffVulnerability(entity, ThoriumMod, "ZealousJellyfish", false, true, null, true, false);
                SetDebuffVulnerability(entity, ThoriumMod, "SpittingJellyfish", false, true, null, true, false);
                SetDebuffVulnerability(entity, ThoriumMod, "FamishedMaggot", null, false, null, null, true);
                SetDebuffVulnerability(entity, ThoriumMod, "PhylacteryofaThousandSouls", null, false, null, null, true);
                SetDebuffVulnerability(entity, ThoriumMod, "StormHatchling", false, true, null, false, null);
                //Event Enemies
                SetDebuffVulnerability(entity, ThoriumMod, "Abomination", null, false, null, null, true);
                SetDebuffVulnerability(entity, ThoriumMod, "BloodDrop", true, true, true, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "BloodMage", true, true, true, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "BloodyWarg", null, false, null, null, true);
                SetDebuffVulnerability(entity, ThoriumMod, "EngorgedEye", true, true, true, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "GraveLimb", null, false, null, null, true);
                SetDebuffVulnerability(entity, ThoriumMod, "SeveredLegs", null, false, null, null, true);
                SetDebuffVulnerability(entity, ThoriumMod, "SmotheringShade", true, null, false, true, false);
                SetDebuffVulnerability(entity, ThoriumMod, "BlizzardBat", true, true, false, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "FrostBurnt", true, false, false, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "FrostBurntFlayer", true, false, false, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "SnowElemental", true, false, false, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "SnowyOwl", true, true, false, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "GoblinDrummer", true, true, true, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "GoblinTrapper", true, true, true, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "GoblinSpiritGuide", true, true, true, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "ShadowflameRevenant", true, true, true, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "SeaShantySinger", true, true, true, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "LeFantome", true, true, true, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "ScissorStalker", true, true, true, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "SnowSinga", true, false, false, null, null);
            }
            base.SetDefaults(entity);
        }
    }
}
