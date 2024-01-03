using Terraria.ModLoader;
using Terraria;

namespace PreHardmodeExclusiveItemRecipes.Content.Items.Globals
{
    public class RecipeAdder
        : GlobalItem
    {
        public override void AddRecipes()
        {
            Recipe.Create(Terraria.ID.ItemID.HelFire)
                .AddCustomShimmerResult(Terraria.ID.ItemID.Cascade)
                .Register();

            Recipe.Create(Terraria.ID.ItemID.ZapinatorOrange)
                .AddCustomShimmerResult(Terraria.ID.ItemID.ZapinatorGray)
                .Register();
        }
    }
}
