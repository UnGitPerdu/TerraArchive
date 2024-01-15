using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerraArchive.NPCs.School.Millenium.Millenium_Student_Council.NPC.Koyuki
{
    internal class Mulli : ModItem
    {
        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            TooltipLine AmmoConTooltip = new TooltipLine(Mod, "Tooltip0", "Has a 50% chance to not consume ammo");
            tooltips.Add(AmmoConTooltip);

            TooltipLine ModTooltip = new TooltipLine(Mod, "TerraArchive", "A machine gun that has overcome all kinds of hardships together with Koyuki.\r\nIt changed its color when it was sent for repair once. It is a sturdy gun, just like\r\nKoyuki, who does not care about trivial things. ") { OverrideColor = Color.Goldenrod };
            tooltips.Add(ModTooltip);
        }

        public override void SetDefaults()
        {
            // Common Properties
            Item.width = 54; // Hitbox width of the item.
            Item.height = 21; // Hitbox height of the item.
            Item.scale = 1f;
            Item.rare = ItemRarityID.Cyan; // The color that the item's name will be in-game.

            // Use Properties
            Item.useTime = 7; // The item's use time in ticks (60 ticks == 1 second.)
            Item.useAnimation = 7; // The length of the item's use animation in ticks (60 ticks == 1 second.)
            Item.useStyle = ItemUseStyleID.Shoot; // How you use the item (swinging, holding out, etc.)
            Item.autoReuse = true; // Whether or not you can hold click to automatically use it again.

            Item.UseSound = SoundID.Item36;

            // Weapon Properties
            Item.DamageType = DamageClass.Ranged; // Sets the damage type to ranged.
            Item.damage = 21; // Sets the item's damage. Note that projectiles shot by this weapon will use its and the used ammunition's damage added together.
            Item.knockBack = 1.5f; // Sets the item's knockback. Note that projectiles shot by this weapon will use its and the used ammunition's knockback added together.
            Item.noMelee = true; // So the item's animation doesn't do damage.

            // Gun Properties
            Item.shoot = ProjectileID.PurificationPowder; // For some reason, all the guns in the vanilla source have this.
            Item.shootSpeed = 8f; // The speed of the projectile (measured in pixels per frame.)
            Item.useAmmo = AmmoID.Bullet; // The "ammo Id" of the ammo item that this weapon uses. Ammo IDs are magic numbers that usually correspond to the item id of one item that most commonly represent the ammo type.
        }

        public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
        {
            velocity = velocity.RotatedByRandom(MathHelper.ToRadians(5));
        }

        public override bool CanConsumeAmmo(Item ammo, Player player)
        {
            return Main.rand.NextFloat() >= 0.50f;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.IronBar, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }
        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-2f, -2f);
        }
    }
}
