/*
 * Copyright (C) 2012-2013 Arctium <http://arctium.org>
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

using System.Collections.Generic;

namespace Framework.DBC
{
    public static class DBCStorage
    {
        internal static int DBCFileCount = 0;

        public static Dictionary<uint, Achievement> AchievementStorage;
        public static Dictionary<uint, AchievementCategory> AchievementCategoryStorage;
        public static Dictionary<uint, AchievementCriteria> AchievementCriteriaStorage;
        public static Dictionary<uint, AnimationData> AnimationDataStorage;
        public static Dictionary<uint, AnimKit> AnimKitStorage;
        public static Dictionary<uint, AnimKitBoneSet> AnimKitBoneSetStorage;
        public static Dictionary<uint, AnimKitBoneSetAlias> AnimKitBoneSetAliasStorage;
        public static Dictionary<uint, AnimKitConfig> AnimKitConfigStorage;
        public static Dictionary<uint, AnimKitConfigBoneSet> AnimKitConfigBoneSetStorage;
        public static Dictionary<uint, AnimKitPriority> AnimKitPriorityStorage;
        public static Dictionary<uint, AnimKitSegment> AnimKitSegmentStorage;
        public static Dictionary<uint, AnimReplacement> AnimReplacementStorage;
        public static Dictionary<uint, AnimReplacementSet> AnimReplacementSetStorage;
        public static Dictionary<uint, AreaAssignment> AreaAssignmentStorage;
        public static Dictionary<uint, AreaGroup> AreaGroupStorage;
        public static Dictionary<uint, AreaPOI> AreaPOIStorage;
        public static Dictionary<uint, AreaTable> AreaTableStorage;
        public static Dictionary<uint, AreaTrigger> AreaTriggerStorage;
        public static Dictionary<uint, AreaTriggerActionSet> AreaTriggerActionSetStorage;
        public static Dictionary<uint, AreaTriggerBox> AreaTriggerBoxStorage;
        public static Dictionary<uint, AreaTriggerSphere> AreaTriggerSphereStorage;
        public static Dictionary<uint, ArmorLocation> ArmorLocationStorage;
        public static Dictionary<uint, AttackAnimKits> AttackAnimKitsStorage;
        public static Dictionary<uint, AttackAnimTypes> AttackAnimTypesStorage;
        public static Dictionary<uint, AuctionHouse> AuctionHouseStorage;
        public static Dictionary<uint, BankBagSlotPrices> BankBagSlotPricesStorage;
        public static Dictionary<uint, BannedAddOns> BannedAddOnsStorage;
        public static Dictionary<uint, BarberShopStyle> BarberShopStyleStorage;
        public static Dictionary<uint, BattleMasterList> BattleMasterListStorage;
        public static Dictionary<uint, CameraMode> CameraModeStorage;
        public static Dictionary<uint, CameraShakes> CameraShakesStorage;
        public static Dictionary<uint, CastableRaidBuffs> CastableRaidBuffsStorage;
        public static Dictionary<uint, CfgCategories> CfgCategoriesStorage;
        public static Dictionary<uint, CfgConfigs> CfgConfigsStorage;
        public static Dictionary<uint, CfgRegions> CfgRegionsStorage;
        public static Dictionary<uint, CharacterFacialHairStyles> CharacterFacialHairStylesStorage;
        public static Dictionary<uint, CharacterLoadout> CharacterLoadoutStorage;
        public static Dictionary<uint, CharacterLoadoutItem> CharacterLoadoutItemStorage;
        public static Dictionary<uint, CharBaseInfo> CharBaseInfoStorage;
        public static Dictionary<uint, CharComponentTextureLayouts> CharComponentTextureLayoutsStorage;
        public static Dictionary<uint, CharComponentTextureSections> CharComponentTextureSectionsStorage;
        public static Dictionary<uint, CharHairGeosets> CharHairGeosetsStorage;
        public static Dictionary<uint, CharSections> CharSectionsStorage;
        public static Dictionary<uint, CharTitles> CharTitlesStorage;
        public static Dictionary<uint, ChatChannels> ChatChannelsStorage;
        public static Dictionary<uint, ChatProfanity> ChatProfanityStorage;
        public static Dictionary<uint, ChrClasses> ChrClassesStorage;
        public static Dictionary<uint, ChrClassesXPowerTypes> ChrClassesXPowerTypesStorage;
        public static Dictionary<uint, ChrRaces> RaceStorage;
        public static Dictionary<uint, CharStartOutfit> CharStartOutfitStorage;
        public static Dictionary<uint, NameGen> NameGenStorage;
        public static Dictionary<uint, ChrSpecialization> SpecializationStorage;
        public static Dictionary<uint, SpecializationSpell> SpecializationSpellStorage;
        public static Dictionary<uint, Spell> SpellStorage;
        public static Dictionary<uint, SpellLevels> SpellLevelStorage;
        public static Dictionary<uint, Talent> TalentStorage;

        //Strings
        internal static Dictionary<uint, string> ClassStrings = new Dictionary<uint, string>();
        internal static Dictionary<uint, string> RaceStrings = new Dictionary<uint, string>();
        internal static Dictionary<uint, string> NameGenStrings = new Dictionary<uint, string>();
    }
}
