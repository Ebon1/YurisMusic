using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YurisMusic
{
    public class YurisMusic : Mod
    {
    }
    public class YurisMusicSystem : ModSystem
    {
    }
    public class YUnderworld : ModSceneEffect
    {
        public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Underworld");
        public override SceneEffectPriority Priority => SceneEffectPriority.Environment;
        public override bool IsSceneEffectActive(Player player)
        {
            return player.ZoneUnderworldHeight;
        }
    }
    public class YEoC : ModSceneEffect
    {
        public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/EoC");
        public override SceneEffectPriority Priority => SceneEffectPriority.BossLow;
        public override bool IsSceneEffectActive(Player player)
        {
            return NPC.AnyNPCs(NPCID.EyeofCthulhu);
        }
    }
}