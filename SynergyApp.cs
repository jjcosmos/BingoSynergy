using System;
using Godot;
using System.Collections.Generic;
using System.Linq;

public partial class SynergyApp : Node
{
    public const float MAX_RATING_FOR_SQUARE = 10f;
    
    public static readonly List<BingoGoalWithActions> _Data = new List<BingoGoalWithActions>()
    {
        new BingoGoalWithActions()
        {
            Goal = BingoGoal.KillDuoBosses,
            Actions = new List<BingoAction>()
            {
                BingoAction.KillNoxDuo,
                BingoAction.KillErdtreeWatchdogDuoMinorErdtreeCatacombs,
                BingoAction.KillCrucibleMisbegottenDuo,
                BingoAction.KillPumpkinHeadDuo,
                BingoAction.KillBOFADuoDragonbarrowCave,
                BingoAction.KillCleanrotDuoAbandonedCave,
                BingoAction.KillPutridCrystalianTrio,
                BingoAction.KillDemiHumanChiefsDuo,
                BingoAction.KillCrystalianDuoAcademyCave,
                BingoAction.KillOmenMirandaPerfumersGrotto,
                BingoAction.KillAbductorVirginDuo,
                BingoAction.KillKindredOfRotDuoSeethwaterCave,
                BingoAction.KillCrystalianDuoAltusTunnel,
                BingoAction.KillTriciaMisbegottenDuoUnsightlyCatacombs,
                BingoAction.KillTreeSentinelDuo,
            }
        },
        new BingoGoalWithActions()
        {
            Goal = BingoGoal.KillCaelidBosses,
            Actions = new List<BingoAction>()
            {
                BingoAction.KillNoxDuo,
                BingoAction.KillErdtreeWatchdogDuoMinorErdtreeCatacombs,
                BingoAction.KillCrucibleMisbegottenDuo,
                BingoAction.KillPumpkinHeadDuo,
                BingoAction.KillBOFADuoDragonbarrowCave,
                BingoAction.KillGreyoll,
                BingoAction.KillFlyingDragonGreyll,
                BingoAction.KillCommanderONeil,
                BingoAction.KillFallingstarBeastCaelid,
                BingoAction.KillRadahn,
                BingoAction.KillMagmaWyrmCaelid,
                BingoAction.KillDeathRiteBirdCaelid,
                BingoAction.KillNightsCavSouthCaelid,
                BingoAction.KillNightsCavalryNorthCaelid,
                BingoAction.KillPutridAvatarWestCaelid,
                BingoAction.KillPutridAvatarNorthCaelid,
                BingoAction.KillBlackBladeKindredCaelid,
                BingoAction.KillFrenziedDuelistGaolCave,
                BingoAction.KillEkzykes,
                BingoAction.KillCaelidCatacombsCemetaryShade,
                BingoAction.KillPutridTreeSpiritWarDeadCatacombs,
                BingoAction.KillBattlemageHuguesEvergaol,
                BingoAction.KillBellBearingHunterCaelid,
                BingoAction.KillCleanrotDuoAbandonedCave,
                BingoAction.KillGodskinApostle,
                BingoAction.KillPutridCrystalianTrio,
            }
        },
        new BingoGoalWithActions()
        {
            Goal = BingoGoal.KillElemerOfTheBriar,
            Actions = new List<BingoAction>()
            {
                BingoAction.KillElemerOfTheBriar,
            }
        },
        new BingoGoalWithActions()
        {
            Goal = BingoGoal.KillRadahn,
            Actions = new List<BingoAction>()
            {
                BingoAction.KillRadahn
            }
        },
        new BingoGoalWithActions()
        {
            Goal = BingoGoal.KillMohgSewers,
            Actions = new List<BingoAction>()
            {
                BingoAction.KillMohgSewers,
            }
        },
        new BingoGoalWithActions()
        {
            Goal = BingoGoal.KillRememberanceBosses,
            Actions = new List<BingoAction>()
            {
                BingoAction.KillRadahn,
                BingoAction.KillGodrick,
                BingoAction.KillRennala,
                BingoAction.KillMorgot,
                BingoAction.KillRegalAncestor,
                BingoAction.KillRykard,
                BingoAction.KillAstel,
                BingoAction.KillFortisax,
                BingoAction.KillMohgLordOfBlood,
            }
        },
        new BingoGoalWithActions()
        {
            Goal = BingoGoal.KillWormFace,
            Actions = new List<BingoAction>()
            {
                BingoAction.KillWormface
            }
        },
        new BingoGoalWithActions()
        {
            Goal = BingoGoal.KillBlackBladeKindred,
            Actions = new List<BingoAction>()
            {
                BingoAction.KillBlackBladeKindredCaelid,
                BingoAction.KillBlackBladeKindredForbiddenLands
            }
        },
        new BingoGoalWithActions()
        {
            Goal = BingoGoal.KillErdtreeAvatars,
            Actions = new List<BingoAction>()
            {
                BingoAction.KillPutridAvatarNorthCaelid,
                BingoAction.KillPutridAvatarWestCaelid,
                BingoAction.KillErdtreeAvatarWeeping,
                BingoAction.KillErdtreeAvatarLiurniaSouth,
                BingoAction.KillErdtreeAvatarLiurniaNorth,
                BingoAction.KillErtreeAvatarLyndell,
                BingoAction.KillErtreeAvatarDeeproot,
            }
        },
        new BingoGoalWithActions()
        {
            Goal = BingoGoal.KillRoyalRevenantKingsrealm,
            Actions = new List<BingoAction>()
            {
                BingoAction.KillRoyalRevenantKingsrealm,
            }
        },
        new BingoGoalWithActions()
        {
            Goal = BingoGoal.KillMorgot,
            Actions = new List<BingoAction>()
            {
                BingoAction.KillMorgot,
            }
        },
        new BingoGoalWithActions()
        {
            Goal = BingoGoal.KillGodrick,
            Actions = new List<BingoAction>()
            {
                BingoAction.KillGodrick,
            }
        },
        new BingoGoalWithActions()
        {
            Goal = BingoGoal.KillDragonkinSoldier,
            Actions = new List<BingoAction>()
            {
                BingoAction.KillDragonkinSiofra,
                BingoAction.KillDragonkinSoldierOfNokstella,
                BingoAction.KillDragonkinLakeOfRot,
            }
        },
        new BingoGoalWithActions()
        {
            Goal = BingoGoal.CompleteCaveGrottoDungeons,
            Actions = new List<BingoAction>()
            {
                BingoAction.KillDemiHumanChiefsDuo,
                BingoAction.KillGuardianGolemHighRoadCave,
                BingoAction.KillBOFAGrovesideCave,
                BingoAction.KillPatchesMurkwaterCave,
                BingoAction.KillRunebearEarthboreCave,
                BingoAction.KillMirandaTombswardCave,
                BingoAction.KillCrystalianDuoAcademyCave,
                BingoAction.KillBloodhoundLakesideCrystalCave,
                BingoAction.KillCleanrotStillwaterCave,
                BingoAction.KillFrenziedDuelistGaolCave,
                BingoAction.KillCleanrotDuoAbandonedCave,
                BingoAction.KillBOFADuoDragonbarrowCave,
                BingoAction.KillOmenMirandaPerfumersGrotto,
                BingoAction.KillBlackKnifeSagesCave,
                BingoAction.KillGarrisSagesCave,
                BingoAction.KillKindredOfRotDuoSeethwaterCave,
                BingoAction.KillDemiHumanQueenMargotVolcanoCave,
            }
        },
        new BingoGoalWithActions()
        {
            Goal = BingoGoal.KillCommanderONeil,
            Actions = new List<BingoAction>()
            {
                BingoAction.KillCommanderONeil
            }
        },
        new BingoGoalWithActions()
        {
            Goal = BingoGoal.KillAltusVolcanoManorBosses,
            Actions = new List<BingoAction>()
            {
                BingoAction.KillDragonLansseax,
                BingoAction.KillAncientHeroOfZamorSaintedHerosGrave,
                BingoAction.KillBlackKnifeSaintedHerosGrave,
                BingoAction.KillBlackKnifeSagesCave,
                BingoAction.KillGarrisSagesCave,
                BingoAction.KillCrystalianDuoAltusTunnel,
                BingoAction.KillDemiHumanQueenGilika,
                BingoAction.KillElemerOfTheBriar,
                BingoAction.KillErdtreeWatchdogWyndham,
                BingoAction.KillFullGrownFallingstarBeast,
                BingoAction.KillFallingstarBeastAltusStairs,
                BingoAction.KillGodefroyTheGraftedEvergaol,
                BingoAction.KillCelebrantApostle,
                BingoAction.KillNightsCavalryAltus,
                BingoAction.KillOmenMirandaPerfumersGrotto,
                BingoAction.KillTriciaMisbegottenDuoUnsightlyCatacombs,
                BingoAction.KillSanguineNoble,
                BingoAction.KillStonediggerTrollLimgraveTunnel,
                BingoAction.KillTreeSentinelDuo,
                BingoAction.KillWormface,
                BingoAction.KillAbductorVirginDuo,
                BingoAction.KillDemiHumanQueenMaggieHermitVillage,
                BingoAction.KillDemiHumanQueenMargotVolcanoCave,
                BingoAction.KillGodskinNobleVolcanoManor,
                BingoAction.KillRykard,
                BingoAction.KillKindredOfRotDuoSeethwaterCave,
                BingoAction.KillMagmaWyrmGelmir,
                BingoAction.KillRedWolfGelmirHerosGrave,
                BingoAction.KillUlceratedTreeSpiritGelmir,
                BingoAction.KillBellBearingHunterCapitalOutskirts,
                BingoAction.KillCrucibleKnightDuo,
                BingoAction.KillDeathBirdCapitalOutskirts,
                BingoAction.KillFellTwns,
                BingoAction.KillGraveWardenDuelistAurizaSideTomb,
                BingoAction.KillOnyxLordSealedTunnel,
                BingoAction.KillTibiaMarinerAltus,
            }
        },
        new BingoGoalWithActions()
        {
            Goal = BingoGoal.KillBossesWithTreeInName,
            Actions = new List<BingoAction>()
            {
                BingoAction.KillTreeSentinelDuo,
                BingoAction.KillTreeSentianelLimgrave,
                BingoAction.KillDraconicTreeSentinel,
                BingoAction.KillErdteeWatchdogStormfootCatacombs,
                BingoAction.KillUlceratedTreeSpiritGelmir,
                BingoAction.KillUlceratedTreeSpititFringefolkHerosGrave,
                BingoAction.KillErdtreeAvatarWeeping,
                BingoAction.KillErdtreeAvatarLiurniaNorth,
                BingoAction.KillErdtreeAvatarLiurniaSouth,
                BingoAction.KillErdtreeWatchdogWyndham,
                BingoAction.KillErdtreeWatchdogDuoMinorErdtreeCatacombs,
                BingoAction.KillErdtreeWatchdogImpalersCatacombs,
                BingoAction.KillErdtreeWatchdogCliffbottomCatacombs,
                BingoAction.KillErdtreeWatchdogStormfootCatacombs,
                BingoAction.KillPutridTreeSpiritWarDeadCatacombs,
                BingoAction.KillLorettaKnightOfTheHaligtree,
            }
        },
        new BingoGoalWithActions()
        {
            Goal = BingoGoal.KillFriendlyNpcs,
            Actions = new List<BingoAction>()
            {
                BingoAction.KillVare,
                BingoAction.KillBoc,
                BingoAction.KillAlexander,
                BingoAction.KillKennithHaight,
                BingoAction.KillThops,
                BingoAction.Miriel,
                BingoAction.KillDHunterOfTheDead,
                BingoAction.KillCorhynAltus,
                BingoAction.KillGurranq,
                BingoAction.KillBernahl,
                BingoAction.KillYura,
                BingoAction.KillEdgar,
                BingoAction.KillIrina,
                BingoAction.KillDiallos,
                BingoAction.KillPatchesMurkwaterCave,
                BingoAction.KillNepheliLoux,
                BingoAction.KillHyetta,
                BingoAction.KillGostoc,
                BingoAction.KillGowry,
                BingoAction.KillLatenna,
                BingoAction.KillAlbus,
                BingoAction.KillBoggart,
            }
        },
        new BingoGoalWithActions()
        {
            Goal = BingoGoal.KillGreyoll,
            Actions = new List<BingoAction>()
            {
                BingoAction.KillGreyoll,
            }
        },
        new BingoGoalWithActions()
        {
            Goal = BingoGoal.KillAncestorSpirit,
            Actions = new List<BingoAction>()
            {
                BingoAction.KillRegalAncestor,
                BingoAction.KillAncestorSpirit,
            }
        },
        new BingoGoalWithActions()
        {
            Goal = BingoGoal.KillEdgarTheRevenger,
            Actions = new List<BingoAction>()
            {
                BingoAction.KillEdgar
            }
        },
        new BingoGoalWithActions()
        {
            Goal = BingoGoal.KillRedWolfOfRadagon,
            Actions = new List<BingoAction>()
            {
                BingoAction.KillRedWolfOfRadagon,
                BingoAction.KillRennala,
            }
        },
        new BingoGoalWithActions()
        {
            Goal = BingoGoal.KillGodskinNobleVolcanoManor,
            Actions = new List<BingoAction>()
            {
                BingoAction.KillGodskinNobleVolcanoManor,
                BingoAction.KillRykard,
            }
        },
        new BingoGoalWithActions()
        {
            Goal = BingoGoal.KillGoldfrey,
            Actions = new List<BingoAction>()
            {
                BingoAction.KillGoldfrey,
                BingoAction.KillMorgot
            }
        },
        new BingoGoalWithActions()
        {
            Goal = BingoGoal.KillLorettaSpirit,
            Actions = new List<BingoAction>()
            {
                BingoAction.KillLorettaSpirit,
            }
        },
        new BingoGoalWithActions()
        {
            Goal = BingoGoal.KillGraftedScionChapel,
            Actions = new List<BingoAction>()
            {
                BingoAction.KillGraftedScionChapel,
            }
        },
        new BingoGoalWithActions()
        {
            Goal = BingoGoal.KillSoldierOfGodrick,
            Actions = new List<BingoAction>()
            {
                BingoAction.KillSoldierOfGodrick,
            }
        },
        new BingoGoalWithActions()
        {
            Goal = BingoGoal.KillTreeSentinalLimgrave,
            Actions = new List<BingoAction>()
            {
                BingoAction.KillTreeSentianelLimgrave
            }
        },
        new BingoGoalWithActions()
        {
            Goal = BingoGoal.KillTreeSentinalDuo,
            Actions = new List<BingoAction>()
            {
                BingoAction.KillTreeSentinelDuo
            }
        },
        new BingoGoalWithActions()
        {
            Goal = BingoGoal.KillCrucibleKnightMisbegottenDuo,
            Actions = new List<BingoAction>()
            {
                BingoAction.KillCrucibleMisbegottenDuo
            }
        },
        new BingoGoalWithActions()
        {
            Goal = BingoGoal.KillMagaWyrmBoss,
            Actions = new List<BingoAction>()
            {
                BingoAction.KillMagmaWyrmCaelid,
                BingoAction.KillMagmaWyrmGelmir,
                BingoAction.KillMagmaWyrmVolcanoManor,
                BingoAction.KillMagmaWyrmMakar,
                BingoAction.KillGreatWyrmTheodorix,
            }
        },
        new BingoGoalWithActions()
        {
            Goal = BingoGoal.KillFallingstarBeast,
            Actions = new List<BingoAction>()
            {
                BingoAction.KillFallingstarBeastCaelid,
                BingoAction.KillFallingstarBeastAltusStairs,
                BingoAction.KillFullGrownFallingstarBeast
            }
        },
        new BingoGoalWithActions()
        {
            Goal = BingoGoal.KillCrucilbleKnights,
            Actions = new List<BingoAction>()
            {
                BingoAction.KillCrucibleMisbegottenDuo,
                BingoAction.KillCrucibleKnightDuo,
                BingoAction.KillCrucibleKnightErdtreeSanctuary,
                BingoAction.KillCrucibleKnightLyndellLift,
                BingoAction.KillCrucibleKnightStormveil,
                BingoAction.KillCrucibleKnightBelfries,
                BingoAction.KillCrucibleKnightStormhillEvergaol,
                BingoAction.KillSiluria,
                BingoAction.KillCrucibleKnightUpperSiofraSword,
                BingoAction.KillCrucibleKnightUpperSiofraSpear,
            }
        },
        new BingoGoalWithActions()
        {
            Goal = BingoGoal.KillNightsCavalry,
            Actions = new List<BingoAction>()
            {
                BingoAction.KillNightsCavalryLimgrave,
                BingoAction.KillNightsCavalryWeeping,
                BingoAction.KillNightsCavalryNorthCaelid,
                BingoAction.KillNightsCavSouthCaelid,
                BingoAction.KillNightsCavalryBellum,
                BingoAction.KillNightsCavalryLiurniaSouth,
                BingoAction.KillNightsCavalryAltus,
                BingoAction.KillNightsCavalryForbiddenLands,
                BingoAction.KillNightsCavalrySnowfield,
            }
        },
        new BingoGoalWithActions()
        {
            Goal = BingoGoal.KillBossesRidingHorses,
            Actions = new List<BingoAction>()
            {
                BingoAction.KillNightsCavalryLimgrave,
                BingoAction.KillNightsCavalryWeeping,
                BingoAction.KillNightsCavalryNorthCaelid,
                BingoAction.KillNightsCavSouthCaelid,
                BingoAction.KillNightsCavalryBellum,
                BingoAction.KillNightsCavalryLiurniaSouth,
                BingoAction.KillNightsCavalryAltus,
                BingoAction.KillNightsCavalryForbiddenLands,
                BingoAction.KillNightsCavalrySnowfield,
                BingoAction.KillDraconicTreeSentinel,
                BingoAction.KillTreeSentianelLimgrave,
                BingoAction.KillTreeSentinelDuo,
                BingoAction.KillLorettaSpirit,
                BingoAction.KillLorettaKnightOfTheHaligtree,
                BingoAction.KillRadahn,
            }
        },
        new BingoGoalWithActions()
        {
            Goal = BingoGoal.KillRememeranceBossClawDaggerFists,
            Actions = new List<BingoAction>()
            {
                BingoAction.KillRadahn,
                BingoAction.KillGodrick,
                BingoAction.KillRennala,
                BingoAction.KillMorgot,
                BingoAction.KillRegalAncestor,
                BingoAction.KillRykard,
                BingoAction.KillAstel,
                BingoAction.KillFortisax,
                BingoAction.KillMohgLordOfBlood,
            }
        },
        new BingoGoalWithActions()
        {
            Goal = BingoGoal.KillBossOnTorrent,
            Actions = new List<BingoAction>()
            {
                BingoAction.KillBellBearingHunterCaelid,
                BingoAction.KillBellBearingHunterCapitalOutskirts,
                BingoAction.KillBellBearingHunterWarmastersShack,
                BingoAction.KillBellBearingHunterChurchOfVows,
                BingoAction.KillDeathBirdLimgrave,
                BingoAction.KillFlyingDragonAgheel,
                BingoAction.KillNightsCavalryLimgrave,
                BingoAction.KillNightsCavalryWeeping,
                BingoAction.KillNightsCavalryNorthCaelid,
                BingoAction.KillNightsCavSouthCaelid,
                BingoAction.KillNightsCavalryBellum,
                BingoAction.KillNightsCavalryLiurniaSouth,
                BingoAction.KillNightsCavalryAltus,
                BingoAction.KillNightsCavalryForbiddenLands,
                BingoAction.KillNightsCavalrySnowfield,
                BingoAction.KillDraconicTreeSentinel,
                BingoAction.KillTreeSentianelLimgrave,
                BingoAction.KillTreeSentinelDuo,
                BingoAction.KillFallingstarBeastAltusStairs,
                BingoAction.KillFullGrownFallingstarBeast,
                BingoAction.KillMagmaWyrmGelmir,
                BingoAction.KillGreatWyrmTheodorix,
                BingoAction.KillTibiaMarinerLimgrave,
                BingoAction.KillDeathBirdWeeping,
                BingoAction.KillErdtreeAvatarWeeping,
                BingoAction.KillDeathRiteBirdGateTownLiurnia,
                BingoAction.DeathBirdSouthLiurnia,
                BingoAction.KillErdtreeAvatarLiurniaNorth,
                BingoAction.KillErdtreeAvatarLiurniaSouth,
                BingoAction.KillGlintstoneDragonAdula,
                BingoAction.KillGlintstoneDragonSmarag,
                BingoAction.KillOmenkillerAlbinauricVillage,
                BingoAction.KillRoyalRevenantKingsrealm,
                BingoAction.KillTibiaMarinerEastLiurnia,
                BingoAction.KillCommanderONeil,
                BingoAction.KillDeathRiteBirdCaelid,
                BingoAction.KillEkzykes,
                BingoAction.KillPutridAvatarNorthCaelid,
                BingoAction.KillPutridAvatarWestCaelid,
                BingoAction.KillPumpkinHeadDuo,
                BingoAction.KillRadahn,
                BingoAction.KillGreyoll,
                BingoAction.KillFlyingDragonGreyll,
                BingoAction.KillDragonLansseax,
                BingoAction.KillBlackKnifeSaintedHerosGrave,
                BingoAction.KillDemiHumanQueenGilika,
                BingoAction.KillTibiaMarinerAltus,
                BingoAction.KillSanguineNoble,
                BingoAction.KillWormface,
                BingoAction.KillDemiHumanQueenMaggieHermitVillage,
                BingoAction.KillMagmaWyrmGelmir,
                BingoAction.KillDeathBirdCapitalOutskirts,
                BingoAction.KillBlackBladeKindredForbiddenLands,
                BingoAction.KillGreatWyrmTheodorix,
                BingoAction.KillDeathRiteBirdSnowfield,
                BingoAction.KillPutridAvatarSnowfield,
                BingoAction.KillDragonkinSiofra,
                BingoAction.KillMadPumpkinHead,
            }
        },
        new BingoGoalWithActions()
        {
            Goal = BingoGoal.KillLimgraveBosses,
            Actions = new List<BingoAction>()
            {
                BingoAction.KillBOFAGrovesideCave,
                BingoAction.KillBellBearingHunterWarmastersShack,
                BingoAction.KillBlackKnifeDeathtouchedCatacombs,
                BingoAction.KillBloodhoundKnightDarriwil,
                BingoAction.KillCrucibleKnightStormhillEvergaol,
                BingoAction.KillDeathBirdLimgrave,
                BingoAction.KillDemiHumanChiefsDuo,
                BingoAction.KillErdtreeWatchdogStormfootCatacombs,
                BingoAction.KillFlyingDragonAgheel,
                BingoAction.KillGodrick,
                BingoAction.KillGraftedScionChapel,
                BingoAction.KillGraveWardenDuelistMurkwaterCatacombs,
                BingoAction.KillGuardianGolemHighRoadCave,
                BingoAction.KillMadPumpkinHead,
                BingoAction.KillMargitTheFellOmen,
                BingoAction.KillNightsCavalryLimgrave,
                BingoAction.KillPatchesMurkwaterCave,
                BingoAction.KillSoldierOfGodrick,
                BingoAction.KillStonediggerTrollLimgraveTunnel,
                BingoAction.KillTibiaMarinerLimgrave,
                BingoAction.KillAncientHeroOfZamorEvergaol,
                BingoAction.KillCemetaryShadeTombswardCatacombs,
                BingoAction.KillDeathBirdWeeping,
                BingoAction.KillErdtreeAvatarWeeping,
                BingoAction.KillErdtreeWatchdogImpalersCatacombs,
                BingoAction.KillLeonineMisbegotten,
                BingoAction.KillMirandaTombswardCave,
                BingoAction.KillNightsCavalryWeeping,
                BingoAction.KillRunebearEarthboreCave,
                BingoAction.KillScalyMisbegottenMorneTunnel,
            }
        },
        new BingoGoalWithActions()
        {
            Goal = BingoGoal.KillLiurniaBosses,
            Actions = new List<BingoAction>()
            {
                BingoAction.KillAdanEvergaol,
                BingoAction.KillAlabasterLordEvergaol,
                BingoAction.KillAlectoEvergaol,
                BingoAction.KillBloodhoundLakesideCrystalCave,
                BingoAction.KillBellBearingHunterChurchOfVows,
                BingoAction.KillBlackKnifeBlackKnifeCatacombs,
                BingoAction.KillBolsEvergaol,
                BingoAction.KillCemetaryShadeBlackKnifeCatacombs,
                BingoAction.KillCleanrotStillwaterCave,
                BingoAction.KillCrystalianRayaLucariaCrystalTunnel,
                BingoAction.KillCrystalianDuoAcademyCave,
                BingoAction.KillDeathRiteBirdGateTownLiurnia,
                BingoAction.KillDeathRiteBirdGateTownLiurnia,
                BingoAction.KillErdtreeAvatarLiurniaNorth,
                BingoAction.KillErdtreeAvatarLiurniaSouth,
                BingoAction.KillErdtreeWatchdogCliffbottomCatacombs,
                BingoAction.KillGlintstoneDragonAdula,
                BingoAction.KillGlintstoneDragonSmarag,
                BingoAction.KillMagmaWyrmMakar,
                BingoAction.KillNightsCavalryLiurniaSouth,
                BingoAction.KillNightsCavalryBellum,
                BingoAction.KillOmenkillerAlbinauricVillage,
                BingoAction.KillRedWolfOfRadagon,
                BingoAction.KillRennala,
                BingoAction.KillLorettaSpirit,
                BingoAction.KillRoyalRevenantKingsrealm,
                BingoAction.KillTibiaMarinerEastLiurnia,
                BingoAction.KillSpiritCallerSnailRoadsEndCatacombs,
            }
        },
        new BingoGoalWithActions()
        {
            Goal = BingoGoal.CompleteTunnelPrecipiceDungeons,
            Actions = new List<BingoAction>()
            {
                BingoAction.KillStonediggerTrollLimgraveTunnel,
                BingoAction.KillScalyMisbegottenMorneTunnel,
                BingoAction.KillCrystalianRayaLucariaCrystalTunnel,
                BingoAction.KillCrystalianDuoAltusTunnel,
                BingoAction.KillMagmaWyrmMakar,
                BingoAction.KillStonediggerTrollOldAltusTunnel,
                BingoAction.KillOnyxLordSealedTunnel,
                BingoAction.KillMagmaWyrmCaelid,
                BingoAction.KillFallingstarBeastCaelid,
                BingoAction.KillAstelStarsOfDarkness,
            }
        },
        new BingoGoalWithActions()
        {
            Goal = BingoGoal.CompleteEvergaols,
            Actions = new List<BingoAction>()
            {
                BingoAction.KillBloodhoundKnightDarriwil,
                BingoAction.KillAncientHeroOfZamorEvergaol,
                BingoAction.KillCrucibleKnightStormhillEvergaol,
                BingoAction.KillBattlemageHuguesEvergaol,
                BingoAction.KillAdanEvergaol,
                BingoAction.KillAlectoEvergaol,
                BingoAction.KillBolsEvergaol,
                BingoAction.KillAlabasterLordEvergaol,
                BingoAction.KillGodefroyTheGraftedEvergaol,
                BingoAction.KillVykeEvergaol,
            }
        },
        new BingoGoalWithActions()
        {
            Goal = BingoGoal.RestoreGreatRune,
            Actions = new List<BingoAction>()
            {
                BingoAction.KillGodrick,
                BingoAction.KillRykard,
                BingoAction.KillOnyxLordSealedTunnel,
                BingoAction.KillMorgot,
                BingoAction.KillFellTwns,
                BingoAction.KillRadahn,
                BingoAction.KillMohgLordOfBlood,
            }
        },
        new BingoGoalWithActions()
        {
            Goal = BingoGoal.DefeatMagnusTheBeastClaw,
            Actions = new List<BingoAction>()
            {
                BingoAction.KillMagnusTheBeastClaw,
            }
        },
        new BingoGoalWithActions()
        {
            Goal = BingoGoal.KillInvaders,
            Actions = new List<BingoAction>()
            {
                BingoAction.KillEnsha,
                BingoAction.KillNerijus,
                BingoAction.KillEdgarTheRevenger,
                BingoAction.KillMadTongueAlberich,
                BingoAction.KillRecusantHenricus,
                BingoAction.KillFingerprintVyke,
                BingoAction.KillAnastasiaSmoulderingChurch,
                BingoAction.KillAnastasiaGelmir,
                BingoAction.KillGreatJarWarriors,
                BingoAction.KillMillicent,
                BingoAction.KillInquisitorGhiza,
                BingoAction.KillTanithsKnight,
                BingoAction.KillMaleighMarais,
                BingoAction.KillNamelessWhiteMasks,
            }
        },
        new BingoGoalWithActions()
        {
            Goal = BingoGoal.KillGurranq,
            Actions = new List<BingoAction>()
            {
                BingoAction.KillGurranq,
            }
        },
        new BingoGoalWithActions()
        {
            Goal = BingoGoal.SomberUpgrade,
            Actions = new List<BingoAction>()
            {
                BingoAction.SomberUpgrade,
            }
        },
        new BingoGoalWithActions()
        {
            Goal = BingoGoal.SmithingUpgrade,
            Actions = new List<BingoAction>()
            {
                BingoAction.SmithingUpgrade,
            }
        },
        new BingoGoalWithActions()
        {
            Goal = BingoGoal.FlaskUpgrade,
            Actions = new List<BingoAction>()
            {
                BingoAction.FlaskUpgrade,
            }
        },
        new BingoGoalWithActions()
        {
            Goal = BingoGoal.FlaskCount,
            Actions = new List<BingoAction>()
            {
                BingoAction.FlaskCount,
            }
        },
        new BingoGoalWithActions()
        {
            Goal = BingoGoal.BossHitless,
            Actions = new List<BingoAction>()
            {
                BingoAction.KillAdanEvergaol,
                BingoAction.KillAlabasterLordEvergaol,
                BingoAction.KillAlectoEvergaol,
                BingoAction.KillBloodhoundLakesideCrystalCave,
                BingoAction.KillBellBearingHunterChurchOfVows,
                BingoAction.KillBlackKnifeBlackKnifeCatacombs,
                BingoAction.KillBolsEvergaol,
                BingoAction.KillCemetaryShadeBlackKnifeCatacombs,
                BingoAction.KillCleanrotStillwaterCave,
                BingoAction.KillCrystalianRayaLucariaCrystalTunnel,
                BingoAction.KillCrystalianDuoAcademyCave,
                BingoAction.KillDeathRiteBirdGateTownLiurnia,
                BingoAction.KillDeathRiteBirdGateTownLiurnia,
                BingoAction.KillErdtreeAvatarLiurniaNorth,
                BingoAction.KillErdtreeAvatarLiurniaSouth,
                BingoAction.KillErdtreeWatchdogCliffbottomCatacombs,
                BingoAction.KillGlintstoneDragonAdula,
                BingoAction.KillGlintstoneDragonSmarag,
                BingoAction.KillMagmaWyrmMakar,
                BingoAction.KillNightsCavalryLiurniaSouth,
                BingoAction.KillNightsCavalryBellum,
                BingoAction.KillOmenkillerAlbinauricVillage,
                BingoAction.KillRedWolfOfRadagon,
                BingoAction.KillRennala,
                BingoAction.KillLorettaSpirit,
                BingoAction.KillRoyalRevenantKingsrealm,
                BingoAction.KillTibiaMarinerEastLiurnia,
                BingoAction.KillSpiritCallerSnailRoadsEndCatacombs,
                BingoAction.KillNoxDuo,
                BingoAction.KillErdtreeWatchdogDuoMinorErdtreeCatacombs,
                BingoAction.KillCrucibleMisbegottenDuo,
                BingoAction.KillPumpkinHeadDuo,
                BingoAction.KillBOFADuoDragonbarrowCave,
                BingoAction.KillGreyoll,
                BingoAction.KillFlyingDragonGreyll,
                BingoAction.KillCommanderONeil,
                BingoAction.KillFallingstarBeastCaelid,
                BingoAction.KillRadahn,
                BingoAction.KillMagmaWyrmCaelid,
                BingoAction.KillDeathRiteBirdCaelid,
                BingoAction.KillNightsCavSouthCaelid,
                BingoAction.KillNightsCavalryNorthCaelid,
                BingoAction.KillPutridAvatarWestCaelid,
                BingoAction.KillPutridAvatarNorthCaelid,
                BingoAction.KillBlackBladeKindredCaelid,
                BingoAction.KillFrenziedDuelistGaolCave,
                BingoAction.KillEkzykes,
                BingoAction.KillCaelidCatacombsCemetaryShade,
                BingoAction.KillPutridTreeSpiritWarDeadCatacombs,
                BingoAction.KillBattlemageHuguesEvergaol,
                BingoAction.KillBellBearingHunterCaelid,
                BingoAction.KillCleanrotDuoAbandonedCave,
                BingoAction.KillGodskinApostle,
                BingoAction.KillPutridCrystalianTrio,
                BingoAction.KillAdanEvergaol,
                BingoAction.KillAlabasterLordEvergaol,
                BingoAction.KillAlectoEvergaol,
                BingoAction.KillBloodhoundLakesideCrystalCave,
                BingoAction.KillBellBearingHunterChurchOfVows,
                BingoAction.KillBlackKnifeBlackKnifeCatacombs,
                BingoAction.KillBolsEvergaol,
                BingoAction.KillCemetaryShadeBlackKnifeCatacombs,
                BingoAction.KillCleanrotStillwaterCave,
                BingoAction.KillCrystalianRayaLucariaCrystalTunnel,
                BingoAction.KillCrystalianDuoAcademyCave,
                BingoAction.KillDeathRiteBirdGateTownLiurnia,
                BingoAction.KillDeathRiteBirdGateTownLiurnia,
                BingoAction.KillErdtreeAvatarLiurniaNorth,
                BingoAction.KillErdtreeAvatarLiurniaSouth,
                BingoAction.KillErdtreeWatchdogCliffbottomCatacombs,
                BingoAction.KillGlintstoneDragonAdula,
                BingoAction.KillGlintstoneDragonSmarag,
                BingoAction.KillMagmaWyrmMakar,
                BingoAction.KillNightsCavalryLiurniaSouth,
                BingoAction.KillNightsCavalryBellum,
                BingoAction.KillOmenkillerAlbinauricVillage,
                BingoAction.KillRedWolfOfRadagon,
                BingoAction.KillRennala,
                BingoAction.KillLorettaSpirit,
                BingoAction.KillRoyalRevenantKingsrealm,
                BingoAction.KillTibiaMarinerEastLiurnia,
                BingoAction.KillSpiritCallerSnailRoadsEndCatacombs,
                BingoAction.KillDragonLansseax,
                BingoAction.KillAncientHeroOfZamorSaintedHerosGrave,
                BingoAction.KillBlackKnifeSaintedHerosGrave,
                BingoAction.KillBlackKnifeSagesCave,
                BingoAction.KillGarrisSagesCave,
                BingoAction.KillCrystalianDuoAltusTunnel,
                BingoAction.KillDemiHumanQueenGilika,
                BingoAction.KillElemerOfTheBriar,
                BingoAction.KillErdtreeWatchdogWyndham,
                BingoAction.KillFullGrownFallingstarBeast,
                BingoAction.KillFallingstarBeastAltusStairs,
                BingoAction.KillGodefroyTheGraftedEvergaol,
                BingoAction.KillCelebrantApostle,
                BingoAction.KillNightsCavalryAltus,
                BingoAction.KillOmenMirandaPerfumersGrotto,
                BingoAction.KillTriciaMisbegottenDuoUnsightlyCatacombs,
                BingoAction.KillSanguineNoble,
                BingoAction.KillStonediggerTrollLimgraveTunnel,
                BingoAction.KillTreeSentinelDuo,
                BingoAction.KillWormface,
                BingoAction.KillAbductorVirginDuo,
                BingoAction.KillDemiHumanQueenMaggieHermitVillage,
                BingoAction.KillDemiHumanQueenMargotVolcanoCave,
                BingoAction.KillGodskinNobleVolcanoManor,
                BingoAction.KillRykard,
                BingoAction.KillKindredOfRotDuoSeethwaterCave,
                BingoAction.KillMagmaWyrmGelmir,
                BingoAction.KillRedWolfGelmirHerosGrave,
                BingoAction.KillUlceratedTreeSpiritGelmir,
                BingoAction.KillBellBearingHunterCapitalOutskirts,
                BingoAction.KillCrucibleKnightDuo,
                BingoAction.KillDeathBirdCapitalOutskirts,
                BingoAction.KillFellTwns,
                BingoAction.KillGraveWardenDuelistAurizaSideTomb,
                BingoAction.KillOnyxLordSealedTunnel,
                BingoAction.KillTibiaMarinerAltus,
                BingoAction.KillAncestorSpirit,
                BingoAction.KillValiantGargoyles,
                BingoAction.KillDragonkinSiofra,
                BingoAction.KillDragonkinLakeOfRot,
                BingoAction.KillDragonkinSoldierOfNokstella,
                BingoAction.KillAstel,
            }
        },
        new BingoGoalWithActions()
        {
            Goal = BingoGoal.RuneLevel60,
            Actions = new List<BingoAction>()
            {
                BingoAction.RuneLevel60,
            }
        }
    };
    
