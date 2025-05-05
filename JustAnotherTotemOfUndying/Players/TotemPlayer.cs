using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.Audio;
using Terraria.DataStructures;

namespace JustAnotherTotemOfUndying.Players
{
    public class TotemPlayer : ModPlayer
    {
        public override bool PreKill(double damage, int hitDirection, bool pvp, ref bool playSound, ref bool genGore, ref PlayerDeathReason damageSource)
        {
            if (Player.inventory.Any(item => item.type == ModContent.ItemType<Items.TotemOfUndying>() && item.stack > 0))
            {
                Item totem = Player.inventory.First(item => item.type == ModContent.ItemType<Items.TotemOfUndying>() && item.stack > 0);
                totem.stack--;
                if (totem.stack <= 0)
                {
                    totem.TurnToAir();
                }
                Player.statLife += 150;
                if (Player.statLife > Player.statLifeMax2)
                {
                    Player.statLife = Player.statLifeMax2;
                }
                Player.AddBuff(BuffID.Gills, 600);
                Player.AddBuff(BuffID.ObsidianSkin, 600);
                Player.AddBuff(BuffID.Regeneration, 600);
                Player.AddBuff(BuffID.Swiftness, 600);
                Player.AddBuff(BuffID.Ironskin, 600);
                SoundEngine.PlaySound(JustAnotherTotemOfUndying.TotemSound, Player.position);
                Main.NewText("Totem activated!", Color.Yellow);
                return false;
            }
            return true;
        }
    }
}