﻿using GVRP.Module.Clothes;
using System;

namespace GVRP.Module.Outfits
{
    public class OutfitComponentModule : SqlModule<OutfitComponentModule, OutfitComponent, uint>
    {
        public override Type[] RequiredModules()
        {
            return new[] { typeof(ClothModule) };
        }

        protected override string GetQuery()
        {
            return "SELECT * FROM `outfits_components`;";
        }

    }
}