    private static List<SharedGoalActions> FindSynergies(List<BingoGoalWithActions> goalsWithActions, IReadOnlySet<BingoGoal> filter = null)
    {
        Dictionary<BingoAction, HashSet<BingoGoal>> actionGoalPairs = new();

        foreach (var goalWithAction in goalsWithActions)
        {
            if(filter != null && !filter.Contains(goalWithAction.Goal)) continue;
            
            foreach (var action in goalWithAction.Actions)
            {
                if (!actionGoalPairs.ContainsKey(action))
                {
                    actionGoalPairs.Add(action, new HashSet<BingoGoal>());
                }

                actionGoalPairs[action].Add(goalWithAction.Goal);
            }
        }

        var ret = actionGoalPairs.Select(actionGoalPair =>
                new SharedGoalActions()
                {
                    Action = actionGoalPair.Key, 
                    Goals = actionGoalPair.Value.ToList(),
                })
            .OrderByDescending(x => x.Goals.Count).ToList();
        return ret;
    }

    public static List<RatedLineStr> GetLineRatingsStr(string[,] board, Dictionary<string, List<string>> data)
    {
        if (board.GetLength(0) != board.GetLength(1))
        {
            throw new Exception("Board dims must be equal");
        }

        if (board.GetLength(0) % 2 == 0)
        {
            throw new Exception("Board must have odd dimensions");
        }
        
        var rows = new List<List<string>>(); // bingo goals
        var columns = new List<List<string>>();

        var dim = board.GetLength(0);

        for (var i = 0; i <dim; i++)
        {
            var row = new List<string>();
            for (var j = 0; j < dim; j++)
            {
                row.Add(board[j,i]);
            }
            rows.Add(row);
        }
        
        for (var i = 0; i < dim; i++)
        {
            var column = new List<string>();
            for (var j = 0; j < dim; j++)
            {
                column.Add(board[i,j]);
            }
            columns.Add(column);
        }

        var diagonalTlBr = new List<string>();
        var diagonalTrBl = new List<string>();
        for (var i = 0; i < dim; i++)
        {
            diagonalTlBr.Add(board[i,i]);
        }
        
        for (var i = 0; i < dim; i++)
        {
            diagonalTrBl.Add(board[i,dim-1-i]);
        }

        var aggregate = new List<List<string>>();
        aggregate.AddRange(rows);
        aggregate.AddRange(columns);
        aggregate.Add(diagonalTlBr);
        aggregate.Add(diagonalTrBl);
        
        var ratings = new float[dim * 2 + 2];
        var synergies = new List<string>[dim * 2 + 2];
        

        for (var line = 0; line < aggregate.Count; line++)
        {
            var lineRating = 0f;
            synergies[line] = new List<string>(); // bingo actions

            for (var goalIndex = 0; goalIndex < aggregate[line].Count; goalIndex++)
            {
                var goal = aggregate[line][goalIndex];
                var goalRating = 0f;
                var actions = data[goal];

                // Start at self +1 to avoid double counting
                for (var innerGoalIndex = goalIndex + 1; innerGoalIndex < aggregate[line].Count; innerGoalIndex++)
                {
                    var innerGoal = aggregate[line][innerGoalIndex];
                    if (innerGoal == goal) continue;

                    var intersection = actions.Intersect(data[innerGoal]).ToArray();

                    if (intersection.Length > 0)
                    {
                        //if (!Weights.TryGetValue(innerGoal, out var weight))
                        //{
                        //   weight = 1;
                        //}
                        //goalRating += 1f * weight;
                        goalRating += 1f;
                    }

                    synergies[line].AddRange(intersection);
                }

                lineRating += goalRating;
            }
            
            ratings[line] = lineRating;
        }

        var ret = new List<RatedLineStr>();
        for (var i = 0; i < ratings.Length; i++)
        {
            var rating = ratings[i];
            ret.Add(new RatedLineStr()
            {
                Line = aggregate[i],
                Rating = rating,
                Synergies = synergies[i],
            });
        }

        var sorted = ret.OrderByDescending(x => x.Rating);
        return sorted.ToList();
    }
    
