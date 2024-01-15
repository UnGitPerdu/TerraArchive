using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace TerraArchive.WIP.MilleniumStudentCouncil.Items.Yuuka
{
    internal class ScientificCalculator : ModItem 
    {
        public static readonly int RangedAttackSpeedBonus = 15;
        public static readonly int RangedAttackDamageBonus = 15;

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            TooltipLine StatTooltip = new TooltipLine(Mod, "Tooltip0", "+15% ranged damage and velocity");
            tooltips.Add(StatTooltip);

            TooltipLine ModTooltip = new TooltipLine(Mod, "TerraArchive", "A scientific calculator that Yuuka carries with her at all times.\r\nDespite possessing excellent mental arithmetic skills,\r\nYuuka always uses the calculator for calculations in her pursuit of perfection.") { OverrideColor = Color.Goldenrod };
            tooltips.Add(ModTooltip);
        }

        public override void SetDefaults()
        {
            Item.width = 40;
            Item.height = 40;
            Item.accessory = true;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            // GetAttackSpeed is functionally identical to GetDamage and GetKnockback; it's for attack speed.
            // In this case, we'll make ranged weapons 15% faster to use overall.
            // NOTE: Zero or a negative value as the result of these calculations will throw an exception. Plan accordingly.
            player.GetAttackSpeed(DamageClass.Ranged) += RangedAttackSpeedBonus / 100f;
            player.GetDamage(DamageClass.Ranged) += RangedAttackDamageBonus / 100f;
        }
    }
}
