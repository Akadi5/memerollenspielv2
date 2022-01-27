﻿using GTANetworkAPI;
using GVRP.Module.ClientUI.Components;
using GVRP.Module.Players.Db;
using GVRP.Module.Players.Windows;
using System.Threading.Tasks;

namespace GVRP.Module.Items.Scripts
{
    public static partial class ItemScript
    {
        public static async Task<bool> VehicleNote(DbPlayer iPlayer, Item ItemData)
        {
            if (!iPlayer.Player.IsInVehicle) return false;
            await Task.Delay(1);
            NAPI.Task.Run(() => ComponentManager.Get<TextInputBoxWindow>().Show()(
                iPlayer, new TextInputBoxWindowObject() { Title = "Notiz", Callback = "SetVehicleNote", Message = "Gib eine Notiz ein (15 Zeichen) Nur Buchstaben und Zahlen" }));
            return true;
        }
    }
}