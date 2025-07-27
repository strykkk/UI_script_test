using Rocket.Core.Logging;
using Rocket.Core.Plugins;
using Rocket.Unturned;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Effects;
using Rocket.Unturned.Events;
using Rocket.Unturned.Player;
using SDG.NetTransport;
using SDG.Unturned;
using Steamworks;
using System;
using static Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics;
using static UnityEngine.PlayerLoop.PreUpdate;

namespace bread_stryk.UI_script_test
{
    public class UI_script_testPlugin : RocketPlugin<UI_script_testConfiguration>
{
    protected override void Load()
    {
        Logger.Log("Hello, Unturned!");

        Logger.Log($"{Name} {Assembly.GetName().Version.ToString(3)} has been loaded!");

        U.Events.OnPlayerConnected += OnPlayerConnected;
        UnturnedPlayerEvents.OnPlayerUpdateHealth += OnPlayerUpdateHealth;
        UnturnedPlayerEvents.OnPlayerUpdateFood += OnPlayerUpdateFood;
        UnturnedPlayerEvents.OnPlayerUpdateWater += OnPlayerUpdateWater;
        UnturnedPlayerEvents.OnPlayerUpdateStamina += OnPlayerUpdatestamina;
        UnturnedPlayerEvents.OnPlayerUpdateVirus += OnPlayerUpdateVirus;
        UnturnedPlayerEvents.OnPlayerUpdateBroken += OnPlayerUpdateBone;
        UnturnedPlayerEvents.OnPlayerUpdateBleeding += OnPlayerUpdateBleed;
        UnturnedPlayerEvents.OnPlayerDeath += OnPlayerUpdateDeath;
        UnturnedPlayerEvents.OnPlayerRevive += OnPlayerRevive;
        }



        protected override void Unload()
    {
        Logger.Log($"{Name} has been unloaded!");
        U.Events.OnPlayerConnected -= OnPlayerConnected;
        }


    private void OnPlayerConnected(UnturnedPlayer player)
    {
        
        UnturnedChat.Say($"{player.DisplayName} joined the server!");
        EffectManager.sendUIEffect(22000, 22, true);
        player_sendui(player);

        var flag = 0;
        player.Player.disablePluginWidgetFlag(EPluginWidgetFlags.ShowLifeMeters);
        player.Player.disablePluginWidgetFlag(EPluginWidgetFlags.ShowStatusIcons);




        }


    private void OnPlayerUpdateHealth(UnturnedPlayer player, byte health)
    {
            player_sendui(player);
    }

    private void OnPlayerUpdateFood(UnturnedPlayer player, byte health)
    {
        player_sendui(player);
    }


    private void OnPlayerUpdateWater(UnturnedPlayer player, byte health)
    {
        player_sendui(player);
    }

    private void OnPlayerUpdatestamina(UnturnedPlayer player, byte health)
    {
        player_sendui(player);
    }

    private void OnPlayerUpdateVirus(UnturnedPlayer player, byte health)
    {
        player_sendui(player);
    }
    private void OnPlayerUpdateBone(UnturnedPlayer player, bool broken)
    {
        player_sendui(player);
    }

    private void OnPlayerUpdateBleed(UnturnedPlayer player, bool bleed)
    {
        player_sendui(player);
    }


    private void OnPlayerUpdateDeath(UnturnedPlayer player, EDeathCause cause, ELimb limb, CSteamID murderer)
    {
        player_sendui(player);
    }

    private void OnPlayerRevive(UnturnedPlayer player, UnityEngine.Vector3 position, byte angle)
    {
        player_sendui(player);
    }



