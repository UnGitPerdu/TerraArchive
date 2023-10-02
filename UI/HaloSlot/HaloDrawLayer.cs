using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace TerraArchive.UI.HaloSlot
{
    public class HaloDrawLayer : PlayerDrawLayer
    {

        private Asset<Texture2D> HaloTexture;

        // Returning true in this property makes this layer appear on the minimap player head icon.
        public override bool IsHeadLayer => true;


        public override Position GetDefaultPosition() => new AfterParent(PlayerDrawLayers.Head);

        protected override void Draw(ref PlayerDrawSet drawInfo)
        {
            if (HaloTexture == null)
            {
                //HaloTexture = ModContent.Request<Texture2D>("TerraArchive/Items/Armor/Halos/HaloYuuka/HaloYuuka");
            }
            var position = drawInfo.Center;
            position = new Vector2((int)position.X, (int)position.Y); // You'll sometimes want to do this, to avoid quivering.
        }
    }
}
