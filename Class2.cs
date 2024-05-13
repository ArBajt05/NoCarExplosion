using HarmonyLib;
using SDG.Unturned;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace NoCarExplosion
{
    [HarmonyPatch(typeof(InteractableVehicle), "explode")]
    public class Class2
    {
        [HarmonyPrefix]
        public static bool Prefix(InteractableVehicle __instance)
        {
            return false;
        }
    }
}