        private void UI_update(ITransportConnection Player_weird,UnturnedPlayer player_object)
    {
            if (player_object.Health == 100){
                EffectManager.sendUIEffectVisibility(22,Player_weird,true , "100", true);
            }else if (player_object.Health > 75){
                EffectManager.sendUIEffectVisibility(22, Player_weird, true, "99_76", true);
            }else if (player_object.Health > 50){
                EffectManager.sendUIEffectVisibility(22, Player_weird, true, "75_51", true);
            }else if (player_object.Health > 25){
                EffectManager.sendUIEffectVisibility(22, Player_weird, true, "50_26", true);
            }else if (player_object.Health > 0){
                EffectManager.sendUIEffectVisibility(22, Player_weird, true, "25_1", true);
            }else{
                EffectManager.sendUIEffectVisibility(22,Player_weird,true,"0",true);
            }

            if (player_object.Hunger == 100){
                EffectManager.sendUIEffectVisibility(22,Player_weird,true , "100_food", true);
            }else if (player_object.Hunger > 75){
                EffectManager.sendUIEffectVisibility(22, Player_weird, true, "99_76_food", true);
            }else if (player_object.Hunger > 50){
                EffectManager.sendUIEffectVisibility(22, Player_weird, true, "75_51_food", true);
            }else if (player_object.Hunger > 25){
                EffectManager.sendUIEffectVisibility(22, Player_weird, true, "50_26_food", true);
            }else if (player_object.Hunger > 0){
                EffectManager.sendUIEffectVisibility(22, Player_weird, true, "25_1_food", true);
            }else{
                EffectManager.sendUIEffectVisibility(22,Player_weird,true, "0_food", true);
            }

            if (player_object.Thirst == 100){
                EffectManager.sendUIEffectVisibility(22,Player_weird,true , "100_water", true);
            }else if (player_object.Thirst > 75){
                EffectManager.sendUIEffectVisibility(22, Player_weird, true, "99_76_water", true);
            }else if (player_object.Thirst > 50){
                EffectManager.sendUIEffectVisibility(22, Player_weird, true, "75_51_water", true);
            }else if (player_object.Thirst > 25){
                EffectManager.sendUIEffectVisibility(22, Player_weird, true, "50_26_water", true);
            }else if (player_object.Thirst > 0){
                EffectManager.sendUIEffectVisibility(22, Player_weird, true, "25_1_water", true);
            }else{
                EffectManager.sendUIEffectVisibility(22,Player_weird,true, "0_water", true);
            }

            if (player_object.Stamina == 100){
                EffectManager.sendUIEffectVisibility(22,Player_weird,true , "100_stamina", true);
            }else if (player_object.Stamina > 75){
                EffectManager.sendUIEffectVisibility(22, Player_weird, true, "99_76_stamina", true);
            }else if (player_object.Stamina > 50){
                EffectManager.sendUIEffectVisibility(22, Player_weird, true, "75_51_stamina", true);
            }else if (player_object.Stamina > 25){
                EffectManager.sendUIEffectVisibility(22, Player_weird, true, "50_26_stamina", true);
            }else if (player_object.Stamina > 0){
                EffectManager.sendUIEffectVisibility(22, Player_weird, true, "25_1_stamina", true);
            }else{
                EffectManager.sendUIEffectVisibility(22,Player_weird,true, "0_stamina", true);
            }


            if (player_object.Infection == 100){
                EffectManager.sendUIEffectVisibility(22,Player_weird,true , "100_radiation", true);
            }else if (player_object.Infection > 75){
                EffectManager.sendUIEffectVisibility(22, Player_weird, true, "99_76_radiation", true);
            }else if (player_object.Infection > 50){
                EffectManager.sendUIEffectVisibility(22, Player_weird, true, "75_51_radiation", true);
            }else if (player_object.Infection > 25){
                EffectManager.sendUIEffectVisibility(22, Player_weird, true, "50_26_radiation", true);
            }else if (player_object.Infection > 0){
                EffectManager.sendUIEffectVisibility(22, Player_weird, true, "25_1_radiation", true);
            }else{
                EffectManager.sendUIEffectVisibility(22,Player_weird,true, "0_radiation", true);
            }

         


            if (player_object.Bleeding == true && player_object.Broken == true)
            {
                EffectManager.sendUIEffectVisibility(22, Player_weird, true, "bone_and_bleed", true);
            }
            else
            {
                EffectManager.sendUIEffectVisibility(22, Player_weird, true, "bone_and_bleed", false);
            }

            if (player_object.Bleeding == true && player_object.Broken == false) {
                EffectManager.sendUIEffectVisibility(22, Player_weird, true, "bleed_on", true);
            }else{
                EffectManager.sendUIEffectVisibility(22, Player_weird, true, "bleed_on", false);
            }

            if (player_object.Broken == true && player_object.Bleeding == false) {
                EffectManager.sendUIEffectVisibility(22, Player_weird, true, "bone_on", true);
            }else{
                EffectManager.sendUIEffectVisibility(22, Player_weird, true, "bone_on", false);
            }

    }

    private void player_sendui(UnturnedPlayer player)
        {
            Logger.Log("fuck you tem");
            CSteamID SteamID = player.CSteamID;
            ITransportConnection transportConnection = Provider.findTransportConnection(SteamID);
             
            UI_update(transportConnection, player);
        } 


    }
}