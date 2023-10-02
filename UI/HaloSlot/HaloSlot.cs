using Microsoft.Xna.Framework;
using TerraArchive.Items.Halos;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerraArchive.UI.HaloSlot
{
    [AutoloadEquip(EquipType.Head)]
    public class HaloSlot : ModAccessorySlot
    {
        public override Vector2? CustomLocation => new Vector2(7 * Main.screenWidth / 8, 2 * Main.screenHeight / 5);

        public override string FunctionalBackgroundTexture => "Terraria/Images/Inventory_Back7"; // pale blue
        public override string VanityBackgroundTexture => "Terraria/Images/Inventory_Back14"; // yellow
        public override string FunctionalTexture => "TerraArchive/Items/Halos/HaloItem";
        public override bool DrawDyeSlot => false;
        public override bool DrawFunctionalSlot => base.DrawFunctionalSlot;

        public override bool PreDraw(AccessorySlotType context, Item item, Vector2 position, bool isHovered)
        {
            return true;
        }

        public override bool CanAcceptItem(Item checkItem, AccessorySlotType context)
        {
            if (checkItem.ModItem is HaloItem) // if subclass is HaloItem
                return true;

            return false; // Otherwise nothing in slot
        }

        public override void OnMouseHover(AccessorySlotType context)
        {
            // We will modify the hover text while an item is not in the slot, so that it says it's for a Halo.
            switch (context)
            {
                case AccessorySlotType.FunctionalSlot:
                    Main.hoverItemName = "Halo";
                    break;
                case AccessorySlotType.VanitySlot:
                    Main.hoverItemName = "Vanity Halo";
                    break;
            }
        }

    }
}
