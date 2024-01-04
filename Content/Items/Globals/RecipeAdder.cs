using Terraria.ID;
using Terraria.ModLoader;

namespace PreHardmodeExclusiveItemRecipes.Content.Items.Globals
{
    public class RecipeAdder
        : GlobalItem
    {
        public override void SetStaticDefaults()
        {
            ItemID.Sets.ShimmerTransformToItem[ItemID.HelFire] = ItemID.Cascade;
            ItemID.Sets.ShimmerTransformToItem[ItemID.ZapinatorOrange] = ItemID.ZapinatorGray;
        }
    }
}
