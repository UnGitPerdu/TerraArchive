using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerraArchive.Items.Accessories.tier_1_items
{
    [AutoloadEquip(EquipType.Head)]
    public class T1_PlainBaseballCap : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 16;
            Item.height = 16;

            // Common values for every boss mask
            Item.rare = ItemRarityID.Blue;
            Item.value = Item.sellPrice(silver: 75);
            Item.vanity = true;
            Item.maxStack = 1;
        }
    }
}
