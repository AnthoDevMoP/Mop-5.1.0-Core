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

using Framework.Logging;

namespace Framework.DBC
{
    public class DBCLoader
    {
        public static void Init()
        {
            Log.Message(LogType.NORMAL, "Loading DBCStorage...");
            
            Log.Message(LogType.NORMAL, "Loading DBCStorage...");
            DBCStorage.AchievementStorage = DBCReader.ReadDBC<Achievement>(null, DBCFmt.AchievementEntryfmt, "Achievement.dbc");
            DBCStorage.AchievementCategoryStorage = DBCReader.ReadDBC<AchievementCategory>(null, DBCFmt.AchievementCategoryEntryfmt, "Achievement_Category.dbc");
            DBCStorage.AchievementCriteriaStorage = DBCReader.ReadDBC<AchievementCriteria>(null, DBCFmt.AchievementCriteriaEntryfmt, "Achievement_Criteria.dbc");
            DBCStorage.AnimationDataStorage = DBCReader.ReadDBC<AnimationData>(null, DBCFmt.AnimationDataEntryfmt, "AnimationData.dbc");
            DBCStorage.AnimKitStorage = DBCReader.ReadDBC<AnimKit>(null, DBCFmt.AnimKitEntryfmt, "AnimKit.dbc");
            DBCStorage.AnimKitBoneSetStorage = DBCReader.ReadDBC<AnimKitBoneSet>(null, DBCFmt.AnimKitBoneSetEntryfmt, "AnimKitBoneSet.dbc");
            DBCStorage.AnimKitBoneSetAliasStorage = DBCReader.ReadDBC<AnimKitBoneSetAlias>(null, DBCFmt.AnimKitBoneSetAliasEntryfmt, "AnimKitBoneSetAlias.dbc");
            DBCStorage.AnimKitConfigStorage = DBCReader.ReadDBC<AnimKitConfig>(null, DBCFmt.AnimKitConfigEntryfmt, "AnimKitConfig.dbc");
            DBCStorage.AnimKitConfigBoneSetStorage = DBCReader.ReadDBC<AnimKitConfigBoneSet>(null, DBCFmt.AnimKitConfigBoneSetEntryfmt, "AnimKitConfigBoneSet.dbc");
            DBCStorage.AnimKitPriorityStorage = DBCReader.ReadDBC<AnimKitPriority>(null, DBCFmt.AnimKitPriorityEntryfmt, "AnimKitPriority.dbc");
            DBCStorage.AnimKitSegmentStorage = DBCReader.ReadDBC<AnimKitSegment>(null, DBCFmt.AnimKitSegmentEntryfmt, "AnimKitSegment.dbc");
            DBCStorage.AnimReplacementStorage = DBCReader.ReadDBC<AnimReplacement>(null, DBCFmt.AnimReplacementEntryfmt, "AnimReplacement.dbc");
            DBCStorage.AnimReplacementSetStorage = DBCReader.ReadDBC<AnimReplacementSet>(null, DBCFmt.AnimReplacementSetEntryfmt, "AnimReplacementSet.dbc");
            DBCStorage.AreaAssignmentStorage = DBCReader.ReadDBC<AreaAssignment>(null, DBCFmt.AreaAssignmentEntryfmt, "AreaAssignment.dbc");
            DBCStorage.AreaGroupStorage = DBCReader.ReadDBC<AreaGroup>(null, DBCFmt.AreaGroupEntryfmt, "AreaGroup.dbc");
            DBCStorage.AreaPOIStorage = DBCReader.ReadDBC<AreaPOI>(null, DBCFmt.AreaPOIEntryfmt, "AreaPOI.dbc");
            DBCStorage.AreaTableStorage = DBCReader.ReadDBC<AreaTable>(null, DBCFmt.AreaTableEntryfmt, "AreaTable.dbc");
            DBCStorage.AreaTriggerStorage = DBCReader.ReadDBC<AreaTrigger>(null, DBCFmt.AreaTriggerEntryfmt, "AreaTrigger.dbc");
            DBCStorage.AreaTriggerActionSetStorage = DBCReader.ReadDBC<AreaTriggerActionSet>(null, DBCFmt.AreaTriggerActionSetEntryfmt, "AreaTriggerActionSet.dbc");
            DBCStorage.AreaTriggerBoxStorage = DBCReader.ReadDBC<AreaTriggerBox>(null, DBCFmt.AreaTriggerBoxEntryfmt, "AreaTriggerBox.dbc");
            DBCStorage.AreaTriggerSphereStorage = DBCReader.ReadDBC<AreaTriggerSphere>(null, DBCFmt.AreaTriggerSphereEntryfmt, "AreaTriggerSphere.dbc");
            DBCStorage.ArmorLocationStorage = DBCReader.ReadDBC<ArmorLocation>(null, DBCFmt.ArmorLocationEntryfmt, "ArmorLocation.dbc");
            DBCStorage.AttackAnimKitsStorage = DBCReader.ReadDBC<AttackAnimKits>(null, DBCFmt.AttackAnimKitsEntryfmt, "AttackAnimKits.dbc");
            DBCStorage.AttackAnimTypesStorage = DBCReader.ReadDBC<AttackAnimTypes>(null, DBCFmt.AttackAnimTypesEntryfmt, "AttackAnimTypes.dbc");
            DBCStorage.AuctionHouseStorage = DBCReader.ReadDBC<AuctionHouse>(null, DBCFmt.AuctionHouseEntryfmt, "AuctionHouse.dbc");
            DBCStorage.BankBagSlotPricesStorage = DBCReader.ReadDBC<BankBagSlotPrices>(null, DBCFmt.BankBagSlotPricesEntryfmt, "BankBagSlotPrices.dbc");
            DBCStorage.BannedAddOnsStorage = DBCReader.ReadDBC<BannedAddOns>(null, DBCFmt.BannedAddOnsEntryfmt, "BannedAddOns.dbc");
            DBCStorage.BarberShopStyleStorage = DBCReader.ReadDBC<BarberShopStyle>(null, DBCFmt.BarberShopStyleEntryfmt, "BarberShopStyle.dbc");
            DBCStorage.BattleMasterListStorage = DBCReader.ReadDBC<BattleMasterList>(null, DBCFmt.BattleMasterListEntryfmt, "BattleMasterList.dbc");
            DBCStorage.CameraModeStorage = DBCReader.ReadDBC<CameraMode>(null, DBCFmt.CameraModeEntryfmt, "CameraMode.dbc");
            DBCStorage.CameraShakesStorage = DBCReader.ReadDBC<CameraShakes>(null, DBCFmt.CameraShakesEntryfmt, "CameraShakes.dbc");
            DBCStorage.CastableRaidBuffsStorage = DBCReader.ReadDBC<CastableRaidBuffs>(null, DBCFmt.CastableRaidBuffsEntryfmt, "CastableRaidBuffs.dbc");
            DBCStorage.CfgCategoriesStorage = DBCReader.ReadDBC<CfgCategories>(null, DBCFmt.CfgCategoriesEntryfmt, "Cfg_Categories.dbc");
            DBCStorage.CfgConfigsStorage = DBCReader.ReadDBC<CfgConfigs>(null, DBCFmt.CfgConfigsEntryfmt, "Cfg_Configs.dbc");
            DBCStorage.CfgRegionsStorage = DBCReader.ReadDBC<CfgRegions>(null, DBCFmt.CfgRegionsEntryfmt, "Cfg_Regions.dbc");
            DBCStorage.CharacterFacialHairStylesStorage = DBCReader.ReadDBC<CharacterFacialHairStyles>(null, DBCFmt.CharacterFacialHairStylesEntryfmt, "CharacterFacialHairStyles.dbc");
            DBCStorage.CharacterLoadoutStorage = DBCReader.ReadDBC<CharacterLoadout>(null, DBCFmt.CharacterLoadoutEntryfmt, "CharacterLoadout.dbc");
            DBCStorage.CharacterLoadoutItemStorage = DBCReader.ReadDBC<CharacterLoadoutItem>(null, DBCFmt.CharacterLoadoutItemEntryfmt, "CharacterLoadoutItem.dbc");
            DBCStorage.CharBaseInfoStorage = DBCReader.ReadDBC<CharBaseInfo>(null, DBCFmt.CharBaseInfoEntryfmt, "CharBaseInfo.dbc");
            DBCStorage.CharComponentTextureLayoutsStorage = DBCReader.ReadDBC<CharComponentTextureLayouts>(null, DBCFmt.CharComponentTextureLayoutsEntryfmt, "CharComponentTextureLayouts.dbc");
            DBCStorage.CharComponentTextureSectionsStorage = DBCReader.ReadDBC<CharComponentTextureSections>(null, DBCFmt.CharComponentTextureSectionsEntryfmt, "CharComponentTextureSections.dbc");
            DBCStorage.CharHairGeosetsStorage = DBCReader.ReadDBC<CharHairGeosets>(null, DBCFmt.CharHairGeosetsEntryfmt, "CharHairGeosets.dbc");
            DBCStorage.CharSectionsStorage = DBCReader.ReadDBC<CharSections>(null, DBCFmt.CharSectionsEntryfmt, "CharSections.dbc");
            DBCStorage.CharTitlesStorage = DBCReader.ReadDBC<CharTitles>(null, DBCFmt.CharTitlesEntryfmt, "CharTitles.dbc");
            DBCStorage.ChatChannelsStorage = DBCReader.ReadDBC<ChatChannels>(null, DBCFmt.ChatChannelsEntryfmt, "ChatChannels.dbc");
            DBCStorage.ChatProfanityStorage = DBCReader.ReadDBC<ChatProfanity>(null, DBCFmt.ChatProfanityEntryfmt, "ChatProfanity.dbc");
            DBCStorage.ChrClassesStorage = DBCReader.ReadDBC<ChrClasses>(null, DBCFmt.ChrClassesEntryfmt, "ChrClasses.dbc");
            DBCStorage.ChrClassesXPowerTypesStorage = DBCReader.ReadDBC<ChrClassesXPowerTypes>(null, DBCFmt.ChrClassesXPowerTypesEntryfmt, "ChrClassesXPowerTypes.dbc");
            DBCStorage.ClassStorage = DBCReader.ReadDBC<ChrClasses>(null, DBCFmt.ChrClassesEntryfmt, "ChrClasses.dbc");
            DBCStorage.CharStartOutfitStorage = DBCReader.ReadDBC<CharStartOutfit>(null, DBCFmt.CharStartOutfitfmt, "CharStartOutfit.dbc");
            DBCStorage.NameGenStorage = DBCReader.ReadDBC<NameGen>(DBCStorage.NameGenStrings, DBCFmt.NameGenfmt, "NameGen.dbc");
            DBCStorage.SpecializationStorage = DBCReader.ReadDBC<ChrSpecialization>(null, DBCFmt.ChrSpecializationfmt, "ChrSpecialization.dbc");
            DBCStorage.SpecializationSpellStorage = DBCReader.ReadDBC<SpecializationSpell>(null, DBCFmt.SpecializationSpellfmt, "SpecializationSpells.dbc");
            DBCStorage.SpellStorage = DBCReader.ReadDBC<Spell>(null, DBCFmt.Spellfmt, "Spell.dbc");
            DBCStorage.SpellLevelStorage = DBCReader.ReadDBC<SpellLevels>(null, DBCFmt.SpellLevelsfmt, "SpellLevels.dbc");
            DBCStorage.TalentStorage = DBCReader.ReadDBC<Talent>(null, DBCFmt.TalentEntryfmt, "Talent.dbc");

            Log.Message(LogType.NORMAL, "Loaded {0} dbc files.", DBCStorage.DBCFileCount);
            Log.Message();
        }
    }
}
