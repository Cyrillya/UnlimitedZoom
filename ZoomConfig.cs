using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;
using Terraria.ModLoader.Config.UI;
using Terraria.UI;

namespace UnlimitedZoom
{
    // This file contains 2 real ModConfigs (and also a bunch of fake ModConfigs showcasing various ideas). One is set to ConfigScope.ServerSide and the other ConfigScope.ClientSide
    // ModConfigs contain Public Fields and Properties that represent the choices available to the user. 
    // Those Fields or Properties will be presented to users in the Config menu.
    // DONT use static members anywhere in this class (except for a variable named Instance, see below), tModLoader maintains several instances of ModConfig classes which will not work well with static properties or fields.

    /// <summary>
    /// This config operates on a per-client basis. 
    /// These parameters are local to this computer and are NOT synced from the server.
    /// </summary>
    [Label("Zoom Settings")]
    public class UnlimitedZoomConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ClientSide;

        public static UnlimitedZoomConfig Instance;
        [Range(0, 1000000)]
        [Label("缩放比(为0即不开启此模式)")]
        public int SuperZoom;
    }
}