    public static List<RatedLine> GetLineRatings(BingoGoal[,] board, List<BingoGoalWithActions> data)
    {
        if (board.GetLength(0) != board.GetLength(1))
        {
            throw new Exception("Board dims must be equal");
        }

        if (board.GetLength(0) % 2 == 0)
        {
            throw new Exception("Board must have odd dimensions");
        }
        
        var rows = new List<List<BingoGoal>>();
        var columns = new List<List<BingoGoal>>();

        var dim = board.GetLength(0);

        for (var i = 0; i <dim; i++)
        {
            var row = new List<BingoGoal>();
            for (var j = 0; j < dim; j++)
            {
                row.Add(board[j,i]);
            }
            rows.Add(row);
        }
        
        for (var i = 0; i < dim; i++)
        {
            var column = new List<BingoGoal>();
            for (var j = 0; j < dim; j++)
            {
                column.Add(board[i,j]);
            }
            columns.Add(column);
        }

        var diagonalTlBr = new List<BingoGoal>();
        var diagonalTrBl = new List<BingoGoal>();
        for (var i = 0; i < dim; i++)
        {
            diagonalTlBr.Add(board[i,i]);
        }
        
        for (var i = 0; i < dim; i++)
        {
            diagonalTrBl.Add(board[i,dim-1-i]);
        }

        var aggregate = new List<List<BingoGoal>>();
        aggregate.AddRange(rows);
        aggregate.AddRange(columns);
        aggregate.Add(diagonalTlBr);
        aggregate.Add(diagonalTrBl);
        
        var ratings = new float[dim * 2 + 2];
        var synergies = new List<BingoAction>[dim * 2 + 2];

        var goalActionDict = data.ToDictionary(x => x.Goal, x => x.Actions);

        for (var line = 0; line < aggregate.Count; line++)
        {
            var lineRating = 0f;
            synergies[line] = new List<BingoAction>();

            for (var goalIndex = 0; goalIndex < aggregate[line].Count; goalIndex++)
            {
                var goal = aggregate[line][goalIndex];
                var goalRating = 0f;
                var actions = goalActionDict[goal];

                // Start at self +1 to avoid double counting
                for (var innerGoalIndex = goalIndex + 1; innerGoalIndex < aggregate[line].Count; innerGoalIndex++)
                {
                    var innerGoal = aggregate[line][innerGoalIndex];
                    if (innerGoal == goal) continue;

                    var intersection = actions.Intersect(goalActionDict[innerGoal]).ToArray();

                    if (intersection.Length > 0)
                    {
                        //if (!Weights.TryGetValue(innerGoal, out var weight))
                        //{
                        //   weight = 1;
                        //}
                        //goalRating += 1f * weight;
                        goalRating += 1f;
                    }

                    synergies[line].AddRange(intersection);
                }

                lineRating += goalRating;
            }

            ratings[line] = lineRating;
        }

        var ret = new List<RatedLine>();
        for (var i = 0; i < ratings.Length; i++)
        {
            var rating = ratings[i];
            ret.Add(new RatedLine()
            {
                Line = aggregate[i],
                Rating = rating,
                Synergies = synergies[i],
            });
        }

        var sorted = ret.OrderByDescending(x => x.Rating);
        return sorted.ToList();
    }

