using System.Numerics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerraArchive.Items.Halos.HaloYuuka
{
    [AutoloadEquip(EquipType.Head)]
    public class HaloYuuka : HaloItem
    {
        public override void SetStaticDefaults()
        {
            ArmorIDs.Head.Sets.DrawFullHair[Item.headSlot] = true;
        }
        public override void SetDefaults()
        {
            Item.SetNameOverride("Yuuka's Halo");
            Item.width = 6;
            Item.height = 4;
            Item.rare = ItemRarityID.Blue;
            Item.value = Item.sellPrice(silver: 75);
            Item.maxStack = 1;
        }
    }
}
