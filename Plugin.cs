using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using DiskCardGame;


namespace ExtraEncounters
{
	[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
	[BepInDependency(APIGUID, BepInDependency.DependencyFlags.HardDependency)]

	public partial class Plugin : BaseUnityPlugin
	{
		public const string APIGUID = "cyantist.inscryption.api";
		public const string PluginGuid = "extraVoid.inscryption.ExtraEncounters";
		private const string PluginName = "Extra Encounters";
		private const string PluginVersion = "1.0.0";

		public static string Directory;
		internal static ManualLogSource Log;



		private void Awake()
		{
			Log = base.Logger;
			Directory = this.Info.Location.Replace("Encounters.dll", "");



			//Abilities
		}

		[HarmonyPatch(typeof(LoadingScreenManager), "LoadGameData")]
		public class LoadingScreenManager_LoadGameData
		{
			[HarmonyPostfix]
			public static void Postfix()
			{
				//Encounters
				Encounters.ApeEscape.AddEncounter();
				Encounters.EriAnt.AddEncounter();
				Encounters.EriBird.AddEncounter();
				Encounters.EriHooved.AddEncounter();
				Encounters.EriWolf.AddEncounter();
				Encounters.UndeadMarch.AddEncounter();
			}
		}
	}
}