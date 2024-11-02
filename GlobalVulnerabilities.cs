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
                SetDebuffVulnerability(entity, Gensokyo, "SeijaKijin", false, true, true, true, null);
                SetDebuffVulnerability(entity, Gensokyo, "MayumiJoutouguu", false, false, null, null, true);
                SetDebuffVulnerability(entity, Gensokyo, "ToyosatomimiNoMiko", false, true, null, null, true);
                SetDebuffVulnerability(entity, Gensokyo, "KaguyaHouraisan", false, null, true, null, true);
                SetDebuffVulnerability(entity, Gensokyo, "UtsuhoReiuji", false, null, null, false, true);
                SetDebuffVulnerability(entity, Gensokyo, "TenshiHinanawi", false, false, null, false, true);
                SetDebuffVulnerability(entity, Gensokyo, "Kisume", false, null, null, null, false);
                //Boss servants
                SetDebuffVulnerability(entity, Gensokyo, "Mouse", null, true, null, null, false);
                SetDebuffVulnerability(entity, Gensokyo, "SekibankiHead", false, true, null, null, null);
                SetDebuffVulnerability(entity, Gensokyo, "MedicineDoll", true, false, null, null, true);
                SetDebuffVulnerability(entity, Gensokyo, "CasterDoll", true, null, null, null, null);
                SetDebuffVulnerability(entity, Gensokyo, "LancerDoll", true, null, null, null, null);
                SetDebuffVulnerability(entity, Gensokyo, "HaniwaArcher", false, false, null, null, true);
                SetDebuffVulnerability(entity, Gensokyo, "HaniwaSoldier", false, false, null, null, true);
                SetDebuffVulnerability(entity, Gensokyo, "HaniwaCavalry", false, false, null, null, true);
                SetDebuffVulnerability(entity, Gensokyo, "HaniwaProtector", false, false, null, null, true);
                SetDebuffVulnerability(entity, Gensokyo, "CursedDecoyDoll", false, false, false, false, false);
                //Enemies
                SetDebuffVulnerability(entity, Gensokyo, "Fairy_Flower", null, true, true, null, false);
                SetDebuffVulnerability(entity, Gensokyo, "Fairy_Rain", null, null, true, false, false);
                SetDebuffVulnerability(entity, Gensokyo, "Fairy_Sand", false, null, false, null, true);
                SetDebuffVulnerability(entity, Gensokyo, "Fairy_Snow", true, null, false, null, false);
                SetDebuffVulnerability(entity, Gensokyo, "Fairy_Water", null, null, true, true, false);
                SetDebuffVulnerability(entity, Gensokyo, "Fairy_Thorn", true, true, false, null, null);
                SetDebuffVulnerability(entity, Gensokyo, "Fairy_Stone", null, null, true, null, true);
                SetDebuffVulnerability(entity, Gensokyo, "Fairy_Blood", true, true, true, null, null);
                SetDebuffVulnerability(entity, Gensokyo, "Fairy_Spore", true, false, null, null, null);
                SetDebuffVulnerability(entity, Gensokyo, "Fairy_Metal", true, null, null, true, null);
                SetDebuffVulnerability(entity, Gensokyo, "Fairy_Bone", false, true, true, true, null);
                SetDebuffVulnerability(entity, Gensokyo, "Fairy_Lava", false, null, null, null, true);
                SetDebuffVulnerability(entity, Gensokyo, "Fairy_Sunflower", null, null, true, null, false);
                SetDebuffVulnerability(entity, Gensokyo, "Fairy_Crystal", false, null, null, null, null);
                SetDebuffVulnerability(entity, Gensokyo, "Yamawaro_Forest", true, null, false, null, null);
                SetDebuffVulnerability(entity, Gensokyo, "Yamawaro_Jungle", true, false, false, null, null);
                SetDebuffVulnerability(entity, Gensokyo, "Kappa", null, null, true, null, false);
                SetDebuffVulnerability(entity, Gensokyo, "Kappa_Hallow", null, null, true, null, false);
                SetDebuffVulnerability(entity, Gensokyo, "Kappa_Crimson", null, null, true, null, false);
                SetDebuffVulnerability(entity, Gensokyo, "Kappa_Corruption", null, null, true, null, false);
                SetDebuffVulnerability(entity, Gensokyo, "VengefulSpirit", true, false, null, null, null);
                SetDebuffVulnerability(entity, Gensokyo, "HellRaven", false, true, null, null, null);
            }
            //Fargo's Souls - requires the Fargo Souls Vulnerability Override toggle to be ON
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
                SetDebuffVulnerability(entity, FargoSoulsMod, "ShadowChampion", null, false, true, null, true);
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
                SetDebuffVulnerability(entity, ThoriumMod, "PatchWerk", true, true, true, null, null);
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
                //Fun fact: The only reason why Biome Mimics got their own vulnerability so early is because they are minibosses, and got the miniboss theme in my personal music mod (which probably won't be released because of the fact that I used many songs that I like and aren't mine - I can share some more info if you really want).
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
                SetDebuffVulnerability(entity, ThoriumMod, "BurstingMaggot", true, true, true, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "CoalescedEnergy", false, false, null, null, true);
                SetDebuffVulnerability(entity, ThoriumMod, "EnergyConduit", false, false, null, null, true);
                SetDebuffVulnerability(entity, ThoriumMod, "CorpsePetal", null, false, true, null, false);
                SetDebuffVulnerability(entity, ThoriumMod, "CorpseWeed", null, false, true, null, false);
                SetDebuffVulnerability(entity, ThoriumMod, "ZealousJellyfish", false, true, null, true, false);
                SetDebuffVulnerability(entity, ThoriumMod, "SpittingJellyfish", false, true, null, true, false);
                SetDebuffVulnerability(entity, ThoriumMod, "FamishedMaggot", true, true, true, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "PhylacteryofaThousandSouls", null, false, null, null, true);
                SetDebuffVulnerability(entity, ThoriumMod, "StormHatchling", false, true, null, false, null);
                //Event Enemies
                SetDebuffVulnerability(entity, ThoriumMod, "Abomination", true, true, true, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "BloodDrop", true, true, true, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "BloodMage", true, true, true, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "BloodyWarg", true, true, true, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "EngorgedEye", true, true, true, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "GraveLimb", true, true, true, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "SeveredLegs", true, true, true, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "SmotheringShade", true, null, false, true, false);
                SetDebuffVulnerability(entity, ThoriumMod, "BlizzardBat", true, true, false, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "FrostBurnt", true, true, false, null, null);
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
                //Enemies - Pre-hardmode
                SetDebuffVulnerability(entity, ThoriumMod, "AncientArcher", null, false, null, null, true); //skeleton
                SetDebuffVulnerability(entity, ThoriumMod, "AncientCharger", null, false, null, null, true);
                SetDebuffVulnerability(entity, ThoriumMod, "AncientPhalanx", null, false, null, null, true);
                SetDebuffVulnerability(entity, ThoriumMod, "ArmyAnt", null, false, true, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "FireAnt", false, null, true, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "BabySpider", true, false, true, null, null); //venomous spider
                SetDebuffVulnerability(entity, ThoriumMod, "Barracuda", false, true, null, true, false); //aquatic
                SetDebuffVulnerability(entity, ThoriumMod, "BigBone", null, false, null, null, true);
                SetDebuffVulnerability(entity, ThoriumMod, "Biter", true, true, true, null, null); //organic
                SetDebuffVulnerability(entity, ThoriumMod, "BizarreRockFormation", null, false, null, null, true);
                SetDebuffVulnerability(entity, ThoriumMod, "Blowfish", false, true, null, true, false);
                SetDebuffVulnerability(entity, ThoriumMod, "Clot", true, true, true, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "Coolmera", true, true, false, null, null); //frost evil
                SetDebuffVulnerability(entity, ThoriumMod, "CoinBagCopper", null, false, null, null, null); //mimic
                SetDebuffVulnerability(entity, ThoriumMod, "DarksteelKnight", null, false, null, null, true);
                SetDebuffVulnerability(entity, ThoriumMod, "EarthenBat", true, true, true, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "EarthenGolem", null, false, null, null, true);
                SetDebuffVulnerability(entity, ThoriumMod, "FlamekinCaster", false, null, null, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "FrostWurmHead", true, true, false, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "FrostWurmBody1", true, true, false, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "FrostWurmBody2", true, true, false, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "FrostWurmTail", true, true, false, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "FrozenFace", true, true, false, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "GelatinousCube", true, false, null, null, null); //slime
                SetDebuffVulnerability(entity, ThoriumMod, "GigaClam", false, true, null, true, false);
                SetDebuffVulnerability(entity, ThoriumMod, "GildedBat", true, true, true, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "GildedSlime", true, false, null, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "GildedSlimeling", true, false, null, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "GildedLycan", true, true, true, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "Globee", false, true, null, true, false);
                SetDebuffVulnerability(entity, ThoriumMod, "GraniteEradicator", null, false, null, null, true);
                SetDebuffVulnerability(entity, ThoriumMod, "GraniteFusedSlime", true, false, null, null, true);
                SetDebuffVulnerability(entity, ThoriumMod, "GraniteSurger", null, false, null, null, true);
                SetDebuffVulnerability(entity, ThoriumMod, "BlueHag", true, true, true, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "CyanHag", true, true, true, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "GreenHag", true, true, true, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "RedHag", true, true, true, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "Hammerhead", false, true, null, true, false);
                SetDebuffVulnerability(entity, ThoriumMod, "HoppingSpider", true, true, true, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "LifeCrystalMimic", null, false, null, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "LivingHemorrhage", true, true, true, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "ManofWar", false, true, null, true, false);
                SetDebuffVulnerability(entity, ThoriumMod, "MahoganyEnt", true, true, true, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "MorayHead", false, true, null, true, false);
                SetDebuffVulnerability(entity, ThoriumMod, "MorayBody", false, true, null, true, false);
                SetDebuffVulnerability(entity, ThoriumMod, "MorayTail", false, true, null, true, false);
                SetDebuffVulnerability(entity, ThoriumMod, "MudMan", true, true, true, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "Nestling", true, true, true, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "Octopus", false, true, null, true, false);
                SetDebuffVulnerability(entity, ThoriumMod, "RagingMinotaur", true, true, true, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "Shambler", null, false, null, null, true);
                SetDebuffVulnerability(entity, ThoriumMod, "CoinBagSilver", null, false, null, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "GelatinousSludge", true, false, null, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "StrangeBulb", true, true, true, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "TheInnocent", true, true, true, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "UFO", null, false, null, true, null); //tech
                SetDebuffVulnerability(entity, ThoriumMod, "UnstableEnergyAnomaly", null, false, null, null, true);
                SetDebuffVulnerability(entity, ThoriumMod, "WindElemental", false, false, true, false, false);
                //Enemies - Hardmode
                SetDebuffVulnerability(entity, ThoriumMod, "AbyssalAngler", false, true, null, true, false); //aquatic
                SetDebuffVulnerability(entity, ThoriumMod, "AstroBeetle", true, true, true, null, null); //organic
                SetDebuffVulnerability(entity, ThoriumMod, "AquaticHallucination", false, true, null, true, false);
                SetDebuffVulnerability(entity, ThoriumMod, "BlackWidow", true, false, true, null, null); //venomous spider
                SetDebuffVulnerability(entity, ThoriumMod, "Blister", true, true, true, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "BlisterPod", true, true, true, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "Blobfish", false, true, null, true, false);
                SetDebuffVulnerability(entity, ThoriumMod, "BoneFlayer", false, false, null, null, true);
                SetDebuffVulnerability(entity, ThoriumMod, "BrownRecluse", true, true, true, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "ChilledSpitter", true, true, false, null, null); //frost evil
                SetDebuffVulnerability(entity, ThoriumMod, "Coldling", true, true, false, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "CrownofThorns", false, true, null, true, false);
                SetDebuffVulnerability(entity, ThoriumMod, "DissonanceSeer", null, false, null, null, null); //mimic
                SetDebuffVulnerability(entity, ThoriumMod, "EpiDermon", false, true, true, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "FeedingFrenzy", false, true, null, true, false);
                SetDebuffVulnerability(entity, ThoriumMod, "Freezer", true, true, false, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "FrostFang", true, true, false, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "FrozenGross", true, true, false, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "GlitteringGolem", false, false, null, null, true); //golem
                SetDebuffVulnerability(entity, ThoriumMod, "CoinBagGold", null, false, null, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "HorrificCharger", true, true, true, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "InfernalHound", false, true, true, null, true);
                SetDebuffVulnerability(entity, ThoriumMod, "Kraken", false, true, null, true, false);
                SetDebuffVulnerability(entity, ThoriumMod, "Lycan", true, true, true, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "LihzardMimic", null, false, null, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "LihzardPotMimic1", null, false, null, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "LihzardPotMimic2", null, false, null, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "MartianScout", true, true, true, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "MartianSentry", null, false, null, true, null); //tech
                SetDebuffVulnerability(entity, ThoriumMod, "MoltenMortar", false, true, true, null, true);
                SetDebuffVulnerability(entity, ThoriumMod, "MossWasp", true, true, true, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "NecroPot", null, false, null, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "PutridSerpent", false, true, null, true, false);
                SetDebuffVulnerability(entity, ThoriumMod, "SnowFlinxMatriarch", true, true, false, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "SoulCorrupter", false, true, true, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "Spectrumite", false, null, null, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "SunPriestess", true, true, true, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "Tarantula", true, false, true, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "TheStarved", true, true, true, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "Whale", false, true, null, true, false);
                SetDebuffVulnerability(entity, ThoriumMod, "UnderworldPot1", null, false, null, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "UnderworldPot2", null, false, null, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "VampireSquid", false, true, null, true, false);
                SetDebuffVulnerability(entity, ThoriumMod, "VileFloater", true, true, true, null, null);
                SetDebuffVulnerability(entity, ThoriumMod, "VoltEelHead", false, true, null, true, false);
                SetDebuffVulnerability(entity, ThoriumMod, "VoltEelBody1", false, true, null, true, false);
                SetDebuffVulnerability(entity, ThoriumMod, "VoltEelBody2", false, true, null, true, false);
                SetDebuffVulnerability(entity, ThoriumMod, "VoltEelTail", false, true, null, true, false);
            }
            base.SetDefaults(entity);
        }
    }
}
