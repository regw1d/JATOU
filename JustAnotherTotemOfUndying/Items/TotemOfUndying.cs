using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JustAnotherTotemOfUndying.Items
{
    public class TotemOfUndying : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 8;
            Item.height = 8;
            Item.rare = ItemRarityID.Yellow;
            Item.value = Item.sellPrice(gold: 5);
            Item.maxStack = 1;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.GoldBar, 10)
                .AddIngredient(ItemID.LifeCrystal, 1)
                .AddIngredient(ItemID.FragmentSolar, 2)
                .AddIngredient(ItemID.FragmentVortex, 2)
                .AddIngredient(ItemID.FragmentNebula, 2)
                .AddIngredient(ItemID.FragmentStardust, 2)
                .AddIngredient(ItemID.SoulofLight, 4)
                .AddIngredient(ItemID.SoulofNight, 4)
                .AddTile(TileID.LunarCraftingStation)
                .Register();

            CreateRecipe()
                .AddIngredient(ItemID.PlatinumBar, 10)
                .AddIngredient(ItemID.LifeCrystal, 1)
                .AddIngredient(ItemID.FragmentSolar, 2)
                .AddIngredient(ItemID.FragmentVortex, 2)
                .AddIngredient(ItemID.FragmentNebula, 2)
                .AddIngredient(ItemID.FragmentStardust, 2)
                .AddIngredient(ItemID.SoulofLight, 4)
                .AddIngredient(ItemID.SoulofNight, 4)
                .AddTile(TileID.LunarCraftingStation)
                .Register();
        }
    }
}