using HarmonyLib;
using SDG.Unturned;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoCarExplosion
{
    [HarmonyPatch(typeof(InteractableVehicle), "tellExploded")]
    public class Class3
    {
        [HarmonyPrefix]
        public static bool Prefix(InteractableVehicle __instance)
        {
            return false;
        }
    }
}
