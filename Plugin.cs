using System;
using System.Reflection;
using BepInEx;
using HarmonyLib;

namespace LightgunDragoon
{
    [BepInPlugin(pluginGuid, pluginName, pluginVersion)]
    public class Plugin : BaseUnityPlugin
    {
        public const String pluginGuid = "1635ef5b-221a-468a-a155-856c3050d53a";
        public const String pluginName = "LightgunDragoon";
        public const String pluginVersion = "1.0.0.0";

        public void Awake()
        {
            Logger.LogMessage("Plugin loaded");
            Harmony harmony = new Harmony(pluginGuid);
            harmony.PatchAll();
        }
        
        private void HarmonyPatch(Harmony hHarmony, Type OriginalClass, String OriginalMethod, Type ReplacementClass, String ReplacementMethod)
        {
            MethodInfo original = AccessTools.Method(OriginalClass, OriginalMethod);
            MethodInfo patch = AccessTools.Method(ReplacementClass, ReplacementMethod);
            hHarmony.Patch(original, new HarmonyMethod(patch));
        }
    }
}
