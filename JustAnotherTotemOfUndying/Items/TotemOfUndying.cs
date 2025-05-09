using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JustAnotherTotemOfUndying.Items
{
    public class TotemOfUndying : ModItem
    {
        public override void SetStaticDefaults()
        {
        }

        public override void SetDefaults()
        {
            Item.width = 16;
            Item.height = 16;
            Item.rare = (byte)ItemRarityID.Yellow;
            Item.value = Item.sellPrice(gold: 10);
            Item.maxStack = 1;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.GoldBar, 30)
                .AddIngredient(ItemID.LifeCrystal, 1)
                .AddIngredient(ItemID.FragmentSolar, 4)
                .AddIngredient(ItemID.FragmentVortex, 4)
                .AddIngredient(ItemID.FragmentNebula, 4)
                .AddIngredient(ItemID.FragmentStardust, 4)
                .AddIngredient(ItemID.SoulofLight, 15)
                .AddIngredient(ItemID.SoulofNight, 15)
                .AddTile(TileID.LunarCraftingStation)
                .Register();

            CreateRecipe()
                .AddIngredient(ItemID.PlatinumBar, 30)
                .AddIngredient(ItemID.LifeCrystal, 1)
                .AddIngredient(ItemID.FragmentSolar, 4)
                .AddIngredient(ItemID.FragmentVortex, 4)
                .AddIngredient(ItemID.FragmentNebula, 4)
                .AddIngredient(ItemID.FragmentStardust, 4)
                .AddIngredient(ItemID.SoulofLight, 15)
                .AddIngredient(ItemID.SoulofNight, 15)
                .AddTile(TileID.LunarCraftingStation)
                .Register();
        }
    }
}
