using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Audio;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;

namespace JustAnotherTotemOfUndying.Players
{
    public class TotemPlayer : ModPlayer
    {
        public override bool PreKill(double damage, int hitDirection, bool pvp, ref bool playSound, ref bool genGore, ref PlayerDeathReason damageSource)
        {
            for (int i = 0; i < Player.inventory.Length; i++)
            {
                Item item = Player.inventory[i];
                if (item.type == ModContent.ItemType<Items.TotemOfUndying>() && item.stack > 0)
                {
                    item.stack--;
                    if (item.stack <= 0)
                    {
                        item.SetDefaults(0);
                    }

                    Player.Heal(222);

                    Player.immune = true;
                    Player.immuneTime = 120;

                    Player.AddBuff(BuffID.Gills, 600);
                    Player.AddBuff(BuffID.ObsidianSkin, 600);
                    Player.AddBuff(BuffID.Regeneration, 600);
                    Player.AddBuff(BuffID.Swiftness, 600);
                    Player.AddBuff(BuffID.Ironskin, 600); 

                    SoundEngine.PlaySound(JustAnotherTotemOfUndying.TotemSound, Player.Center);
                    
                    for (int j = 0; j < 69; j++)
                    {
                        Vector2 speed = Main.rand.NextVector2Circular(1f, 1f);
                        Dust d1 = Dust.NewDustPerfect(Player.Center, DustID.GoldFlame, speed * 5, 150, default, 1.5f);
                        d1.noGravity = true;
                        Dust d2 = Dust.NewDustPerfect(Player.Center, DustID.GreenTorch, speed * 3, 150, default, 1.5f);
                        d2.noGravity = true;
                    }

                    return false;
                }
            }
            
            return true;
        }
    }
}