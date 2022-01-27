﻿using GVRP.Module.Clothes.Props;
using MySql.Data.MySqlClient;

namespace GVRP.Module.Outfits
{
    public class OutfitProp : Loadable<uint>
    {
        public uint Id { get; }
        public int OutfitId { get; }
        public int Slot { get; }
        public int Component { get; }
        public int Texture { get; }

        public OutfitProp(MySqlDataReader reader) : base(reader)
        {
            Id = reader.GetUInt32("id");
            OutfitId = reader.GetInt32("outfit_id");
            Slot = reader.GetInt32("slot");
            Component = reader.GetInt32("component");
            Texture = reader.GetInt32("texture");

            // Fake Add...
            PropModule.Instance.Add(OutfitsModule.Instance.GetPropValue(Id, true), new Prop(OutfitsModule.Instance.GetPropValue(Id, true), "Generated", Slot, Component, Texture, 0, 0, 2, 0, false));
        }

        public override uint GetIdentifier()
        {
            return Id;
        }
    }
}