    public static readonly Dictionary<BingoGoal, float> Weights = new()
    {
        {
            BingoGoal.BossHitless,
            0.1f
        },
        {
            BingoGoal.KillRememeranceBossClawDaggerFists,
            0.3f
        },
        {
            BingoGoal.KillBossOnTorrent,
            0.2f
        }
    };
}

public class RatedLineStr
{
    public List<string> Line;
    public List<string> Synergies;
    public float Rating;
}

public class RatedLine
{
    public List<BingoGoal> Line;
    public List<BingoAction> Synergies;
    public float Rating;
}

public class SharedGoalActions
{
    public BingoAction Action;
    public List<BingoGoal> Goals;
}

public class BingoGoalWithActions
{
    public BingoGoal Goal { get; set; }
    public List<BingoAction> Actions { get; set; }
}

public enum BingoGoal
{
    None,
    KillDuoBosses,
    KillCaelidBosses,
    KillErdtreeAvatars,
    KillGreyoll,
    KillElemerOfTheBriar,
    KillRadahn,
    KillMohgSewers,
    KillRememberanceBosses,
    KillWormFace,
    KillBlackBladeKindred,
    KillRoyalRevenantKingsrealm,
    KillMorgot,
    KillGodrick,
    KillDragonkinSoldier,
    CompleteCaveGrottoDungeons,
    KillCommanderONeil,
    KillAltusVolcanoManorBosses,
    KillBossesWithTreeInName,
    KillFriendlyNpcs,
    KillAncestorSpirit,
    KillEdgarTheRevenger,
    KillRedWolfOfRadagon,
    KillGodskinNobleVolcanoManor,
    KillGoldfrey,
    KillLorettaSpirit,
    KillGraftedScionChapel,
    KillSoldierOfGodrick,
    KillTreeSentinalLimgrave,
    KillTreeSentinalDuo,
    KillCrucibleKnightMisbegottenDuo,
    KillMagaWyrmBoss,
    KillFallingstarBeast,
    KillCrucilbleKnights,
    KillNightsCavalry,
    KillBossesRidingHorses,
    KillRememeranceBossClawDaggerFists,
    KillBossOnTorrent,
    KillLimgraveBosses,
    KillLiurniaBosses,
    CompleteTunnelPrecipiceDungeons,
    CompleteEvergaols,
    RestoreGreatRune,
    DefeatMagnusTheBeastClaw,
    KillInvaders,
    KillGurranq,
    SomberUpgrade,
    SmithingUpgrade,
    FlaskUpgrade,
    FlaskCount,
    BossHitless,
    RuneLevel60
}

