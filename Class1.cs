using Rocket.Core.Plugins;
using Rocket.Unturned.Player;
using Rocket.Unturned;
using SDG.Unturned;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Steamworks;
using static Rocket.Unturned.Events.UnturnedPlayerEvents;
using Rocket.Unturned.Events;
using Rocket.Unturned.Chat;
using HarmonyLib;
using Rocket.API;

namespace NoCarExplosion
{
    public class Class1 : RocketPlugin
    {
        public static Class1 Instance;

        // Information for other people who stll don't know what's Harmony 

        /* Harmony patch edits the game code, but its main purpose is to ensure consistency and 
         * compatibility between various modifications (mods) that also modify the game code */

        protected override void Load()
        {
            Harmony harmony = new Harmony("com.example.NoCarExplosionPlugin");
            harmony.PatchAll();
        }

        protected override void Unload()
        {
        }
    }
}
