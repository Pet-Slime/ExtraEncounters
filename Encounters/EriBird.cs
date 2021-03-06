using System.Collections.Generic;
using DiskCardGame;
using APIPlugin;

namespace ExtraEncounters.Encounters
{
    internal class EriBird
    {
		public static void AddEncounter()
		{
            //Name of the encounter
            string name = "EriBird";

            //Vanilla region names are: Forest, Wetlands, and Alpine
            string regionName = "Alpine";

            //What is the most common tribe?
            List<Tribe> dominate = new List<Tribe>();
            dominate.Add(Tribe.Bird);

            //Are any abilities redundent? Thus shouldnt be used on a totem
            List<Ability> redundant = new List<Ability>();
            redundant.Add(Ability.Flying);

            //Is this encounter locked to a region?
            bool regionLocked = true;

            //Add random Replacements
            List<CardInfo> randomReplacements = EncounterUtil.AddRandomCards("Kingfisher", "Sparrow", "Raven", "Vulture");

            List<EncounterBlueprintData.TurnModBlueprint> difficultyMod = new List<EncounterBlueprintData.TurnModBlueprint>();

            //Encounter by turns
            List<List<EncounterBlueprintData.CardBlueprint>> turns = new List<List<EncounterBlueprintData.CardBlueprint>>();

            List<EncounterBlueprintData.CardBlueprint> turn_1 = new List<EncounterBlueprintData.CardBlueprint>();
            turn_1.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("eri_Mockingbird"),
                difficultyReplace = CardLoader.GetCardByName("eri_Secretary"),
                difficultyReq = 18,
                randomReplaceChance = 25
            });
            turn_1.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("eri_Mockingbird"),
                difficultyReplace = CardLoader.GetCardByName("eri_FatBird"),
                difficultyReq = 13,
                randomReplaceChance = 25
            });

            List<EncounterBlueprintData.CardBlueprint> turn_2 = new List<EncounterBlueprintData.CardBlueprint>();

            List<EncounterBlueprintData.CardBlueprint> turn_3 = new List<EncounterBlueprintData.CardBlueprint>();
            turn_3.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("eri_Mockingbird"),
                difficultyReplace = CardLoader.GetCardByName("eri_Vulture"),
                difficultyReq = 13,
                randomReplaceChance = 25
            });

            List<EncounterBlueprintData.CardBlueprint> turn_4 = new List<EncounterBlueprintData.CardBlueprint>();
            turn_4.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("eri_Mockingbird")
            }); 
            turn_4.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("eri_Mockingbird"),
                difficultyReplace = CardLoader.GetCardByName("eri_Secretary"),
                difficultyReq = 18,
                randomReplaceChance = 25
            });

            List<EncounterBlueprintData.CardBlueprint> turn_5 = new List<EncounterBlueprintData.CardBlueprint>();
            turn_5.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("eri_Mockingbird"),
                difficultyReplace = CardLoader.GetCardByName("eri_Vulture"),
                difficultyReq = 13,
                randomReplaceChance = 25
            });
            List<EncounterBlueprintData.CardBlueprint> turn_6 = new List<EncounterBlueprintData.CardBlueprint>();
            turn_6.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("eri_Mockingbird"),
                difficultyReplace = CardLoader.GetCardByName("eri_Secretary"),
                difficultyReq = 18,
                randomReplaceChance = 25
            }); 
            turn_6.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("eri_Mockingbird"),
                difficultyReplace = CardLoader.GetCardByName("eri_FatBird"),
                difficultyReq = 13,
                randomReplaceChance = 25
            });

            turns.Add(turn_1);
            turns.Add(turn_2);
            turns.Add(turn_3);
            turns.Add(turn_4);
            turns.Add(turn_5);
            turns.Add(turn_6);

            NewEncounter.Add(
                       name,
                       regionName,
                       difficultyMod,
                       dominate,
                       redundant,
                       unlockedCardPrerequisites: null,
                       regionLocked,
                       minDifficulty: 1,
                       maxDifficulty: 30,
                       randomReplacements,
                       turns,
                       regular: true,
                       bossPrep: false,
                       oldPreviewDifficulty: 0);
        }

        
	}
}
