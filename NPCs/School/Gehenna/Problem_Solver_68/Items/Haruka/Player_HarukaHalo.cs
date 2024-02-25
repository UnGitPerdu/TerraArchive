using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace testsensei.Haruka
{
    [AutoloadEquip(EquipType.Beard)]
    public class Player_HarukaHalo : ModItem
    {
        public override void SetStaticDefaults()
        {
            ArmorIDs.Beard.Sets.UseHairColor[Item.beardSlot] = false;
        }

        public override void SetDefaults()
        {
            Item.width = 30;
            Item.height = 100;
            Item.maxStack = 1;
            Item.value = Item.sellPrice(0, 1);
            Item.accessory = true;
            Item.vanity = true;
        }
    }

}