public enum BingoAction
{
    KillCrucibleMisbegottenDuo,
    KillNoxDuo,
    KillPumpkinHeadDuo,
    KillBOFADuoDragonbarrowCave,
    KillErdtreeWatchdogDuoMinorErdtreeCatacombs,
    KillDemiHumanChiefsDuo,
    KillGreyoll,
    KillCommanderONeil,
    KillFallingstarBeastCaelid,
    KillRadahn,
    KillMagmaWyrmCaelid,
    KillDeathRiteBirdCaelid,
    KillNightsCavSouthCaelid,
    KillNightsCavalryNorthCaelid,
    KillPutridAvatarWestCaelid,
    KillPutridAvatarNorthCaelid,
    KillBlackBladeKindredCaelid,
    KillFrenziedDuelistGaolCave,
    KillEkzykes,
    KillCaelidCatacombsCemetaryShade,
    KillPutridTreeSpiritWarDeadCatacombs,
    KillBattlemageHuguesEvergaol,
    KillBellBearingHunterCaelid,
    KillCleanrotDuoAbandonedCave,
    KillGodskinApostle,
    KillPutridCrystalianTrio,
    KillElemerOfTheBriar,
    KillMohgSewers,
    KillGodrick,
    KillRennala,
    KillMorgot,
    KillRegalAncestor,
    KillRykard,
    KillAstel,
    KillFortisax,
    KillMohgLordOfBlood,
    KillWormface,
    KillBlackBladeKindredForbiddenLands,
    KillErdtreeAvatarWeeping,
    KillErdtreeAvatarLiurniaSouth,
    KillErdtreeAvatarLiurniaNorth,
    KillErtreeAvatarLyndell,
    KillErtreeAvatarDeeproot,
    KillRoyalRevenantKingsrealm,
    KillDragonkinSiofra,
    KillDragonkinSoldierOfNokstella,
    KillDragonkinLakeOfRot,
    KillGuardianGolemHighRoadCave,
    KillBOFAGrovesideCave,
    KillPatchesMurkwaterCave,
    KillRunebearEarthboreCave,
    KillMirandaTombswardCave,
    KillCrystalianDuoAcademyCave,
    KillBloodhoundLakesideCrystalCave,
    KillCleanrotStillwaterCave,
    KillOmenMirandaPerfumersGrotto,
    KillBlackKnifeSagesCave,
    KillKindredOfRotDuoSeethwaterCave,
    KillDemiHumanQueenMargotVolcanoCave,
    KillAbductorVirginDuo,
    KillGarrisSagesCave,
    KillDragonLansseax,
    KillAncientHeroOfZamorSaintedHerosGrave,
    KillBlackKnifeSaintedHerosGrave,
    KillCrystalianDuoAltusTunnel,
    KillDemiHumanQueenGilika,
    KillErdtreeWatchdogWyndham,
    KillFullGrownFallingstarBeast,
    KillFallingstarBeastAltusStairs,
    KillGodefroyTheGraftedEvergaol,
    KillCelebrantApostle,
    KillNightsCavalryAltus,
    KillTriciaMisbegottenDuoUnsightlyCatacombs,
    KillSanguineNoble,
    KillStonediggerTrollLimgraveTunnel,
    KillTreeSentinelDuo,
    KillDemiHumanQueenMaggieHermitVillage,
    KillMagmaWyrmGelmir,
    KillRedWolfGelmirHerosGrave,
    KillUlceratedTreeSpiritGelmir,
    KillBellBearingHunterCapitalOutskirts,
    KillCrucibleKnightDuo,
    KillDeathBirdCapitalOutskirts,
    KillFellTwns,
    KillGraveWardenDuelistAurizaSideTomb,
    KillOnyxLordSealedTunnel,
    KillGodskinNobleVolcanoManor,
    KillErdtreeWatchdogImpalersCatacombs,
    KillErdtreeWatchdogCliffbottomCatacombs,
    KillErdtreeWatchdogStormfootCatacombs,
    KillTreeSentianelLimgrave,
    KillDraconicTreeSentinel,
    KillErdteeWatchdogStormfootCatacombs,
    KillUlceratedTreeSpititFringefolkHerosGrave,
    KillLorettaKnightOfTheHaligtree,
    KillVare,
    KillBoc,
    KillAlexander,
    KillKennithHaight,
    KillThops,
    Miriel,
    KillDHunterOfTheDead,
    KillCorhynAltus,
    KillGurranq,
    KillBernahl,
    KillYura,
    KillEdgar,
    KillIrina,
    KillDiallos,
    KillNepheliLoux,
    KillHyetta,
    KillGostoc,
    KillGowry,
    KillLatenna,
    KillAlbus,
    KillBoggart,
    KillAncestorSpirit,
    KillRedWolfOfRadagon,
    KillGoldfrey,
    KillLorettaSpirit,
    KillGraftedScionChapel,
    KillSoldierOfGodrick,
    KillMagmaWyrmVolcanoManor,
    KillMagmaWyrmMakar,
    KillGreatWyrmTheodorix,
    KillCrucibleKnightErdtreeSanctuary,
    KillCrucibleKnightLyndellLift,
    KillCrucibleKnightStormveil,
    KillCrucibleKnightBelfries,
    KillCrucibleKnightStormhillEvergaol,
    KillSiluria,
    KillCrucibleKnightUpperSiofraSword,
    KillCrucibleKnightUpperSiofraSpear,
    KillNightsCavalryLimgrave,
    KillNightsCavalryWeeping,
    KillNightsCavalryBellum,
    KillNightsCavalryLiurniaSouth,
    KillNightsCavalryForbiddenLands,
    KillNightsCavalrySnowfield,
    KillBellBearingHunterWarmastersShack,
    KillBellBearingHunterChurchOfVows,
    KillDeathBirdLimgrave,
    KillFlyingDragonAgheel,
    KillTibiaMarinerLimgrave,
    KillDeathBirdWeeping,
    DeathBirdSouthLiurnia,
    KillDeathRiteBirdGateTownLiurnia,
    KillGlintstoneDragonAdula,
    KillGlintstoneDragonSmarag,
    KillOmenkillerAlbinauricVillage,
    KillTibiaMarinerEastLiurnia,
    KillFlyingDragonGreyll,
    KillTibiaMarinerAltus,
    KillDeathRiteBirdSnowfield,
    KillPutridAvatarSnowfield,
    KillMadPumpkinHead,
    KillBlackKnifeDeathtouchedCatacombs,
    KillBloodhoundKnightDarriwil,
    KillGraveWardenDuelistMurkwaterCatacombs,
    KillMargitTheFellOmen,
    KillAncientHeroOfZamorEvergaol,
    KillCemetaryShadeTombswardCatacombs,
    KillLeonineMisbegotten,
    KillScalyMisbegottenMorneTunnel,
    KillAdanEvergaol,
    KillAlabasterLordEvergaol,
    KillAlectoEvergaol,
    KillBlackKnifeBlackKnifeCatacombs,
    KillBolsEvergaol,
    KillCemetaryShadeBlackKnifeCatacombs,
    KillCrystalianRayaLucariaCrystalTunnel,
    KillSpiritCallerSnailRoadsEndCatacombs,
    KillStonediggerTrollOldAltusTunnel,
    KillAstelStarsOfDarkness,
    KillVykeEvergaol,
    KillMagnusTheBeastClaw,
    KillEnsha,
    KillNerijus,
    KillEdgarTheRevenger,
    KillMadTongueAlberich,
    KillRecusantHenricus,
    KillFingerprintVyke,
    KillAnastasiaSmoulderingChurch,
    KillAnastasiaGelmir,
    KillGreatJarWarriors,
    KillMillicent,
    KillInquisitorGhiza,
    KillTanithsKnight,
    KillMaleighMarais,
    KillNamelessWhiteMasks,
    SomberUpgrade,
    SmithingUpgrade,
    FlaskUpgrade,
    FlaskCount,
    KillValiantGargoyles,
    RuneLevel60
}